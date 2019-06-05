using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class PictureShowerScheduled : IPictureShower
    {
        private static DateTime date = new DateTime(2019, 6, 6);
        private const int MIN_MINS = 5;
        private const int MAX_MINS = 30;

        public event EndEvent Ended;

        public void run()
        {
            Random random = new Random();
            var nextURL = PicturesResource.NextURL;
            while (!string.IsNullOrEmpty(nextURL) && isStillThisDay())
            {
                System.Diagnostics.Process.Start(nextURL);
                nextURL = PicturesResource.NextURL;
                var sleepMins = random.Next(MIN_MINS, MAX_MINS);
               Thread.Sleep(sleepMins * 60 * 1000);
            }
            Ended?.Invoke();
        }

        private bool isStillThisDay()
        {
            return DateTime.Today <= date;
        }
    }
}
