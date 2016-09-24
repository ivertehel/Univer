﻿using System.Threading.Tasks;

namespace COM.Chat.Client.Services.Abstract
{
    public interface IUserService
    {
        Task RegisterUser(string login, string password);
    }
}
