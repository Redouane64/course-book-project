using System;
using CourseBook.WebApi.Identity.Models;

namespace CourseBook.WebApi.Identity.ViewModels
{
    public class TokenViewModel
    {
        public TokenViewModel(string token, string refreshToken, string userId)
        {
            Token = token;
            RefreshToken = refreshToken;
            UserId = userId;
        }

        public string Token { get; }
        public string RefreshToken { get; }
        public string UserId { get; }
        public AccountType Role { get; set; }
        public Guid? Group { get; set; }
    }
}
