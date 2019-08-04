using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingRecovery.Interface
{
    class CombatSystem
    {
        private readonly IWeapon _weapon;

        public CombatSystem(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void CombatEngine()
        {
            _weapon.Slash(20, "Slash Done!");

            _weapon.Thrust(25, "Thrust Done!");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
