using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class UserFriendsView
    {
        public void Show(IEnumerable<Friend> friends)
        {
            
            if (friends.Count() == 0)
            {
                Console.WriteLine("У вас нет друзей :(");
                return;
            }

            Console.WriteLine("Ваши друзья:");
            friends.ToList().ForEach(friend =>
            {
                Console.WriteLine("{0} {1} ({2})", friend.FirstName, friend.LastName, friend.Email);
            });
        }
    }
}