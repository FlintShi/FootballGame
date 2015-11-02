using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
     public interface ISubject
    {
        /// <summary>
        /// Routine to attach an observer  
        /// </summary>
        /// <param name="Observer"></param>
        void AttachObserver(IObserver Observer);
        /// <summary>
        /// Routine to remove an observer
        /// </summary>
        /// <param name="Observer"></param>
        void DetachObserver(IObserver Observer);

        /// <summary>
        /// Routine to notify all observers  
        /// </summary>
        void NotifyObservers();

    }
}
