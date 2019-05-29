using System;

namespace A026_DigitalClockWF
{
    internal class DispatcherTimer
    {
        public TimeSpan Interval { get; internal set; }
        public int Tick { get; internal set; }

        internal void Start()
        {
            throw new NotImplementedException();
        }
    }
}