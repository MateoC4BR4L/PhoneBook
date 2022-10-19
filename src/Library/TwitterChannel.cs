using System.Collections.Generic;
using TwitterUCU;
using System;

namespace Library
{
    public class TwitterChannel: MessageChannel
    {
        public override string SendMessage(List<Contact> contacts, string text)
        {
            var twitter = new TwitterMessage();
            foreach(Contact i in contacts)
            {
                if(i.TwitterAcount == true)
                {
                    twitter.SendMessage(text, i.TwitterID);
                    Console.WriteLine($"¡Se ha enviado un mensaje a través de Twitter a {i.Name} exitosamente!");
                }
                else
                {
                    Console.WriteLine($"El contacto {i.Name} no tiene asociado una cuenta de Twitter para enviarle el mensaje.");
                }
            }

            if(contacts.Count > 1)
            return $"¡Los mensajes han sido enviado con éxito!";

            return "¡El mensaje ha sido enviado con éxito!";
        }
    }
}