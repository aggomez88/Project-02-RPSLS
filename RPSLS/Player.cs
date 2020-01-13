using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player : Game
    {
        // MEMBER VARIABLES
        public string name;
        public string gameType;
        public int score;
        public int gesture; 
        public List<string> gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };        
        

        // CONSTRUCTOR
        public Player(string name, int score, int gesture )
        {
            this.name = name;
            this.score = 0;
            this.gesture = 0;
                       
        }


        // MEMBER METHODS
        public void GestureMenu()
        {
            Console.WriteLine("Pick one of the following options: \n 1- Rock,\n 2- Paper,\n 3- Scissors,\n 4- Lizard,\n 5- Spock");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine(userInput);
            Console.ReadLine();

            //gestures.Add("Rock");
            //gestures.Add("Paper");
            //gestures.Add("Scissors");
            //gestures.Add("Lizard");
            //gestures.Add("Spock");
        }




    }
}
