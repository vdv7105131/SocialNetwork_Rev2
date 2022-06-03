using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class FriendAddView
    {
        UserService userService;
        
        public FriendAddView (UserService userService)
        {
            
            this.userService = userService;
        }

        public void Show(User user)
        {
            var freindRegistrationData = new FriendRegistrationData();

            Console.Write("Введите почтовый адрес друга: ");
            freindRegistrationData.Friend_email = Console.ReadLine();

            freindRegistrationData.User_id = user.Id;

            try
            {
                userService.AddFreind(freindRegistrationData);
                
                SuccessMessage.Show("Друг добавлен!");

                user = userService.FindById(user.Id);
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь не найден!");
            }

            catch (DoubleRecordTryException)
            {
                AlertMessage.Show("Такой друг уже добавлен");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка при добавлении друга!");
            }

        }
    }
}