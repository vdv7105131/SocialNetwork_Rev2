using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;
using System.Linq;
using Xunit;

namespace SocialNetwork.BLL.Tests
{
    public class MessageServiceTests
    {
        [Fact]
        public void SendMessageThrowExceptionsTest()
        {
            
            var messageService = new MessageService();
            MessageSendingData messageSendingData = new MessageSendingData();

            //проверка на не пустое сообщение
            Assert.Throws<ArgumentNullException>(() => messageService.SendMessage(messageSendingData));

            for (int i = 0; i < 5000; i++)
                messageSendingData.Content += "Ha";
            //проверка на величину сообщения
            Assert.Throws<ArgumentOutOfRangeException>(() => messageService.SendMessage(messageSendingData));
        }
    }
}
