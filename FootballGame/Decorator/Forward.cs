using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    /// <summary>
    ///前锋
    /// </summary>
    public class Forward : PlayerRole
    {
        //'Added Behavior: This is a responsibility exclusively for the Forward
        public void ShootGoal()
        {
            System.Console.WriteLine(" Forward ({0}) - " + "Shooted the ball to goalpost", base.player.myName);
        }
    }
}
