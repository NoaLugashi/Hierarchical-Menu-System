using System;

namespace Ex04.Menus.Events
{
    public class Method<T> : MenuItem<T>
    {
        private Action<T> m_MethodItemSelected = null;
        private Action m_MethodWithoutParam = null;

        public Method(string i_ItemTitle, Action i_Method) : base(i_ItemTitle)
        {
            m_MethodWithoutParam = i_Method;
        }

        public Method(string i_ItemTitle, Action<T> i_Method) : base(i_ItemTitle) // לפונקציות שמקבלות פרמטרים
        {
            m_MethodItemSelected = i_Method;
        }

        public void AddMethodWithoutParam(Action i_Method) //אם יש צורך להוסיף פעולה לפעולה קיימת
        {
            if (m_MethodWithoutParam != null)
            {
                m_MethodWithoutParam += i_Method;
            }
        }

        public void AddMethodWithParam(Action<T> i_Method)//אם יש צורך להוסיף פעולה לפעולה קיימת שמקבלת פרמטרים
        {
            if (m_MethodItemSelected != null)
            {
                m_MethodItemSelected += i_Method;
            }
        }

        public Method(string i_ItemName) : base(i_ItemName)
        {
        }

        public void ActivateMethod(T i_data = default)
        {
            if (m_MethodItemSelected != null)
            {
                m_MethodItemSelected.Invoke(i_data);
            }
            else if (m_MethodWithoutParam != null)
            {
                m_MethodWithoutParam.Invoke();
            }
        }
    }
}