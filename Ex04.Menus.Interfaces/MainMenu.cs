namespace Ex04.Menus.Interfaces
{
    public class MainMenu : Menu
    {
        public MainMenu(string i_MenuTitle) : base(i_MenuTitle)
        {
            changeBackToExit();
        }

        private void changeBackToExit()
        {
            Items[0].ItemTitle = "Exit";
        }

        public void AddItemToMainMenu(MenuItem i_Item)
        {
            AddItemToList(i_Item);
        }

        public void Show()
        {
            OpenMenu();
        }
    }
}