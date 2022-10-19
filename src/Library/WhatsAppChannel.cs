using System.Collections.Generic;
using WhatsAppApiUCU;
using System;

namespace Library
{
    public class WhatsAppChannel: MessageChannel
    {
        public override string SendMessage(List<Contact> contacts, string text)
        {
            var whatsApp = new WhatsAppApi();

            foreach(Contact i in contacts)
            {
                whatsApp.Send(i.Phone, text);   // Solo se acpeta formato de número uruguayo (ej: +598253898)
                Console.WriteLine($"Se ha enviado un mensaje a {i.Name} correctamente.");
            }
     
            if(contacts.Count > 1)
            return $"¡Los mensajes han sido enviado con éxito!";

            return "¡El mensaje ha sido enviado con éxito!";
        }
    }
}