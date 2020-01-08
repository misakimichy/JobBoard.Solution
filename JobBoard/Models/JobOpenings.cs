namespace JobPost.Models
{
    public class JobOpening
    {
        private Contact[] list;
        private int size;
        public JobOpening()
        {
            list = new Contact[100];
            this.size = 0;
        }

        public void AddContact(Contact newContact)
        {
            list[size] = newContact;
            size++;
        }

        public void RemoveContactByIndex(int index)
        {
            // Remove an element and the right side of the element shift to left.
            if (index >= 0 && index <= this.size)
            {
                for (int idx = index; idx < this.size -1; idx++)
                {
                    list[idx] = list[idx + 1];
                }
                this.size--;
            }
        }

        public int GetSize()
        {
            return this.size;
        }

        public Contact GetContact(int index)
        {
            if(index >= 0 && index <= this.size)
            {
                return list[index];
            }
            return null;
        }
        
        public string ToString()
        {
            string output = "";
            for(int index = 0; index < this.size; index++)
            {
                output += list[index].ToString() + "\n";
            }
            return output;
        }
    }
}