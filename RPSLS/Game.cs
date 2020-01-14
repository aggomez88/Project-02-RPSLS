using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        // MEMBER VARIABLES
        
        public Player p1 = new Human("");
        public Player p2 = new Computer();
        
        List<string> gameRules = new List<string>();


        // CONSTRUCTOR 
        public Game()
        {
            
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

        //GameMode 
    }
}
