using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class MessageService : IMessageService
    {
        public User ConnectUser(string username)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public List<Message> GetNewMessages(User user)
        {
            throw new NotImplementedException();
        }

        public int IncomingMessage(Message message)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(User userToRemove)
        {
            throw new NotImplementedException();
        }

        public void SendNewMessage(Message newMessage)
        {
            throw new NotImplementedException();
        }
    }
}
