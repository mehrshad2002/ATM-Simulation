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
            accounts.Add(new UserAccount("Mehrhsad", "6104123409876789", "1234" , "300"));
            accounts.Add(new UserAccount("Aria", "6104566509875432", "1234", "550"));
            accounts.Add(new UserAccount("Mehrhsad", "6104209509876316", "1234", "900"));

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
            M1 = File.ReadAllText("Mehrshad.txt");

            string M2 = "300";
            M2 = File.ReadAllText("Aria.txt");

            string M3 = "300";
            M3 = File.ReadAllText("Bahar.txt");


            IO io = new IO();
            List<UserAccount> accounts = new List<UserAccount>();
            accounts.Add(new UserAccount("Mehrshad", "6104123409876789", "1234", $"{M1}"));
            accounts.Add(new UserAccount("Aria", "6104566509875432", "1234", $"{M2}"));
            accounts.Add(new UserAccount("Bahar", "6104209509876316", "1234", $"{M3}"));

            return accounts;
        }
    }
}