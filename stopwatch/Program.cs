using System;

namespace StopwatchApp
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private bool _isRunning;

        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch is already running.");

            _startTime = DateTime.Now;
            _isRunning = true;
        }

        public TimeSpan Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Stopwatch is not running.");

            var endTime = DateTime.Now;
            _isRunning = false;

            return endTime - _startTime;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            // First run
            stopwatch.Start();
            // Simulate some activity
            System.Threading.Thread.Sleep(2000); // Sleep for 2 seconds
            var duration1 = stopwatch.Stop();
            Console.WriteLine("Duration 1: " + duration1);

            // Second run
            stopwatch.Start();
            // Simulate some activity
            System.Threading.Thread.Sleep(1000); // Sleep for 1 second
            var duration2 = stopwatch.Stop();
            Console.WriteLine("Duration 2: " + duration2);
        }
    }
}
