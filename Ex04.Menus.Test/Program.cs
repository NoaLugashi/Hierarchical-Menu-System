namespace Ex04.Menus.Test
{
    internal class Program
    {
        public static void Main()
        {
            MenusEventsTest eventsTest = new MenusEventsTest();
            MenusInterfacesTest interfacesTest = new MenusInterfacesTest();

            eventsTest.ShowEventsTest();
            interfacesTest.ShowInterfacesTest();
        }
    }
}