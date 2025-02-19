using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class Method : MenuItem
    {
        private readonly List<IMethodItemSelectedListener> m_MethodItemSelectedListeners = new List<IMethodItemSelectedListener>();

        public Method(string i_ItemTitle, IMethodItemSelectedListener i_Method) : base(i_ItemTitle)
        {
            if (i_Method != null)
            {
                m_MethodItemSelectedListeners.Add(i_Method);
            }
        }

        public Method(string i_ItemName) : base(i_ItemName)
        {
        }

        public void AddListener(IMethodItemSelectedListener listener)
        {
            if (!m_MethodItemSelectedListeners.Contains(listener))
            {
                m_MethodItemSelectedListeners.Add(listener);
            }
        }

        public void NotifyMethodSelected()
        {
            foreach (IMethodItemSelectedListener listener in m_MethodItemSelectedListeners)
            {
                listener.MethodSelected();
            }
        }
    }
}