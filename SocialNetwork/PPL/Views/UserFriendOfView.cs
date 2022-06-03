using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class UserFriendOfView
    {
        public void Show(IEnumerable<Friend> friends)
        {

            if (friends.Count() == 0)
            {
                Console.WriteLine("На вас никто не подписан :(");
                return;
            }

            Console.WriteLine("Вы в друзьях у:");
            friends.ToList().ForEach(friend =>
            {
                Console.WriteLine("{0} {1} ({2})", friend.FirstName, friend.LastName, friend.Email);
            });
        }
    }
}