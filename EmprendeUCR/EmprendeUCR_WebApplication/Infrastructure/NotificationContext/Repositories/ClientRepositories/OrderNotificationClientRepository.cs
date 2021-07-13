using EmprendeUCR_WebApplication.Domain.Core.Repositories;
using EmprendeUCR_WebApplication.Domain.NotificationContext;
using EmprendeUCR_WebApplication.Domain.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.Abstracts;
using TableDependency.SqlClient.Base.EventArgs;
using TableDependency.SqlClient.Where;

namespace EmprendeUCR_WebApplication.Infrastructure.NotificationContext.Repositories.ClientRepositories
{
    public class OrderNotificationClientRepository : INotificationRepository
    {
        private readonly NotificationDbContext _dbContext;
        public IUnitOfWork UnitOfWork => _dbContext;
        private IConfiguration _configuration;
        public INotificationRepository Next { set; get; }
        private string EmailToListen { set; get; }
        public event newEventNotification onEventNotification;
        SqlTableDependency<OrderNotificationClient> sqlTableDependency;
        public OrderNotificationClientRepository(NotificationDbContext unitOfWork, IConfiguration configuration)
        {
            _dbContext = unitOfWork;
            _configuration = configuration;
        }

        public void EventsSubscriptions(UserNotification UserNotification)
        {
            // Subscription is created
            // Email that wants to be listen
            this.EmailToListen = UserNotification.Email;

            var mapper = new ModelToTableMapper<OrderNotificationClient>();

            mapper.AddMapping(e => e.ClientEmail, "Client_Email");
            // Where clause
            Expression<Func<OrderNotificationClient, bool>> expression = e =>
                  (e.State == "Aceptado" || e.State == "Rechazado") && e.ClientEmail == (string)EmailToListen; //"soru1097@gmail.com"

            ITableDependencyFilter whereCondition = new SqlTableDependencyFilter<OrderNotificationClient>(
            expression,
            mapper);
            // Create dependency in Order table with previous where clause
            sqlTableDependency = new SqlTableDependency<OrderNotificationClient>(_configuration.GetConnectionString("DefaultConnection"), "Order", filter: whereCondition, mapper: mapper);
            sqlTableDependency.OnChanged += this.OrderClientChange;
            
            if (Next is not null) {
                Next.EventsSubscriptions(UserNotification);
            }
            // User subscribed
            this.onEventNotification += UserNotification.QuantityEvent;
            // Begin to listen changes
            sqlTableDependency.Start();
        }

        public void GetNotifications(UserNotification UserNotification)
        {
            List<Notification> list =
                   _dbContext.OrderNotificationClients.
                       Where(e => e.ClientEmail == UserNotification.Email && (e.State == "Rechazado" || e.State == "Aceptado") )
                       .ToList<Notification>();
            UserNotification.setNewNotifications(list);
            if (Next is not null)
            {
                Next.GetNotifications(UserNotification);
            }
        }

        public void GetNotificationsQuantity(UserNotification UserNotification)
        {
            UserNotification.notificationQuantity += _dbContext.OrderNotificationClients.
                       Where(e => e.ClientEmail == UserNotification.Email && (e.State == "Rechazado" || e.State == "Aceptado"))
                       .Count();
        }

        private void OrderClientChange(object sender, RecordChangedEventArgs<OrderNotificationClient> e)
        {
            var changedEntity = e.Entity;
            if (changedEntity.ClientEmail == (string)EmailToListen && (changedEntity.State == "Aceptado" || changedEntity.State == "Rechazado"))
            {
                if (changedEntity.view)
                {
                    onEventNotification.Invoke(this, new NotificationChangeEventArgs(false));
                }
                else
                {
                    onEventNotification.Invoke(this, new NotificationChangeEventArgs(true));
                }
            }
        }

        public void Unsubscription(UserNotification UserNotification)
        {
            this.onEventNotification -= UserNotification.QuantityEvent;
            // Begin to listen changes
            if (sqlTableDependency is not null) {
                sqlTableDependency.Stop();
            }          
        }
    }
}
