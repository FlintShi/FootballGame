using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class AttackStrategy : ITeamStrategy
    {
        //Overrides the Play function. 
        //Let us play some attacking game

        public  void Play()
        {    //Algorithm to attack
            System.Console.WriteLine(" Playing in attacking mode");
        }
    }
}
