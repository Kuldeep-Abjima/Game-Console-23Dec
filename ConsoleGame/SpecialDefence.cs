using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public abstract class SpecialDefence
    {
      public abstract int CalculateDamageReduction();

        public static SpecialDefence Null { get; } = new NullDefence();
        class NullDefence : SpecialDefence
        {
            public override int CalculateDamageReduction()
            {
                return 0;//"no op" or "do Nothing" behavior
            }
        }
    }
}
