namespace Library
{
    public class Contact
    {
        public Contact(string name, string phone, string email)
        {
            this.Name = name;
            this.Phone = phone; // Formato de número Uruguayo (ej: +59898253898)
            this.Email = email;
        }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}