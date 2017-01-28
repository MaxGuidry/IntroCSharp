using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public interface IDamagable
    {
        void TakeDamage(int i);
    }
    public interface IDamager
    {
        void DoDamage(IDamagable d);
    }
}
