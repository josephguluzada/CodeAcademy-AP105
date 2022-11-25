using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Glock18 : Weapon,IWeapon, IAutomaticWeapon, ISingleWeapon
    {
        public void Fire()
        {
            base.BulletCount = 0;
        }

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
