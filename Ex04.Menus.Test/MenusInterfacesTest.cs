using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class MenusInterfacesTest
    {
        public void ShowInterfacesTest()
        {
            MainMenu m_MainMenu = new MainMenu("Main Menu");
            Menu m_FirstMenu = new Menu("Letters and Version");
            Menu m_SecondMenu = new Menu("Show Current Date/Time");
            Method m_ShowVersionItem = new Method("Show Version", new ShowVersion());
            Method m_CountCapitalsItem = new Method("Count Lowercase Letters", new CountLowercase());
            Method m_ShowCurrentTimeItem = new Method("Show Current Time", new ShowTime());
            Method m_ShowCurrentDateItem = new Method("Show Current Date", new ShowDate());
            m_ShowCurrentTimeItem.AddListener(new ShowTime());

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