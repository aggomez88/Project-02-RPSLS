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
        public Human(/*string name*/)
        {
            //this.name = name;
        }

        // MEMBER METHODS

        
        public override void ChooseGesture()
        {
            Console.WriteLine("Player 1 chose:" + gestures.Count);
            Console.ReadLine();
        }
        
    }

}
