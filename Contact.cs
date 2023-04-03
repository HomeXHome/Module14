
namespace Module14.Modules
{
    public class Contact
    {
        public Contact(string name, string lastName, long phoneNumber, String email){
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public string Name { get; }
        public string LastName { get; }
        public long PhoneNumber { get; }
        public string Email { get; }
    }
}
