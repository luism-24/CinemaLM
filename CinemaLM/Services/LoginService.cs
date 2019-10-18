using CinemaLM.Helpers;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaLM.Services
{
    public static class LoginService
    {
        public static LoginResponse PostLogin(LoginBody loginBody)
        {
            return ApiHelper.Post<LoginResponse, LoginBody>("/api/Seguridad", loginBody);
        } 
    }
}
