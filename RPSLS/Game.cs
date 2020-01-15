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
        
        public List<string> gameRules = new List<string>();
        public List<string> listOfGestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        public int keepScore;
        public int win = 0;
        public int lose = 0;
        public int tie = 0;

        public bool newGame = true;

        Random random = new Random();



        // CONSTRUCTOR 
        public Game()
        {
                       
            gameRules.Add("*Rock crushes Scissors");
            gameRules.Add("*Scissors cuts Paper");
            gameRules.Add("*Paper covers Rock");
            gameRules.Add("*Rock crushes LIzard");
            gameRules.Add("*Lizard poisons Spock");
            gameRules.Add("*Spock smashes Scissors");
            gameRules.Add("*Scissors decapitates Lizard");
            gameRules.Add("*Lizard eats Paper");
            gameRules.Add("*Paper disproves Spock");
            gameRules.Add("*Spock vaporizes Rock");

            keepScore = 0;
            
            //listOfGestures.Add("Rock");
            //listOfGestures.Add("Paper");
            //listOfGestures.Add("Scissors");
            //listOfGestures.Add("Lizard");
            //listOfGestures.Add("Spock");


        }

        // MEMBER METHODS
        public void RunGame()  // master method
        {
            GreetUser();
           
            int numberOfPlayers = SetNumberOfPlayers();
            CreatePlayers(numberOfPlayers);
            
            while(p1.score < 2 || p2.score < 2)
            {
                p1.ChooseGesture();
                p2.ChooseGesture();
                CompareGestures();
            }

        }

        public void GreetUser()
        {
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine("Hello, would you like to play ROCK, PAPER, SCISSORS, LIZARD, SPOCK...[Y / N]");
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "y" || userInput == "yes")
                {
                    Console.WriteLine("Lets begin...");
                    Console.ReadLine();
                    isValid = true;
                    GameRules();
                }
                else if (userInput == "n" || userInput == "no")
                {
                    Console.WriteLine("Too bad, maybe next time.  Press ENTER to exit the game. ");
                    Console.ReadLine();
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("That is not a valid entry, please choose Y or N...");
                }
            }
            
             
            
        }
        public void GameRules()
        {
            Console.WriteLine("Here are the rules:");
            foreach(string rule in gameRules)
            {
                Console.WriteLine(rule);
            }
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();           
        }
        public int SetNumberOfPlayers()
        {
            int userInput;
            string response;
            do
            {
                Console.Clear();
                Console.WriteLine("Press [1] for Human vs. Computer,\n Press [2] for Human vs. Human");
                response = Console.ReadLine();
            } while (Int32.TryParse(response, out userInput) == false); 
            //if (!int.TryParse(userInput, out userInput))
            //{

            //}
            return userInput;
        }
        public void CreatePlayers(int numberOfPlayers)
        {
            bool isValid = false;
            while(isValid == false)
            {
                if (numberOfPlayers == 1)
                {
                    p1 = new Human("Player 1");
                    p2 = new Computer();
                    isValid = true;
                }
                else if (numberOfPlayers == 2)
                {
                    p1 = new Human("Player 1");
                    p2 = new Human("Player 2");
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("That is an invalid entry, enter a 1 or 2");
                    numberOfPlayers = SetNumberOfPlayers();
                }
            }
         
            
        }       

        public void CompareGestures()
        {

            if (p1.gesture == p2.gesture)
            {
                Console.WriteLine("You have tied, play again...");
            }
            else if (p1.gesture == "Rock" && p2.gesture == "Scissors" || p2.gesture == "Lizard")
            {
                Console.WriteLine("Player 1 wins!");
                p1.score++;
            }
            else if (p1.gesture == "Paper" && p2.gesture == "Rock" || p2.gesture == "Spock")
            {
                Console.WriteLine("Player 1 wins!");
                p1.score++;
            }
            else if (p1.gesture == "Scissors" && p2.gesture == "Paper" || p2.gesture == "Lizard")
            {
                Console.WriteLine("Player 1 wins!");
                p1.score++;
            }
            else if (p1.gesture == "Lizard" && p2.gesture == "Spock" || p2.gesture == "Paper")
            {
                Console.WriteLine("Player 1 wins!");
                p1.score++;
            }
            else if (p1.gesture == "Spock" && p2.gesture == "Scissors" || p2.gesture == "Rock")
            {
                Console.WriteLine("Player 1 wins!");
                p1.score++;
            }
            else
            {
                Console.WriteLine("Player 2 wins");

            }
        }
    }
}
