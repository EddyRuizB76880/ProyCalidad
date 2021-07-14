using EmprendeUCR_WebApplication.Domain.NotificationContext;
using FluentAssertions;
using FluentAssertions.Events;
using System;
using System.Threading.Tasks;
using Xunit;
namespace EmprendeUCR.UnitTests.Domain.NotificationContext
{
    public class UserNotificationTest
    {
        public int num = 2;
        public async Task quantityEvent2(object sender, NotificationChangeEventArgs e)
        {
            num = 3;
        }
        [Fact]
        public async Task ListenChangedQuantity()
        {
            // arrange
            var subject = new UserNotification("juan@test.com", 1);
            subject.OnNotificationChangeds += quantityEvent2;
            subject.notificationQuantity = 0;
            using (var monitoredSubject = subject.Monitor())
            {
                
                this.num.Should().Be(2);
                subject.QuantityEvent(this, new NotificationChangeEventArgs(true));
                this.num.Should().Be(3);
                subject.notificationQuantity.Should().Be(1);
                this.num.Should().Be(3);
            }
            
        }




    }
}