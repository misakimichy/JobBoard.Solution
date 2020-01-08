namespace JobPost.Models
{
    public class Contact 
    {
        private string fullName;
        private string email;
        private string phoneNumber;
        public Contact()
        {
            
        }
        public Contact(string name, string email, string phone)
        {
            this.fullName = name;
            this.email = email;
            this.phoneNumber = phone;

        }
        public string GetFullName()
        {
            return this.fullName;
        }

        public void SetFullName(string new_name)
        {
            this.fullName = new_name;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public void SetEmail(string new_email)
        {
            this.email = new_email;
        }

        public string GetPhoneNumber()
        {
            return this.phoneNumber;
        }

        public void SetPhoneNumber(string phone)
        {
            this.phoneNumber = phone;
        }

        public string ToString()
        {
            string output ="Full Name: "+this.fullName+", Email: "+this.email+
            ", Phone number: "+ this.phoneNumber;
            return output;
        }
         
    }
}