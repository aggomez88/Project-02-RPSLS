using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer: Player
    {
        // MEMBER VARIABLES
        
        
        
        // CONSTRUCTOR
        public Computer()
        {
            name = "CPU";
        }

        // MEMBERS MEMBER
        public override void ChooseGesture()
        {
            //list of gestures from player class will be used for computer 
        }

    }
}
