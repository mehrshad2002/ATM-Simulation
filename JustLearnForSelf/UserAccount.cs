//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace JustLearnForSelf
{
    public class UserAccount
    {
        public string Name { get; set; }
        public string NumberCard { get; set; }
        public string Password { get; set; }
        public string Money { get; set; }

        public UserAccount( string nameVal , string NumberCardVal , string PasswordVal , string MoneyVal)
        {
            Name = nameVal;
            NumberCard = NumberCardVal;
            Password = PasswordVal;
            Money = MoneyVal;
        }
    }
}