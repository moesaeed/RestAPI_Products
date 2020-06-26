using RestAPI_Core.Contracts;
using RestAPI_Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI_Core.Business
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model, string ipAddress);

        AuthenticateResponse RefreshToken(string token, string ipAddress);
        bool RevokeToken(string token, string ipAddress);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
