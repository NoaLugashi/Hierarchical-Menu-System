namespace Ex04.Menus.Events
{
    public delegate void Action<T>(T i_data = default);

    public class MenuItem<T>
    {
        private string m_ItemTitle;
        public event Action<T> m_ExecutionCompleted;

        public string ItemTitle
        {
            get
            {
                return m_ItemTitle;
            }
            set
            {
                m_ItemTitle = value;
            }
        }

        public MenuItem(string i_ItemTitle)
        {
            m_ItemTitle = i_ItemTitle;
        }

        public void DoWhenExecutionCompleted(T i_data = default)
        {
            m_ExecutionCompleted?.Invoke(i_data = default);
        }
    }
}