﻿using project2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.Class
{
    public static class Global
    {
        public static List<Person> Peaple = new List<Person>();
        public static List<BankAccount> Accounts = new List<BankAccount>();
        public static List<Home> Homes = new List<Home>();
        public static List<Car> cars = new List<Car>();
        public static List<SimPhone> SimPhones = new List<SimPhone>();
        public static List<OwnerShip> OwnerShips = new List<OwnerShip>();
        public static List<RelationShip> RelationShips = new List<RelationShip>();
        public static List<Call> Calls = new List<Call>();
        public static List<Transaction> Transactions = new List<Transaction>();
    }
}
