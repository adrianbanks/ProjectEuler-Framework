using System;
using System.Diagnostics;

namespace ProjectEuler
{
    internal sealed class TimerBlock
    {
        private readonly Stopwatch stopwatch;

        public TimeSpan LastLap{get;private set;}
        public TimeSpan TotalTime{get;private set;}

        public TimerBlock()
        {
            stopwatch = new Stopwatch();
        }

        private void Start()
        {
            stopwatch.Reset();
            stopwatch.Start();
        }

        private void Stop()
        {
            stopwatch.Stop();
            LastLap = stopwatch.Elapsed;
            TotalTime += LastLap;
        }

        public LapTime Time()
        {
            return new LapTime(this);
        }

        internal class LapTime : IDisposable
        {
            private readonly TimerBlock timerBlock;

            public LapTime(TimerBlock timerBlock)
            {
                this.timerBlock = timerBlock;
                timerBlock.Start();
            }

            public void Dispose()
            {
                timerBlock.Stop();
            }
        }
    }
}
