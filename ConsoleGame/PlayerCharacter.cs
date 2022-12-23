using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class PlayerCharacter
    {
        private readonly SpecialDefence _specialDefence;
        public string Name { get; set; }
        public int Health { get; private set; } = 100;

        public PlayerCharacter(SpecialDefence specialDefence)
        {
            _specialDefence = specialDefence;
        }
        public void Hit(int damage)
        {
            
                int damageReduction = _specialDefence.CalculateDamageReduction();

                int totalDamageTaken = Math.Abs(damage - damageReduction);

                Health -= totalDamageTaken;

                Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken}");
            }
            //public int? DaysSinceLastLogin { get; set; }
            //public DateTime? DateOfBirth { get; set; }

            //public bool? IsNew { get; set; }

            //public PlayerCharacter()
            //{
            //    DateOfBirth = null;
            //    DaysSinceLastLogin = null;
            //    //DateOfBirth = DateTime.MinValue;
            //    //DaysSinceLastLogin = -1;
            //}

        }
    }
