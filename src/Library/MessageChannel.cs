using System.Collections.Generic;
namespace Library
{
    public abstract class MessageChannel
    {
         public abstract string SendMessage(List<Contact> contacts, string text);
    }
}