using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingRecovery.Interface
{
    class CurvedSword : IWeapon
    {
        public int BaseDamage
        {
            get { return 10; }
        }

        public void Slash(int damage, string attackMessage)
        {
            Console.WriteLine("Slash with Curved Sword: player did "+ (damage * BaseDamage) + "amount of damage." + attackMessage);
        }

        public void Thrust(int damage, string attackMessage)
        {
            Console.WriteLine("Thrust with Curved Sword: player did "+ (damage * BaseDamage) + "amount of damage." + attackMessage);
        }
    }
}
