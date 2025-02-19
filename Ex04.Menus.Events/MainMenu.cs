namespace Ex04.Menus.Events
{
    public class MainMenu<T>
    {
        private readonly Menu<T> r_Menu;

        public MainMenu(string i_MenuTitle)
        {
            r_Menu = new Menu<T>(i_MenuTitle);
            r_Menu.Items[0].ItemTitle = "Exit";
        }

        public void AddItemToMainMenu(MenuItem<T> i_Item)
        {
            r_Menu.AddItemToList(i_Item);
        }

        public void Show()
        {
            r_Menu.OpenMenu();
        }
    }
}