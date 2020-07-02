﻿using System;
namespace Plugin.FirebaseAuth
{
    public class UserEventArgs : EventArgs
    {
        public IUser User { get; }

        public UserEventArgs(IUser user)
        {
            User = user;
        }
    }
}
