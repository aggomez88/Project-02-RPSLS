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
        public Human(string name)
        {
            this.name = name;
        }

        // MEMBER METHODS

        
        public override void ChooseGesture()
        {
        
            bool isValid = false;
            //validation here
            while (!isValid)
            {
                Console.WriteLine("Please Choose a Gesture: 1- Rock, 2- Paper, 3- Scissors, 4- Lizard, 5- Spock");
                string Choice = Console.ReadLine();
                switch (Choice)
                {
                    case "1":
                        gesture = gestures[0];
                        isValid = true;
                        break;
                    case "2":
                        gesture = gestures[1];
                        isValid = true;
                        break;
                    case "3":
                        gesture = gestures[2];
                        isValid = true;
                        break;
                    case "4":
                        gesture = gestures[3];
                        isValid = true;
                        break;
                    case "5":
                        gesture = gestures[4];
                        isValid = true;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid choice");
                        break;
                }

              
            }
            Console.WriteLine($"{name} chose: {gesture}");
            Console.ReadLine();

        }
        
    }

}
