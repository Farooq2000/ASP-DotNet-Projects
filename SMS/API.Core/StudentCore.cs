using Common;
using DataService.IRepo;
using DataService.Repo;
using MailKit.Net.Smtp;
using MimeKit;
using SMS.Common;
using SMS.Model;
using SMS.Model.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
//using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace API.Core
{
    public class StudentCore
    {
        IRepository<Student> _iRepostory;
        IRepository<Users> _iRepositoryUser;
        ApiResponse apiResponse = new ApiResponse();
        Users user = new Users();
        private readonly Random _random = new Random();
        public StudentCore(IRepository<Student> iRepository, IRepository<Users> iRepositoryUser)
        {
            _iRepostory = iRepository;
            _iRepositoryUser = iRepositoryUser;
        }
        // RandomPassword randomPassword = new RandomPassword();

        public ApiResponse Create(Student model)
        {
            
            string Htmlcontent = string.Empty;
            model.InsertedOn = DateTime.UtcNow.ToString();
            // Student student = _iRepostory.Search<Student>(new { CNIC=model.CNIC}, Constant.SearchStudent).FirstOrDefault();
            Users serachuser = _iRepositoryUser.Search<Users>(new { CNIC = model.CNIC }, Constant.SearchFromUser).FirstOrDefault();
            if (serachuser == null)
            {
                Student studentResponse = _iRepostory.Create(model);
                user.EntityId = studentResponse.StudentId;
                user.UserRoleId = (int)Enumerations.UserType.Student;
                user.Email = studentResponse.Email;
                user.Password = RandomPassword.CreatePassword(8);
                Users InsertedUser = _iRepositoryUser.Create(user);


                //Htmlcontent = Util.CreateEmailBody("G:\\ASP DotNet Projects\\SMS\\SMS\\Content\\loginEmail");
                //Htmlcontent = Htmlcontent.Replace("{{CompanyName}}", "Farooq Company");
                //Htmlcontent = Htmlcontent.Replace("{{ Name }}", studentResponse.FirstName + " " + studentResponse.LastName);
                //Htmlcontent = Htmlcontent.Replace("{{ Email }}", user.Email);
                //Htmlcontent = Htmlcontent.Replace("{{ Password }}", user.Password);
                //Htmlcontent = Htmlcontent.Replace("{{email}}", "Farooq@gmail.com");

                //await EmailProvider.CreateEmail(null, new List<string>() { user.Email })
                //          .WithSubject("New Added")
                //          .WithHtmlContent(Htmlcontent)
                //          .Send();
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("SMS", "mfarooq20feb@gmail.com"));
                message.To.Add(new MailboxAddress("BUKC", "f4farooq@yahoo.com"));
                message.Subject = "test mail";
                message.Body = new TextPart("plain")
                {
                    Text = (studentResponse.FirstName + "" + studentResponse.LastName + "" + user.Email + "" + user.Password).ToString(),
                };

                //using (var client = new SmtpClient())
                //{
                //    client.ServerCertificateValidationCallback =
                //        (sender, certificate, certChainType, errors) => true;
                //    client.AuthenticationMechanisms.Remove("XOAUTH2");

                //    // connection
                //    client.Connect("smtp.host", 465, true);
                //    client.Authenticate("mfarooq20feb@gmail.com", "03152221752");//error occurs here
                //    string email = "oa34419@gmail.com";
                //    client.Send(email);
                //    client.Disconnect(true);
                //}
                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 465, true);
                    client.Authenticate("mfarooq20feb@gmail.com", "03152221752");
                    client.Send(message);
                    client.Disconnect(true);
                }

            }
            else
            {
                apiResponse.Status = 1;
                apiResponse.Message = model.CNIC + "Sorry! Already Exsist";
            }
            return apiResponse;
        }

        public ApiResponse Update(Student model)
        {
            model.UpdatedOn = DateTime.UtcNow.ToString();
            apiResponse.Response = _iRepostory.Update(model);
            return apiResponse;
        }
        public ApiResponse Search(Student model)
        {
            Object searchStudentRecord = new
            {
                StudentId = model.StudentId,
                FirstName = model.FirstName,
                LastName = model.LastName,
                CNIC = model.CNIC,
                Email = model.Email
            };
            List<Student> StudentList = _iRepostory.Search<Student>(searchStudentRecord, Constant.SearchStudent).ToList();
            apiResponse.Response = StudentList;
            return apiResponse;
        }
    }
}
//string Htmlcontent = string.Empty;
/*
 Htmlcontent = Htmlcontent.Replace("{{Logo}}", logoUrl);
                    Htmlcontent = Htmlcontent.Replace("{{weblink}}", plgmanager.DomainName);
                    Htmlcontent = Htmlcontent.Replace("{{partnername}}", plgmanager.PartnerName);
                    Htmlcontent = Htmlcontent.Replace("{{phone}}", plgmanager.Phone);
 */
/*
await EmailProvider.CreateEmail(null, new List<string>() { item.Email })
                          .WithSubject("New" + NewAddedEntityLevel + "Added")
                          .WithHtmlContent(Htmlcontent)
                          .Send();
 */