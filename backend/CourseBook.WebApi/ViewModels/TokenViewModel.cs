namespace CourseBook.WebApi.ViewModels
{
    using System;

    public class TokenViewModel
    {
        public TokenViewModel(string token, string refreshToken)
        {
            Token = token;
            RefreshToken = refreshToken;
        }

        public string Token { get; }
        public string RefreshToken { get; }

    }
}
