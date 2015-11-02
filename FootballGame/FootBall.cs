using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class FootBall:ISubject
    {
        private ArrayList observers;

        private Position myPosition;
        public FootBall ()
        {
            myPosition = new Position();
            this.observers = new ArrayList();
        }


        public Position GetBallPosition(){
            return myPosition;
        }

        public void SetBallPosition(Position p)
        {
            myPosition = p;
            NotifyObservers();
        }

        /// <summary>
        /// Routine to attach an observer  
        /// </summary>
        /// <param name="Observer"></param>
        public void AttachObserver(IObserver Observer)
        {
            observers.Add(Observer);
        }
        /// <summary>
        /// Routine to remove an observer
        /// </summary>
        /// <param name="Observer"></param>
        public void DetachObserver(IObserver Observer)
        {
            observers.Remove(Observer);
        }

        /// <summary>
        /// Routine to notify all observers  
        /// </summary>
        public void NotifyObservers()
        {
            
            foreach (IObserver obs in this.observers)
            {
                 obs.Update();
            }
        }
    }
}
