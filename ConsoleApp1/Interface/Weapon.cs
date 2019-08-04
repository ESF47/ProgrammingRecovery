using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingRecovery.Interface
{
    public interface IWeapon
    {
        void Thrust(int damage, string attackMessage);

        void Slash(int damage, string attackMessage);
    }
}
