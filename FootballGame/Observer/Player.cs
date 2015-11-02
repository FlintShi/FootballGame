using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
   

    public  class Player:IObserver
    {
        private FootBall ball;
        public string myName{get;set;}
        public  void Update ()  
        {
            var ballPosition = ball.GetBallPosition();
            System.Console.WriteLine("Player {0} say that the ball is at {1},{2},{3} ", myName, ballPosition.X, ballPosition.Y, ballPosition.Z);
        }
        public Player(FootBall b, string playerName)
        {
            ball = b;
            myName = playerName;
        }
        public Player()
        {
          
        }

        //'This is the Operation in the component
        //'and this will be overrided by concrete components
        public virtual void PassBall()
        { 
        
        }
    }
}
