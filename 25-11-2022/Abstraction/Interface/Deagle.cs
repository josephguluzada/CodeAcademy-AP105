using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Deagle : Weapon ,IWeapon, ISingleWeapon
    {
        public string Material;

        public void Reload()
        {
            base.BulletCount = base.MaximumCapacity;
        }

        public void Shoot()
        {
            base.BulletCount -= 1;
        }
    }
}
