using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class ShowVersion : IMethodItemSelectedListener
    {
        void IMethodItemSelectedListener.MethodSelected()
        {
            DisplayVersion();
        }

        public static void DisplayVersion()
        {
            Console.WriteLine("App Version: 25.1.4.5480");
        }
    }
}