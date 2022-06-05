//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace JustLearnForSelf
//{
//    public class CentralBank
//    {
//        List<Bank> banks = new List<Bank>();

//    }

//    internal class Bank
//    {
//        public string GetName = "mehrshad";
//        public string GetPassword = "1234";
//        public string GetCardNumber = "1234-1234-1234-1234";
//        public void AddUser()
//        {
//            List<User> users = new List<User>();
//            users.Add(new User($"{GetName}" , $"{GetCardNumber}" , $"{GetPassword}"));
//            foreach(var i in users)
//            {
//                Console.WriteLine(i.Name + " " + i.Password + " " + i.CardNumber);
//            }
//        }
//    }

//    public class User
//    {
//        public string Name;
//        public string CardNumber;
//        public string Password;

//        public User(string nameVall , string cardnumberVall , string passwordVall )
//        {
//            Name = nameVall;
//            CardNumber = cardnumberVall;
//            Password = passwordVall;
//        }
//    }
//}
using System;
namespace JustLearnForSelf
{
    public class CentralBank
    {
        public void MelatData()
        {
            List<UserAccount> userMelat = new List<UserAccount>();
        }
    }
}