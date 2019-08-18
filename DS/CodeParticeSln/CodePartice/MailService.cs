using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePartice
{
    public class MailService : IService
    {

        public void send(object sender, EventArgs e)
        {
            Console.WriteLine("Mail sms....");
        }
    }
}
