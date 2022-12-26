using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    internal class StopWatch
    {
        private DateTime StartTime { get; set; }
        private DateTime EndTime { get; set; }
        
        private bool _isRunning; // inintialized to false

        public void Start()
        {
            if (_isRunning == true) //the same as if (_isRunning) // if _isRunning = true tell the user the program is runnging
            // to not call the start method twice in the program 
            {
                throw new Exception("The stop Watch is running now.\n");
            }

            this.StartTime = DateTime.Now;
            _isRunning = true;



        }
        public void Stop()
        {
            if (_isRunning == false) // the same as if(!_isRunning) -- // if _iSrunning = false tell the user that the programs isn't even running
            {
                throw new Exception("The stop Watch isn't even running.\n");

            }
            EndTime = DateTime.Now;
            _isRunning = false;
        }

        public TimeSpan GetTime()
        {
            return EndTime - StartTime;  
        }
    }
}
