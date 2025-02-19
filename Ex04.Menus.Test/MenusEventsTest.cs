using System;
using Ex04.Menus.Events;

namespace Ex04.Menus.Test
{
    internal class MenusEventsTest
    {
        public void ShowEventsTest()
        {
            MainMenu<string> m_MainMenu = new MainMenu<string>("Delegates Main Menu");
            Menu<string> m_FirstMenu = new Menu<string>("Letters and Version");
            Menu<string> m_SecondMenu = new Menu<string>("Show Current Date/Time");
            Method<string> m_ShowVersionItem = new Method<string>("Show Version", new Action(ShowVersion.DisplayVersion));
            Method<string> m_CountCapitalsItem = new Method<string>("Count Lowercase Letters", new Action(CountLowercase.CountLowercaseLetters));
            Method<string> m_ShowCurrentTimeItem = new Method<string>("Show Current Time", new Action(ShowTime.DisplayCurrentTime));
            Method<string> m_ShowCurrentDateItem = new Method<string>("Show Current Date", new Action(ShowDate.DisplayCurrentDate));

            m_MainMenu.AddItemToMainMenu(m_FirstMenu);
            m_MainMenu.AddItemToMainMenu(m_SecondMenu);
            m_FirstMenu.AddItemToList(m_ShowVersionItem);
            m_FirstMenu.AddItemToList(m_CountCapitalsItem);
            m_SecondMenu.AddItemToList(m_ShowCurrentTimeItem);
            m_SecondMenu.AddItemToList(m_ShowCurrentDateItem);
            m_MainMenu.Show();
        }
    }
}