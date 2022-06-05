namespace JustLearnForSelf
{
    using System.IO;
    public class Bank
    {
        // Function For give us 
        public string MellatPassword(string val)
        {
            IO io = new IO();
            List<UserAccount> accounts = new List<UserAccount>();
            accounts.Add(new UserAccount("Mehrhsad", "6104123409876789", "1234" , "300", "0312591020"));
            accounts.Add(new UserAccount("Aria", "6104566509875432", "1234", "550" , "0312591234"));
            accounts.Add(new UserAccount("Mehrhsad", "6104209509876316", "1234", "900" , "1232591234"));

            var passVal = "1";
            foreach( var account in accounts)
            {
                if( account.NumberCard == val)
                {
                    passVal = account.Password;
                }
            }
            if (passVal != null)
            {
                string PassStr = Convert.ToString(passVal);
                return PassStr;
            }
            else
            {
                io.Print("Card is Invalid ");
                return "!";
            }
        }

        public List<UserAccount> MelatData()
        {

            string M1 = "333";
            M1 = File.ReadAllText("../../../txtData/MoneyData/Mehrshad.txt");

            string M2 = "300";
            M2 = File.ReadAllText("../../../txtData/MoneyData/Aria.txt");

            string M3 = "300";
            M3 = File.ReadAllText("../../../txtData/MoneyData/Bahar.txt");


            IO io = new IO();
            List<UserAccount> accounts = new List<UserAccount>();
            accounts.Add(new UserAccount("Mehrshad", "6104123409876789", "1234", $"{M1}", "0312591020"));
            accounts.Add(new UserAccount("Aria", "6104566509875432", "1234", $"{M2}" , "0312591234"));
            accounts.Add(new UserAccount("Bahar", "6104209509876316", "1234", $"{M3}" , "1232591234"));

            return accounts;
        }

        public List<Mobile> MobileData()
        {
            string G1 = File.ReadAllText("../../../txtData/MobileData/Mehrshad.txt");
            string G2 = File.ReadAllText("../../../txtData/MobileData/Aria.txt");
            string G3 = File.ReadAllText("../../../txtData/MobileData/Bahar.txt"); 

            IO io = new IO();
            List<Mobile> mobile = new List<Mobile>();
            mobile.Add(new Mobile("0312591020", "09199310567" , $"{G1}" , "Mehrshad"));
            mobile.Add(new Mobile("0312591234", "09109647479" , $"{G2}" , "Aria"));
            mobile.Add(new Mobile("1232591234", "09227098222" , $"{G3}" , "Bahar"));

            return mobile;
        }
    }
}