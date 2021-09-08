using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    public class User
    {
        public enum UserType
        {
            Simple,
            Gold,
            Platinum
        }
        public string Name { get; set; }
        public double Balance { get; set; }
        public UserType Type { get; set; }
        public User(string login, UserType type)
        {
            Name = login;
            Type = type;
            Balance = 10000;
        }

        public void ReduceBalance(double cost)
        {
            if (cost <= Balance) Balance -= cost;
        }
        public bool CheckUserSolvency(double productsTotalPrice) => Balance >= productsTotalPrice ? true : false;
    }
}
