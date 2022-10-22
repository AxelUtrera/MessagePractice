using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Text;

namespace Service
{
    [ServiceContract]
    public interface IMessageService{

      
        [OperationContract]
        int IncomingMessage(Message message);

        [OperationContract]
        User ConnectUser(string username);

        [OperationContract]
        List<Message> GetNewMessages(User user);

        [OperationContract]
        void SendNewMessage(Message newMessage);

        [OperationContract]
        List<User> GetAllUser();

        [OperationContract]
        void RemoveUser(User userToRemove);
    }

    

   
}
