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

        public void GestureMenu()
        {
            Console.WriteLine("Pick one of the following options: \n 1- Rock,\n 2- Paper,\n 3- Scissors,\n 4- Lizard,\n 5- Spock");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine(userInput);
            Console.ReadLine();
        }
        public override void ChooseGesture()
        {
            
        }
    }

}
