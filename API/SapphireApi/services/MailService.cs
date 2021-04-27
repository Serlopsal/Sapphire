using System;
using System.Text;
using System.Collections.Generic;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace SapphireApi.Services {
  public interface IMailService{
    Task SendMailAsync(string to, string subject, string body, List<string> CC = null, List<string> CCO = null);
    Task SendMailAsync(List<string> to, string subject, string body, List<string> CC = null, List<string> CCO = null);
  }
  public class MailService: IMailService {
    private class MailConfig {
      public string Username { get; set; }
      public string Password { get; set; }
      public string Host { get; set; }
      public int Port { get; set; }
    }
    MailConfig _client;

    public MailService(IConfiguration configuration){
      try{
        _client = new MailConfig();
        _client.Username = configuration["SmtpSettings:Username"];
        _client.Password = configuration["SmtpSettings:Password"];
        _client.Host = configuration["SmtpSettings:Host"];
        _client.Port = int.Parse(configuration["SmtpSettings:Port"]);
      }
      catch{
        _client = null;
      }
    }

    public async Task SendMailAsync(string to, string subject, string body, List<string> CC = null, List<string> CCO = null) => await SendMailAsync(new List<string>(){to},subject,body,CC,CCO);

    public async Task SendMailAsync(List<string> to, string subject, string body, List<string> CC = null, List<string> CCO = null) {
      var tag = "MailService";
      try{
        if(_client == null) throw new ArgumentException("The SmtpSetting was incorrectly setted");

        using(var mail = new MailMessage()){
          mail.From = new MailAddress(_client.Username);
          mail.Subject = subject;
          mail.BodyEncoding = Encoding.UTF8;
          mail.IsBodyHtml = true;
          mail.Body = body;

          if (to is not null && to.Count > 0 ) foreach(var address in to) mail.To.Add(address);
          else{
            Log.error(tag, "The email cannot be sended without at least one receiver");
            return ;
          }
          if (CC is not null && CC.Count > 0 ) foreach(var address in CC) mail.CC.Add(address);
          if (CCO is not null && CCO.Count > 0 ) foreach(var address in CCO) mail.Bcc.Add(address);
            
          using(var smtp = new System.Net.Mail.SmtpClient()) {
            Log.info(tag, _client.Host);
            smtp.Host = _client.Host;
            smtp.Port = _client.Port;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential(_client.Username, _client.Password);
            
              await smtp.SendMailAsync(mail);
              Log.success(tag, "Email sended successfully");
          }
        }
      }
      catch(Exception e) {
        Log.error(tag,e.StackTrace);
        throw e;
      }
    }
  }
}