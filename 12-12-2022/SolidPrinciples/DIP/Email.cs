using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class Email : INotification
    {
        public void Send()
        {
            Console.WriteLine("Sended from Email service");
        }
    }
}
