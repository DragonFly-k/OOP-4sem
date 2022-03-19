using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2
{
    internal class AccountB : IAccount, IOwner
    {
        private Account _product = new Account();
        public AccountB()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._product = new Account();
        }
        public void BuildBalance()
        {
            Random random = new Random();
            _product.Balance = random.Next(0, 1000000);
        }
        void IAccount.BuildOpendate()
        {
            _product.OpeningDate = DateTime.Now;
        }
        void IOwner.BuildBirthdate()
        {
            _product.owner.Birthdate = DateTime.Now;
        }
        public void BuildNum()
        {
            Random random = new Random();
            _product.num = random.Next(0, 10000);
        }
        public void BuildSMS()
        {
            Random random = new Random();
            _product.Sms = Convert.ToBoolean(random.Next(2));
        }
        public void BuildType()
        {
            Random random = new Random();
            if (random.Next(2) == 1)
            {
                this._product.Type = Account.Types.open;
            }
            else
            {
                this._product.Type = Account.Types.closed;
            }
        }
        public void BuildName()
        {
            Random random = new Random();
            var stringnames = "hdg fhjk usfj ajdhjf adj shfja ashj hfao nfj slfhjs akdshi akfja  sskj ktt jdkdk kdkd qiwew ahfsj aohr qwi";
            var names = stringnames.Split(' ');
            _product.owner.Name = names[random.Next(0, names.Length)];
        }
        public void BuildPassport()
        {
            _product.owner.Passport = "1111111A111РВ1";
        }

        public Account GetResult()
        {
            return _product;
        }
    }
}
