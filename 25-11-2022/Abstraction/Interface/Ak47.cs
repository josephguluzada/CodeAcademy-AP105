using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Ak47 : Weapon,IWeapon, IAutomaticWeapon, ISingleWeapon
    {
        public string CountyName;

        public void Fire()
        {
            base.BulletCount = 0;
        }

        public void Shoot()
        {
            base.BulletCount -= 1;
        }

        public void Reload()
        {
            base.BulletCount = base.MaximumCapacity;
        }
    }
}
