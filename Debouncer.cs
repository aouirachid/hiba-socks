using System;

namespace FD_STOCK
{
    public class Debouncer
    {
        private System.Windows.Forms.Timer timer;
        private Action lastAction;

        public Debouncer(int intervalMilliseconds)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = intervalMilliseconds;
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                lastAction?.Invoke();
            };
        }

        public void Debounce(Action action)
        {
            timer.Stop(); // Reset the timer
            lastAction = action;
            timer.Start();
        }
    }
}