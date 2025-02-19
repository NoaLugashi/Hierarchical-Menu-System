using System;
using System.Collections.Generic;

namespace Ex04.Menus.Events
{
    public class Menu<T> : MenuItem<T>
    {
        private readonly List<MenuItem<T>> r_ListOfItems = new List<MenuItem<T>>();

        public Menu(string i_ItemTitle) : base(i_ItemTitle)
        {
            r_ListOfItems.Add(new Method<T>("Back"));
        }

        public List<MenuItem<T>> Items
        {
            get { return r_ListOfItems; }
        }

        public void AddItemToList(MenuItem<T> i_Item)
        {
            r_ListOfItems.Add(i_Item);
            i_Item.m_ExecutionCompleted += this.OpenMenu;
        }

        private void displayMenu()
        {
            Console.WriteLine("** {0} **", ItemTitle);
            Console.WriteLine("--------------------------");
            foreach (MenuItem<T> item in r_ListOfItems)
            {
                if (r_ListOfItems.IndexOf(item) != 0)
                {
                    Console.WriteLine("{0}. {1}", r_ListOfItems.IndexOf(item), item.ItemTitle);
                }
            }

            Console.WriteLine("0. {0}", r_ListOfItems[0].ItemTitle);
            Console.WriteLine("please enter your choice (1 - {0} or 0 to {1}):", r_ListOfItems.Count - 1, getExitOrGoBack());
            Console.Write(">> ");
        }

        private int getUserChoice()
        {
            string userInput;
            int userChoice = default;
            bool isValidinput = false;

            while (isValidinput == false)
            {
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out userChoice) == false)
                {
                    Console.WriteLine(@"Invalid Input (must be an integer)
Enter your request: (1 to {0} or press '0' to {1}).", r_ListOfItems.Count - 1, getExitOrGoBack());
                }
                else if (userChoice < 0 || userChoice >= r_ListOfItems.Count)
                {
                    Console.WriteLine(@"Invalid Input (value out of range)
Enter your request: (1 to {0} or press '0' to {1}).", r_ListOfItems.Count - 1, getExitOrGoBack());
                }
                else
                {
                    isValidinput = true;
                }
            }

            return userChoice;
        }

        private string getExitOrGoBack()
        {
            string stringToPrint;

            if (r_ListOfItems[0].ItemTitle == "Exit")
            {
                stringToPrint = "exit";
            }
            else
            {
                stringToPrint = "go back";
            }

            return stringToPrint;
        }

       public void OpenMenu(T i_data = default)
        {
            int indexSelected;

            displayMenu();
            indexSelected = getUserChoice();
            if (indexSelected == 0)
            {
                Console.Clear();
                DoWhenExecutionCompleted();
            }
            else
            {
                if (r_ListOfItems[indexSelected] is Menu<T> menu)
                {
                    Console.Clear();
                    menu.OpenMenu();
                }
                else if (r_ListOfItems[indexSelected] is Method<T> method)
                {
                    method.ActivateMethod();
                    Console.WriteLine();
                    method.DoWhenExecutionCompleted();
                }
            }
        }
    }
}