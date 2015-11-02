using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class Team
    {
        //Just a variable to keep the name of team
        private string teamName;


        //A reference to the strategy algorithm to use
        private ITeamStrategy strategy;

        //ContextInterface to set the strategy
        public void SetStrategy(ITeamStrategy s)
        { //Set the strategy
            strategy = s;
        }

        //Function to play
        public void PlayGame()
        {  //Print the team//s name
            System.Console.WriteLine(teamName);
            //Play according to the strategy
            strategy.Play();
        }

        //Constructor to create this class, by passing the team//s name
        public  Team(string teamName)
        {  //Set the team name to use later
            this.teamName = teamName;
        }

    }
}
