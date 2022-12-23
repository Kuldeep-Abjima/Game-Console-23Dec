using System;
using System.Net.Http.Headers;

namespace ConsoleGame
{
    class program
    {
        static void Main(string[] args) {
            PlayerCharacter sarah = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "Sarah"
            };
            PlayerCharacter amrit = new PlayerCharacter(new IronBonesDefence())
            {
                Name = "Amrit"
            };
            PlayerCharacter gentry = new PlayerCharacter(new NullDefence())
            {
                Name = "Gentry"
            };
            sarah.Hit(10);
            amrit.Hit(10);
            gentry.Hit(10);

            Console.ReadLine();

          //var player = new PlayerCharacter();
          //PlayerCharacter player = new();

          //  //player.Name = "Kinght";
          //  player.DaysSinceLastLogin = 44;
          //  int days = player?.DaysSinceLastLogin ?? -1;
            
          //  //int days = player.DaysSinceLastLogin ?? -1;
          //  //PlayerDisplayer.Write(player);
          //  Console.WriteLine(days);
          //  PlayerCharacter[] players = new PlayerCharacter[3]
          //  {
          //      new PlayerCharacter{Name = "sarah"},
          //      new PlayerCharacter(),
          //      null
          //  };
          //  string p1 = players?[0]?.Name;
          //  string p2 = players?[1]?.Name;
          //  string p3 = players?[2]?.Name;
          // Console.ReadLine();
        }
    }
}