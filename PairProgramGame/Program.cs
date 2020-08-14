using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Introduction/setting values
            Console.WriteLine("Adventurer, prey tell us your name?");
            Player player = new Player();
            player.PlayerName = Console.ReadLine();
            player.Health = 100;
            player.HasKey = false;
            Console.Clear();
            Console.WriteLine("Hello " + player.PlayerName + ".\nWelcome to the manner.  Press enter to continue...");

            Console.ReadLine();

            Console.WriteLine("The burned-out remnants of this once quaint manner sag beneath a growing tangle of weeds and vines,\nthe charred timbers and collapsed slate roof show signs of having once been intricately decorated\nin pastoral scenes of birds in flight. You can even make out a ruined library amidst the detritus.\n\nPress a key if you dare to enter...\nHopefully it won't be your last...");
            Console.ReadLine();

            Room startingRoom = new Room(player);
            startingRoom.Room7();


            Console.ReadLine();

            Console.WriteLine("Game Over");

            Console.ReadLine();
        }
    }
}
