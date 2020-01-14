using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        // MEMBER VARIABLES (HAS A)
        public Player p1;
        public Player p2;
                
        List<string> gameRules = new List<string>();

        Random random = new Random();


        // CONSTRUCTOR 
        public Game()
        {
            p1 = new Human("Player 1");
            
            gameRules.Add("Rock crushes Scissors");
            gameRules.Add("Scissors cuts Paper");
            gameRules.Add("Paper covers Rock");
            gameRules.Add("Rock crushes LIzard");
            gameRules.Add("Lizard poisons Spock");
            gameRules.Add("Spock smashes Scissors");
            gameRules.Add("Scissors decapitates Lizard");
            gameRules.Add("Lizard eats Paper");
            gameRules.Add("Paper disproves Spock");
            gameRules.Add("Spock vaporizes Rock");

        }

        // MEMBER METHODS
        public void RunGame()  // master method
        {

            GameRules();


            



        }

        public void GreetUser()
        {
            Console.WriteLine("Hello, would you like to play ROCK, PAPER, SCISSORS, LIZARD, SPOCK...[Y / N]");
            string answer = Console.ReadLine();
            
        }
        public void GameRules()
        {
            Console.WriteLine("Here are the rules:");
            foreach(string rule in gameRules)
            {
                Console.WriteLine(rule);
            }
            Console.ReadLine();

            
        }
        public void GestureMenu()
        {
            Console.WriteLine("Pick one of the following gestures: \n 1- Rock,\n 2- Paper,\n 3- Scissors,\n 4- Lizard,\n 5- Spock");
            int gesture = int.Parse(Console.ReadLine());
            Console.WriteLine(gesture);
            Console.ReadLine();

        }

        public void CompareGestures()
        {

        }
        


        //GameMode 
    }
}
