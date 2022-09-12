using System;
using System.Diagnostics;
using System.Threading;
using System.Media;

namespace outro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer player = new SoundPlayer("outro.wav");
            player.Play();
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("Shutting down in " + i + " seconds!");
                Thread.Sleep(1000);
            }
            Process.Start("shutdown", "/s");
        }
    }
}
