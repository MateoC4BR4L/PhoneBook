using System.Collections.Generic;
using System;

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

        public void addContact(string nombre, string tel, string email){ // Creamos y agregamos el contacto nuevo
            Contact newContact = new Contact(nombre, tel, email);
            persons.Add(newContact);
        }
        public void AddTwitterID(string id, string contacto) // Agregar Id de Twitter en caso de que el contacto posea una cuenta
        {
            foreach(Contact i in persons)
            {
                if(i.Name == contacto)
                {
                    if(i.TwitterAcount == false) // Si el usuario no tiene una cuenta de Twitter asociada
                    {
                        i.TwitterID = id ; // Se agrega un ID de Twitter al contacto
                        i.TwitterAcount = true; // Confirmamos que posee cuenta de Twitter el contacto                                            
                        Console.WriteLine("ID de Twitter agregado exitosamente!");
                    }
                    else // Si ya posee una cuenta de Twitter asociada
                    {
                        Console.WriteLine("Ya hay asignado un ID de Twitter para este contacto.");
                    }
                }
            }
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