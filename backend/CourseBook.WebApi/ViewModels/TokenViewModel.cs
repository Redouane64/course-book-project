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

        public TokenViewModel(string token, string refreshToken, string id)
        {
            Token = token;
            RefreshToken = refreshToken;
            Id = id;
        }

        public string Id { get; }

        public string Token { get; }

        public string RefreshToken { get; }

    }
}
