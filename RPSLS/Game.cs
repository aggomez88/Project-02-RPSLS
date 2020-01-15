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
            p1 = new Human();
            
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
            GameRules();
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
            Console.WriteLine("Hello, would you like to play ROCK, PAPER, SCISSORS, LIZARD, SPOCK...[Y / N]");
            string userInput = Console.ReadLine();

            if (userInput == "Y")
            {
                Console.WriteLine("Lets begin...");
                Console.ReadLine();
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
            Console.WriteLine("Press [1] for Human vs. Human,\n Press [2] for Human vs. Computer");
            int userInput = int.Parse(Console.ReadLine());
            return userInput;
        }
        public void CreatePlayers(int numberOfPlayers)
        {
            if(numberOfPlayers == 1)
            {
                p1 = new Human();
                p2 = new Computer();
            }
            else if (numberOfPlayers == 2)
            {
                p1 = new Human();
                p2 = new Computer();
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
            
        }
    }
}
