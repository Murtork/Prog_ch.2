using System;
using System.Timers;

namespace MemoryToolLibrary.Managers
{
    public class TimerManager
    {
        readonly Timer _timer;
        readonly Action _callback;

        public TimerManager(Action callback)
        {
            _callback = callback;
            _timer = new Timer
            {
                AutoReset = false,
            };
            _timer.Elapsed += OnTimerElapsed;
        }

        public void Start(int seconds)
        {
            _timer.Interval = seconds * 1000;
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

        void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            _callback();
        }        
    }
}
