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
        List<string> listOfGestures = new List<string>();

        public int win = 0;
        public int lose = 0;
        public int tie = 0;

        public bool newGame = true;

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

            listOfGestures.Add("Rock");
            listOfGestures.Add("Paper");
            listOfGestures.Add("Scissors");
            listOfGestures.Add("Lizard");
            listOfGestures.Add("Spock");


        }

        // MEMBER METHODS
        public void RunGame()  // master method
        {
            GreetUser();
            GameRules();
            GestureMenu();           
        }

        public void GreetUser()
        {
            Console.WriteLine("Hello, would you like to play ROCK, PAPER, SCISSORS, LIZARD, SPOCK...[Y / N]");
            string answer = Console.ReadLine();

            if (answer == "Y")
            {
                Console.WriteLine("Lets begin...");

            }
            
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
            string gesture = (Console.ReadLine());
            Console.WriteLine(gesture);
            Console.ReadLine();

        }

        public void CompareGestures()
        {
            string playerChoice = "";
            bool validInput = false;

            while (!validInput)
            {
                
                            
            if (p1.gesture == p2.gesture)
            {
                Console.WriteLine("You have tied, play again...");
            }
            
            else if(playerChoice > )
            {

            }

            }
            //foreach (int gesture in )
        }
        


        //GameMode 
    }
}
