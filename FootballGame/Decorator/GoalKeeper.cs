using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    /// <summary>
    /// 门将
    /// </summary>
    public class GoalKeeper : Player
    {
        //'Operation: Overriding the base class operation
        public override void PassBall()
        {
            System.Console.WriteLine(" GoalKeeper " + "({0}) - passed the ball", base.myName);
        }

        // 'A constructor to accept the name of the player
        public GoalKeeper(string playerName)
        {
            base.myName = playerName;
        }
    }
}
