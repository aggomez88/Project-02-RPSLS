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
        Random random = new Random();
        


        // CONSTRUCTOR
        public Computer()
        {
            
            this.name = "CPU";
        }

        // MEMBERS MEMBER
        public override void ChooseGesture()
        {
            int gestureIndex = random.Next(5);
            gesture = gestures[gestureIndex];

            Console.WriteLine("Computer chose:" + gesture );
            Console.ReadLine();

            //list of gestures from player class will be used for computer 
        }

    }
}
