using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    /// <summary>
    /// 中场球员
    /// </summary>
    public class MidFielder : PlayerRole
    {
        //'AddedBehavior: This is a responsibility exclusively for the Midfielder
    //'(Don't ask me whether only mid filders can dribble the ball - atleast
    //'it is so in our engine)
        public void Dribble()
        {
            System.Console.WriteLine(" MidFielder ({0}) - dribbled the ball", base.player.myName);
        }
    }
}
