using System.Collections.Generic;

namespace Library
{
    public class Phonebook
    {
        public List<Contact> persons{get;}

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
        }

        public Contact Owner { get; }

        public void addContact(string nombre, string tel, string email){
            Contact newContact = new Contact(nombre, tel, email);
            persons.Add(newContact);
        }

        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }

            return result;
        }
    }
}