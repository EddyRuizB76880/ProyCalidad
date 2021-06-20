using EmprendeUCR_WebApplication.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
/* Manfred Carvajal - Luis Rojas
 * mejorar el correo de confirmaciion cuando se registra un usuario por primera vez 
 * crear funcionalidad de contraseña olvidada
 */

namespace EmprendeUCR_WebApplication.Data.Services
{
    public class MailService
    {
        public string getMailBody(string hash_mail, int type_user)
        {
            string url = "";
            string result = "";
            if (type_user == 1) //CREACIÓN DE CLIENTE
            {
                Console.WriteLine(type_user);
                url = Global.DomainName + "RegistrationDataClient?email=" + hash_mail;

                result = string.Format(@"<div style='text-align:center;'>
                                    <h1>Bienvenido a EmprendeUCR</h1>
                                    <h3>Haga click sobre el link debajo para registrarse como cliente</h3>
                                    <a href=" + '"' + url + '"' +
                                   ">Confirmar email</a> </div>", url, hash_mail);
            }
            if (type_user == 2) //CREACIÓN DE EMPRESARIO
            {
                Console.WriteLine(type_user);
                url = Global.DomainName + "registrationDataEntrepreneur?email=" + hash_mail;

                result = string.Format(@"<div style='text-align:center;'>
                                    <h1>Bienvenido a EmprendeUCR</h1>
                                    <h3>Haga click sobre el link debajo para registrarse como emprendedor</h3>
                                    <a href=" + '"' + url + '"' +
                                   ">Confirmar email</a> </div>", url, hash_mail);
            }
            if (type_user == 3) //CREACIÓN DE ADMINISTRADOR
            {
                Console.WriteLine(type_user);
                url = Global.DomainName + "registrationDataAdministrator?email=" + hash_mail;

                result = string.Format(@"<div style='text-align:center;'>
                                    <h1>Bienvenido a EmprendeUCR</h1>
                                    <h3>Haga click sobre el link debajo para registrarse como administrador</h3>
                                    <a href=" + '"' + url + '"' +
                                   ">Confirmar email</a> </div>", url, hash_mail);
            }

            return result;
           
        }


        public string getNewPasswordMail(string hash_mail)
        {
            string url = "";
            string result = "";

            url = Global.DomainName + "NewPassword?email=" + hash_mail;

            result = string.Format(@"<div style='text-align:center;'>
                                <h1>Recuperación de contraseña</h1>
                                <h3>Haga click sobre el link debajo para cambiar a una nueva contraseña</h3>
                                <a href=" + '"' + url + '"' +
                                ">Cambiar contraseña</a> </div>", url, hash_mail);

            
            return result;
        }

        public async Task<string> SendMail(Mail mailClass)
        {
            try
            {
                using (MailMessage mail = new MailMessage()) {
                    mail.From = new MailAddress(mailClass.FromMailId);
                    Console.WriteLine(mail.From);
                    mailClass.ToMailIds.ForEach(x =>
                    {
                        Console.WriteLine(x);
                        mail.To.Add(x);
                    });

                    mail.Body = mailClass.Body;
                    Console.WriteLine(mail.Subject);
                    mail.Subject = mailClass.Subject;
                    mail.IsBodyHtml = mailClass.IsBodyHtml;

                    mailClass.Attachements.ForEach(x =>
                    {
                        mail.Attachments.Add(new Attachment(x));
                    });

                    using (SmtpClient smtp = new SmtpClient ("smtp.gmail.com", 587)) 
                    {
                        smtp.Credentials = new System.Net.NetworkCredential(mailClass.FromMailId, mailClass.FromMailIdPassword);
                        smtp.EnableSsl = true;
                        await smtp.SendMailAsync(mail);
                        return "Mensaje enviado";
                    }
                }
            }
            catch (Exception ex) 
            {
                return ex.Message;
            }
        }
    }
}
