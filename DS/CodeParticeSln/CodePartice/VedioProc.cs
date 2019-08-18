using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePartice
{
   public class VedioProc
    {
       public event EventHandler vedioEncoded;
       public void EncodeVedio()
       {
           Console.WriteLine("Vedio encode starting...");
           EndcodeCompleted();
       }

       protected void EndcodeCompleted()
       {
           vedioEncoded(this, EventArgs.Empty);
       }

    }
}
