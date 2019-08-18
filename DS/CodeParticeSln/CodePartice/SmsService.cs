using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePartice
{
   public class SmsService : IService
    {
       public void send(object sender, EventArgs e)
        {
            Console.WriteLine("Send sms....");
        }
    }
}
