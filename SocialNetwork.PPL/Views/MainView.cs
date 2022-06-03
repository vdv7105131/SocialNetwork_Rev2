using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class MainView
    {
        public void Show()
        {
            while (true)
            {
                Console.WriteLine("Войти в профиль (нажмите 1)");
                Console.WriteLine("Зарегистрироваться (нажмите 2)");
                Console.WriteLine("Выход (нажмите 0)");

                string keyValue = Console.ReadLine();
                if (keyValue == "0") break;

                switch (keyValue)
                {
                    case "1":
                        {
                            Program.authenticationView.Show();
                            break;
                        }

                    case "2":
                        {
                            Program.registrationView.Show();
                            break;
                        }
                    case "0":
                        {

                            break;
                        }
                }
            }
        }
    }
}