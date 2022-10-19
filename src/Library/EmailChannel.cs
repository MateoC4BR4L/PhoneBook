using System.Collections.Generic;

namespace Library
{
    public class EmailChannel: MessageChannel
    {
        public override string SendMessage(List<Contact> contacts, string text)
        {
            return $"El email ha sido enviado con éxito, el mensaje enviado es: {text}";
        }
    }
}