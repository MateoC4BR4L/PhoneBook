using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact jefe = new Contact("Mateo", "+59898253898", "mateocabralduarte123@gmail.com");

            Phonebook ContactList = new Phonebook(jefe);

            ContactList.addContact("Pepe", "+59898253898", "sapopepe@gmail.com");
            ContactList.addContact("Juan", "+59898253898", "juanito@gmail.com");
            ContactList.AddTwitterID("1582816119492120582", "Pepe"); // Agregamos un Id de twitter al contacto Pepe
            ContactList.AddTwitterID("1582816119492120582", "Juan"); // Agregamos un id de twitter al contacto Juan

            WhatsAppChannel wasapCanal = new WhatsAppChannel();
            Console.WriteLine(wasapCanal.SendMessage(ContactList.persons, "Buenos dias."));

            TwitterChannel twitterCanal = new TwitterChannel();
            Console.WriteLine(twitterCanal.SendMessage(ContactList.persons, "Buenos dias."));

        }
    }
}