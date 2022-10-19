using System.Collections.Generic;

namespace Library
{
    public class TwitterChannel: MessageChannel
    {
        public override string SendMessage(List<Contact> contacts, string text)
        {
            return $"El mensaje ha sido enviado con éxito, el mensaje enviado es: {text}";
        }
    }
}