using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class DefendStrategy : ITeamStrategy
    {
        //Overrides the Play function. 
        //Let us go defensive
        public  void Play()
        {    //Algorithm to defend
            System.Console.WriteLine(" Playing in defensive mode");
        }
    }
}
