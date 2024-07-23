﻿namespace BlazorApp1.Models
{
    public class Server
    {

        public int ServerId { get; set; }
        public bool IsOnline { get; set; }
        public  string? Name { get; set; }
        public string? City { get; set; }

        public Server()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            IsOnline = randomNumber == 0 ? false : true;
        }
    }
}
