using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class ShowTime : IMethodItemSelectedListener
    {
        void IMethodItemSelectedListener.MethodSelected()
        {
            DisplayCurrentTime();
        }

        public static void DisplayCurrentTime()
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("> Current time is: {0:HH:mm:ss}", currentTime);
        }
    }
}