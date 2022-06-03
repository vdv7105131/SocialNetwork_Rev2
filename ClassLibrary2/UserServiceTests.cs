using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;
using System.Linq;
using Xunit;

namespace SocialNetwork.BLL.Tests
{
    public class UserServiceTests
    {
        

        [Fact]
        public void RegistrationThrowExceptionsTest()
        {
            var userService = new UserService();

            var testuser = new UserRegistrationData();
            //ошибка на пустое имя
            Assert.Throws<ArgumentNullException>(() => userService.Register(testuser));

            //ошибка на пустую фамилию
            testuser.FirstName = "Ivan";
            Assert.Throws<ArgumentNullException>(() => userService.Register(testuser));

            //ошибка на пустой email
            testuser.LastName = "Ivanov";
            Assert.Throws<ArgumentNullException>(() => userService.Register(testuser));

            //ошибка на неправильный email
            testuser.Email = "test.test";
            Assert.Throws<ArgumentNullException>(() => userService.Register(testuser));

            //ошибка на пароль
            testuser.Email = "test@test.ru";
            testuser.Password = "1234567";
            Assert.Throws<ArgumentNullException>(() => userService.Register(testuser));

        }

        [Fact]
        public void FindByEmailThrowExceptionsTest()
        {
            var userService = new UserService();
            Assert.Throws<UserNotFoundException>(() => userService.FindByEmail("thereisnosuchemail@no.no"));            
        }


    }
}