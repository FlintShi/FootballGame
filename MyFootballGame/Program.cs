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
             
            var ball = new FootBall()  ;
  
            //'Create few players (i.e, ConcreteObservers)  
  
            var Owen = new Player(ball, "Owen") ; 
            var Ronaldo = new Player(ball, "Ronaldo")  ;
            var Rivaldo = new Player(ball, "Rivaldo") ; 
  
            //'Create few referees (i.e, ConcreteObservers)  
  
            var Mike = new Referee(ball, "Mike")  ;
            var John = new Referee(ball, "John")  ;
  
  
            //'Attach the observers with the ball  
  
            ball.AttachObserver(Owen)  ;
            ball.AttachObserver(Ronaldo)  ;
            ball.AttachObserver(Rivaldo)  ;
            ball.AttachObserver(Mike)  ;
            ball.AttachObserver(John)  ;
  
            System.Console.WriteLine("After attaching the observers..."); 
            //'Update the position of the ball.   
  
            //'At this point, all the observers should be notified automatically  
  
            ball.SetBallPosition(new Position())  ;
  
            //'Just write a blank line  
  
            System.Console.WriteLine()  ;
  
  
            //'Remove some observers  
  
            ball.DetachObserver(Owen)  ;
            ball.DetachObserver(John)  ;
  
  
            System.Console.WriteLine("After detaching Owen and John...")  ;
  
            //'Updating the position of ball again  
  
            //'At this point, all the observers should be notified automatically  
  
            ball.SetBallPosition(new Position(10, 10, 30)) ; 
  
            //'Press any key to continue..  
  
            System.Console.Read()  ;
        }
    }
}
