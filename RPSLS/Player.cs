﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player // inheritance (IS A TYPE OF)
    {
        // MEMBER VARIABLES (HAS A)
        public string name;
        public int score;
        public int gesture; 
        public List<string> gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };        
        

        // CONSTRUCTOR
        public Player()
        {
            
            score = 0;
                       
        }


        // MEMBER METHODS


        public abstract void ChooseGesture();




    }
}
