using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human: Player
    {
        // MEMBER VARIABLES
        

        // CONSTRUCTOR
        public Human()
        {
            this.name = "Player 1";
        }

        // MEMBER METHODS

        
        public override void ChooseGesture()
        {
            Console.WriteLine("Please Choose a Gesture: 1- Rock, 2- Paper, 3- Scissors, 4- Lizard, 5- Spock");
            string Choice = Console.ReadLine();

            switch (Choice)
            {
                case "1":
                    gesture = gestures[0];
                    break;
                case "2":
                    gesture = gestures[1];
                    break;
                case "3":
                    gesture = gestures[2];
                    break;
                case "4":
                    gesture = gestures[3];
                    break;
                case "5":
                    gesture = gestures[4];
                    break;

                default:
                    Console.WriteLine("Please enter a valid choice");
                    break;
            }

            Console.WriteLine($"{name} chose: {gesture}");
            Console.ReadLine();
        }
        
    }

}
