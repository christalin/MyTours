using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyTours.Services
{
    public class DebugMailService : IMailService
    {
        void IMailService.SendMail(string to, string from, string subject, string body)
        {
           Debug.WriteLine($"Sending Mail: To: {to} From: {from} Subject: {subject}");
        }
    }
}
