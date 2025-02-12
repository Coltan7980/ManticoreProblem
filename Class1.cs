using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//written by Coltan Paul

namespace HuntingTheManticore
{
    public class Player
    {  //class variables
        private int health = -1;
        private int decision = -1;

        //gets and sets
        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
        public int Decision
        {
            get { return this.decision; }
            set { this.decision = value; }
        }   
        //Constructors
        public Player(int aHealth, int aDecision)
        {
            aHealth = this.Health;
            aDecision = this.Decision;
        }
        public Player() : this(-1,-1)
        {
            this.Health = -1;
        }
    }


}
    
