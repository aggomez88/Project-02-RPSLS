using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Program
    {
        static void Main(string[] args)
        {
            //game object 
            Game game = new Game();
            game.RunGame();
            game.GreetUser();
            

            Console.ReadLine();
        }
        
    }
}
