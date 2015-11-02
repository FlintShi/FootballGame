using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    /// <summary>
    /// 后卫
    /// </summary>
    public class Defender : PlayerRole
    {
        //'Added Behavior: This is a responsibility exclusively for the Forward
        public void Defend()
        {
            System.Console.WriteLine(" Defender ({0}) - defended the ball", base.player.myName);
        }
    }
}
