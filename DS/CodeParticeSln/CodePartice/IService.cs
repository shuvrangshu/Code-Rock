using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePartice
{
    public interface IService
    {
        void send(object sender, EventArgs e);
    }
}
