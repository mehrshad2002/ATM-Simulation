namespace JustLearnForSelf
{
    public class ATM
    {
        public bool Start(List<UserAccount> user)
        {
            Bank bank =  new Bank();
            IO io = new IO();
            bool Flag = io.GetCommand( user );
            return Flag;
        }
    }
}