using System;
using System.Threading;
using System.Timers;
namespace TestPac.Logic
{
    class TimeControll
    {
        private System.Timers.Timer Timer { get; set; }
        private int Seconds { get; set; }
        public bool LaikasBaigesi { get; set; }


        public void SetTime()
        {
            LaikasBaigesi = false;
            Seconds = 16;
            Timer = new System.Timers.Timer(1000);
            Timer.Elapsed += CountDown;
            Timer.Start();
        }

        private void CountDown(object sender, ElapsedEventArgs e)
        {
            Seconds--;
            Console.SetCursorPosition(22, 6);
            Console.Write(Seconds);
            
            if (Seconds == 0)
            {
                LaikasBaigesi = true;
                Timer.Close();
                Timer.Dispose();
            }
        }
    }
}
