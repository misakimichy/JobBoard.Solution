using System.Collections.Generic;

namespace JobPost.Models
{
    public class JobOpening
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Contact ContactList { get; set; }
        private static List<JobOpening> _instances = new List<JobOpening> {};
        
        public JobOpening(string title, string description, Contact contact)
        {
            Title = title;
            Description = description;
            ContactList = contact;
            _instances.Add(this);
        }

        public static List<JobOpening> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        // public void RemoveContactByIndex(int index)
        // {
        //     // Remove an element and the right side of the element shift to left.
        //     if (index >= 0 && index <= this.size)
        //     {
        //         for (int idx = index; idx < this.size -1; idx++)
        //         {
        //             list[idx] = list[idx + 1];
        //         }
        //     }
        // }
    }
}