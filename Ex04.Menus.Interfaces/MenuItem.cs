namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem 
    {
        private string m_ItemTitle;
        private IExecutionCompletedListener m_ExecutionCompleted;

        public MenuItem(string i_ItemTitle)
        {
            m_ItemTitle = i_ItemTitle;
        }

        public IExecutionCompletedListener ExecutionCompletedHandler
        {
            get 
            {
                return m_ExecutionCompleted;
            }
            set 
            {
                m_ExecutionCompleted = value; 
            }
        }

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

        public void DoWhenExecutionCompleted()
        {
            if (m_ExecutionCompleted != null)
            {
                m_ExecutionCompleted.ExecutionCompleted();
            }
        }
    }
}