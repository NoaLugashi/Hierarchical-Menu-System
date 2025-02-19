using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class ShowDate : IMethodItemSelectedListener
    {
        void IMethodItemSelectedListener.MethodSelected()
        {
            DisplayCurrentDate();
        }

        public static void DisplayCurrentDate()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("> Current date is: {0}", today.ToString("dd/MM/yyyy"));
        }
    }
}