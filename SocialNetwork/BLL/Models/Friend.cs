using System.Collections.Generic;
using SocialNetwork.DAL.Entities;

namespace SocialNetwork.BLL.Models
{
    public class Friend
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }       
        public string Email { get; set; }
        public string Photo { get; set; }
        public string FavoriteMovie { get; set; }
        public string FavoriteBook { get; set; }

        public Friend(UserEntity user)         
           
        {
            this.Id = user.id;
            this.FirstName = user.firstname;
            this.LastName = user.lastname;
            this.Email = user.email;
            this.Photo = user.photo;
            this.FavoriteMovie = user.favorite_movie;
            this.FavoriteBook = user.favorite_book;            
        }
    }
}
