using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class PlayerRole : Player
    {

        // 'The reference to the player
        protected Player player;

        // 'Call the base component's function
        public override void PassBall()
        {
            player.PassBall();
        }

        //'This function is used to assign a player to this role 添加装饰
        public void AssignPlayer(Player p)
        {  // 'Keep a reference to the player, to whom this
            // 'role is given
            player = p;
        }
    }
}
