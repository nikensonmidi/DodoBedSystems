﻿namespace OpsManagement.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsAuthenticated { get; set; }
    }
}