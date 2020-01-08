namespace JobPost.Models
{
    public class Contact 
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Contact(string name, string email, string phone)
        {
            FullName = name;
            Email = email;
            PhoneNumber = phone;
        }
    }
}