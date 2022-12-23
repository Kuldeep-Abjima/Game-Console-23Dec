using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    static  class PlayerDisplayer
    {
       
        public static void Write(PlayerCharacter player)
        {
            if (string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("player name is null, emplty, or all white space");
            }
            else
            {
                Console.WriteLine(player.Name);


            }
            //int days = player.DaysSinceLastLogin.GetValueOrDefault(-1);
            //int days = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1;
            //int days = player.DaysSinceLastLogin ?? -1;
            //Console.WriteLine($"{days} since last login");
            //if (player.DaysSinceLastLogin.HasValue)
            //{
            //    Console.WriteLine(player.DaysSinceLastLogin.Value);

            //}
            //else
            //{
            //    //Console.WriteLine(player.DaysSinceLastLogin.Value);

            //    Console.WriteLine("no value for DaySinceLastLogin");

            //}
            //if (player.DateOfBirth is null)
            //{
            //    Console.WriteLine("No date of birth specified");
            //}
            //else
            //{
            //    Console.WriteLine(player.DateOfBirth);
            //}

            //if(player.IsNew is null)
            //{
            //    Console.WriteLine("Player in noob");
            //}
            //else
            //{
            //    Console.WriteLine("Player is pro");
            //}

        }
    }
}
