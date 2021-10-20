using Common;
using DataService.IRepo;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Repo
{
    //public class EmailProvider : IEmailProvider
    //{
    //    private SendGridMessage _mailMessage = null; 
    //   // SendGridClient client = new SendGridClient("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");

    //    string _content = string.Empty;
    //    string _htmlContent = string.Empty;
    //    string _subject = string.Empty;

    //    private EmailProvider(string fromAddress, List<string> toAddresses)
    //    {
    //        List<EmailAddress> toEmails = new List<EmailAddress>();
    //        Dictionary<string, string> listdictionary = new Dictionary<string, string>();
    //        foreach (var item in toAddresses)
    //        {
    //            toEmails.Add(new EmailAddress { Email = item });

    //            listdictionary.Add(item, item);
    //        }


    //        _mailMessage = MailHelper.CreateSingleEmailToMultipleRecipients(new EmailAddress(fromAddress), toEmails, string.Empty, string.Empty, string.Empty);
    //    }

    //    public static IEmailProvider CreateEmail(string fromAddress, List<string> strings)
    //    {
    //        fromAddress = !String.IsNullOrEmpty(fromAddress) ? fromAddress : Constant.FromEmail;
    //        return new EmailProvider(fromAddress, strings);
    //    }

         
    //    public IEmailProvider From(string fromAddress)
    //    {
    //        return this;
    //    }

         
    //    public IEmailProvider To(params string[] toAddresses)
    //    {
    //        EmailAddress emailaddress = new EmailAddress();
    //        List<EmailAddress> emailaddresslist = new List<EmailAddress>();
    //        foreach (string toAddress in toAddresses)
    //        {
    //            emailaddress.Email = toAddress;
    //            emailaddresslist.Add(emailaddress);
    //        }
    //        _mailMessage.AddTos(emailaddresslist);
    //        return this;
    //    }

         
    //    public IEmailProvider CC(params string[] ccAddresses)
    //    {
    //        //foreach (string ccAddress in ccAddresses)
    //        //{
    //        //    if (!string.IsNullOrEmpty(ccAddress))
    //        //        _mailMessage.AddCc(ccAddress);
    //        //}

    //        //return this;



    //        List<EmailAddress> emailaddresslist = new List<EmailAddress>();
    //        if (ccAddresses != null)
    //        {
    //            if (ccAddresses.ToList().Count > 0)
    //            {
    //                foreach (string toAddress in ccAddresses)
    //                {
    //                    EmailAddress emailaddress = new EmailAddress();
    //                    emailaddress.Email = toAddress;
    //                    emailaddresslist.Add(emailaddress);
    //                }
    //                _mailMessage.AddCcs(emailaddresslist);
    //            }
    //        }

    //        return this;

    //    }
         
    //    public IEmailProvider BCC(params string[] bccAddresses)
    //    {
    //        //foreach (string bccAddress in bccAddresses)
    //        //{
    //        //    if (!string.IsNullOrEmpty(bccAddress))
    //        //        _mailMessage.AddBcc(bccAddress);
    //        //}

    //        //return this;

    //        List<EmailAddress> emailaddresslist = new List<EmailAddress>();
    //        if (bccAddresses != null)
    //        {
    //            if (bccAddresses.ToList().Count > 0)
    //            {
    //                foreach (string toAddress in bccAddresses)
    //                {
    //                    EmailAddress emailaddress = new EmailAddress();
    //                    emailaddress.Email = toAddress;
    //                    emailaddresslist.Add(emailaddress);
    //                }
    //                _mailMessage.AddBccs(emailaddresslist);
    //            }
    //        }

    //        return this;
    //    }

    //    public IEmailProvider WithSubject(string subject)
    //    {
    //        _subject = subject;

    //        _mailMessage.SetSubject(_subject);


    //        return this;
    //    }
         
    //    /// <summary>
    //    /// text/plain  content Type
    //    /// </summary>
    //    /// <param name="content"></param>
    //    /// <returns></returns>
    //    public IEmailProvider WithContent(string content)
    //    {
    //        _content = content;

    //        _mailMessage.AddContent("text/plain", content);
    //        return this;
    //    }
    //    /// <summary>
    //    /// text/html ContentType
    //    /// </summary>
    //    /// <param name="htmlContent"></param>
    //    /// <returns></returns>

    //    public IEmailProvider WithHtmlContent(string content)
    //    {
    //        _htmlContent = content;

    //        _mailMessage.AddContent("text/html", content);
    //        return this;
    //    }
    //    public IEmailProvider WithAttachment(string filename, string filestream)
    //    {
    //        _mailMessage.AddAttachment(filename, filestream, "application/csv", "attachment", "banner");

    //        return this;
    //    }
    //    public IEmailProvider SetGlobalSubject(string subject)
    //    {
    //        _mailMessage.SetGlobalSubject(subject);
    //        return this;
    //    }
    //    public async Task<object> Send()
    //    {
    //        var ObjHttpResponse = await client.SendEmailAsync(_mailMessage);

    //        var emailResponse = ObjHttpResponse.Body.ReadAsStringAsync();

    //        var response = Newtonsoft.Json.JsonConvert.DeserializeObject<object>(emailResponse.Result);


    //        return await Task.FromResult(response);
    //    }
    //}
}
