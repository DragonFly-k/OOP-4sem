using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using L2.AbstractFabrica;

namespace L2
{

    public class Account: AbstractFabrica.AbstractFactory, IClon
    {
        [Range(0, 10000)]
        public int num { get; set; }
        public enum Types { closed, open };
        public Types Type;

        [Range(0, 10000000)]
        public int Balance { get; set; }
        public DateTime OpeningDate;
        public bool Sms = false;
        public Owner owner;
        public Account(int num, Types type, int balance, DateTime openingDate, bool sms, Owner owner)
        {
            this.num = num;
            Type = type;
            Balance = balance;
            OpeningDate = openingDate;
            Sms = sms;
            this.owner = owner;
        }
        public Account()
        {
            num = 0;
            Type = Types.closed;
            Balance = 0;
            OpeningDate = DateTime.Now;
            owner = new Owner() { Name = null, Birthdate = DateTime.Now, Passport = null };
        }

        public class Owner:AbstractFabrica.Abstract
        {
            [StringLength(100)]
            public string Name { get; set; }
            public DateTime Birthdate;

            [PassportRB]
            public string Passport { get; set; }
        }
        public override string ToString()
        {
            return $"Номер: {num} Тип вклада:{Type} SMS: {Sms} \n ФИО:{owner.Name} Дата рождения:{owner.Birthdate}";
        }
        public override Abstract CreateOwner()
        {
              return new Owner();
        }
        public IClon Clone()
        {
            return new Account(num, Type, Balance, OpeningDate, Sms, owner);
        } 
    }

    public class PassportRB : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var reg = new Regex(@"\d{7}A\d{3}PB\d");
            return reg.IsMatch((value as string));
        }
    }
    public class Client : Abstract
    {
        [Range(0, 10000)]
        public int num { get; set; }
        public enum Types { closed, open };
        public Types Type;

        [Range(0, 10000000)]
        public int Balance { get; set; }
        public DateTime OpeningDate;
        public bool Sms = false;
        [StringLength(100)]
        public string Name { get; set; }
        public DateTime Birthdate;

        [PassportRB]
        public string Passport { get; set; }
    }
}
