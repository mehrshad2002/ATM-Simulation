namespace JustLearnForSelf
{
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
            IO io = new IO();
            List<UserAccount> accounts = new List<UserAccount>();
            accounts.Add(new UserAccount("Mehrhsad", "6104123409876789", "1234", "300"));
            accounts.Add(new UserAccount("Aria", "6104566509875432", "1234", "550"));
            accounts.Add(new UserAccount("Mehrhsad", "6104209509876316", "1234", "900"));

            return accounts;
        }
    }
}