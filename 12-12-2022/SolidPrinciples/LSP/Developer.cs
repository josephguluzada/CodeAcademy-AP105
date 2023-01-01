using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    internal class Developer : Person, IExperience
    {
        public string GetExperience()
        {
            return "Developer experience";
        }

        public override string GetFullName()
        {
            return "Developer Full name";
        }
    }
}
