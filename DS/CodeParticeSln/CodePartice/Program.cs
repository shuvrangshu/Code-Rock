using System;
using System.Threading.Tasks;

namespace CodePartice
{
    class Program
    {
        static void Main(string[] args)
        {
            var _vedioProc = new VedioProc();

            IService _service = new MailService();
            _vedioProc.vedioEncoded += _service.send;
            _vedioProc.EncodeVedio();

            Console.WriteLine("Enter Name...");
            string name = Console.ReadLine();
            Console.WriteLine("Your Name : " + name);
            Console.ReadLine();
        }

        static void methodOne()
        {
            Task.Delay(10000).Wait();
            Console.WriteLine("Download File 1.....");
        }

        static void methodTwo()
        {
            Task.Delay(10000).Wait();
            Console.WriteLine("Download File 1.....");
        }
    }
}
