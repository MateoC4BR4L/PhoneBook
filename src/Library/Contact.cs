using System;
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

        public string TwitterID { get; set; } // ID del usuario de twitter (opcional)
        public bool TwitterAcount { get; set; } // Para verificar que tiene cuenta de Twitter
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

    }
}