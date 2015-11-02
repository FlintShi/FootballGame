using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{


    public class Referee : IObserver
    {
        private FootBall ball;
        private string myName;
        public void Update()
        {
            var ballPosition = ball.GetBallPosition();
            System.Console.WriteLine("Referee {0} say that the ball is at {1},{2},{3} ", myName, ballPosition.X, ballPosition.Y, ballPosition.Z);
        }
        public Referee(FootBall b, String playerName)
        {
            ball = b;
            myName = playerName;
        }
    }
}
