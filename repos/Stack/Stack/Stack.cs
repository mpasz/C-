using System.Collections.Generic;

//dziedziczenie z głównego typu object
namespace Stack
{
    public class Stack
    {
        
        private Stack<object> st = new Stack<object>();

        public void Push(object obj)
        {
           
            if (obj != null)
                st.Push(obj);
            else
                throw new System.InvalidOperationException("You are trying to push null!");
            
        }

        public object Pop() 
        {
            if (st.Count != 0)
                return st.Pop();
            else
                throw new System.InvalidOperationException("The stack is emppty!");
        }

        public void Clear()
        {
            st.Clear();
        }


    }
}
