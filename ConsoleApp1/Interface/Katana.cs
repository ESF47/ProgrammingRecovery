using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingRecovery.Interface
{
    class Katana : IWeapon
    {
        public int BaseDamage
        {
            get { return 10; }
        }

        public void Slash(int damage, string attackMessage)
        {
            Console.WriteLine("Slash with Katana: player did " + (damage * BaseDamage) + "amount of damage." + attackMessage);
        }

        public void Thrust(int damage, string attackMessage)
        {
            Console.WriteLine("Thrust with Katana: player did " + (damage * BaseDamage) + "amount of damage." + attackMessage);
        }

        public void Test() { }
    }
}
