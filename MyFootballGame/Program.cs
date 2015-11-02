using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballGame;

namespace MyFootballGame
{
    class Program
    {
        static void Main(string[] args)
        {

            //observers();

            //Strategy();

            Decorator();
            System.Console.Read()  ;
        }

        static void Decorator()
        {
            //'-- Step 1: 
            //'Create few players (concrete components)

            //'Create few field Players
            var owen = new FieldPlayer("Owen");
            var beck = new FieldPlayer("Beckham");

            //'Create a goal keeper
            var khan = new GoalKeeper("Khan");

            //'-- Step 2: 
            //'Just make them pass the ball 
            //'(during a warm up session ;))

            System.Console.WriteLine();
            System.Console.WriteLine(" > Warm up Session... ");

            owen.PassBall();
            beck.PassBall();
            khan.PassBall();

            //'-- Step 3: Create and assign the responsibilities
            //'(when the match starts)

            System.Console.WriteLine();
            System.Console.WriteLine(" > Match is starting.. ");

            //'Set owen as our first forward
            var forward1 = new Forward();
            forward1.AssignPlayer(owen);

            //'Set Beckham as our midfielder
            var midfielder1 = new MidFielder();
            midfielder1.AssignPlayer(beck);

            //'Now, use these players to do actions
            //'specific to their roles

            //'Owen can pass the ball
            forward1.PassBall();
            //'And owen can shoot as well
            forward1.ShootGoal();

            //'Beckham can pass ball
            midfielder1.PassBall();
            //'Beckham can dribble too
            midfielder1.Dribble();

            //' [ Arrange the above operations to some meaningfull sequence, like
            //' "Beckham dribbled and passed the ball to owen and owen shooted the
            //' goal ;) - just for some fun ]"

            //'-- Step 4: Now, changing responsibilities
            //'(during a substitution)

            //'Assume that owen got injured, and we need a new player
            //'to play as our forward1

            System.Console.WriteLine();
            System.Console.WriteLine(" > OOps, Owen " + "got injured. " + "Jerrard replaced Owen.. ");

            //'Create a new player
            var jerrard = new FieldPlayer("Jerrard");

            //'Ask Jerrard to play in position of owen
            forward1.AssignPlayer(jerrard);
            forward1.ShootGoal();

            //'-- Step 5: Adding multiple responsibilities
            //'(When a player need to handle multiple roles)

            //'We already have Beckham as our midfielder. 
            //'Let us ask him to play as an additional forward

            var onemoreForward = new Forward();
            onemoreForward.AssignPlayer(beck);

            System.Console.WriteLine();
            System.Console.WriteLine(" > Beckham has " + "multiple responsibilities.. ");

            //'Now Beckham can shoot
            onemoreForward.ShootGoal();
            //'And use his earlier responsibility to dribble too
            midfielder1.Dribble();

            //'According to our design, you can attach the responsibility of
            //'a forward to a goal keeper too, but when you actually 
            //'play football, remember that it is dangerous ;)

            //'Wait for key press


        }



        /// <summary>
        /// 【策略模式】
        /// 
        /// 球队与球队策略（Team and TeamStrategy）在比赛中，终端用户可以改变球队的策略（如从进攻改为防守）
        /// </summary>
        static void Strategy()
        {
            ////'Let us create a team and set its strategy,
            // //'and make the teams play the game

            ////'Create few strategies
            var attack = new AttackStrategy();
            var defend = new DefendStrategy();

            ////'Create our teams
            var france = new Team("France");
            var italy = new Team("Italy");

            System.Console.WriteLine("Setting the strategies..");

            ////'Now let us set the strategies
            france.SetStrategy(attack);
            italy.SetStrategy(defend);

            // //'Make the teams start the play
            france.PlayGame();
            italy.PlayGame();

            System.Console.WriteLine();
            System.Console.WriteLine("Changing the strategies..");

            // //'Let us change the strategies
            france.SetStrategy(defend);
            italy.SetStrategy(attack);

            // //'Make them play again
            france.PlayGame();
            italy.PlayGame();

            ////'Wait for a key press
            System.Console.Read();


        }


        /// <summary>
        /// 【观察者模式】
        /// 
        ///  足球（Ball）解决求和球员的问题及当球的位置变化，所有的球员和裁判应当能够立即感知。
        /// </summary>
        static void observers()
        {
            var ball = new FootBall();

            ////'Create few players (i.e, ConcreteObservers)  

            var Owen = new Player(ball, "Owen");
            var Ronaldo = new Player(ball, "Ronaldo");
            var Rivaldo = new Player(ball, "Rivaldo");

            ////'Create few referees (i.e, ConcreteObservers)  

            var Mike = new Referee(ball, "Mike");
            var John = new Referee(ball, "John");


            ////'Attach the observers with the ball  

            ball.AttachObserver(Owen);
            ball.AttachObserver(Ronaldo);
            ball.AttachObserver(Rivaldo);
            ball.AttachObserver(Mike);
            ball.AttachObserver(John);

            System.Console.WriteLine("After attaching the observers...");
            ////'Update the position of the ball.   

            ////'At this point, all the observers should be notified automatically  

            ball.SetBallPosition(new Position());

            ////'Just write a blank line  

            System.Console.WriteLine();


            ////'Remove some observers  

            ball.DetachObserver(Owen);
            ball.DetachObserver(John);


            System.Console.WriteLine("After detaching Owen and John...");

            ////'Updating the position of ball again  

            ////'At this point, all the observers should be notified automatically  

            ball.SetBallPosition(new Position(10, 10, 30));

            ////'Press any key to continue..  
        }

    }
}
