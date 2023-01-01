using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class Facebook : INotification
    {
        public void Send()
        {
            Console.WriteLine("Sended from Facebook service");
        }
    }
}
