namespace JustLearnForSelf
{
    public class ATM
    {
        public bool Start(List<UserAccount> user)
        {
            Bank bank =  new Bank();
            IO io = new IO();
            io.PrintAt("\n");
            bool Flag = io.GetCommand( user );
            return Flag;
        }
    }
}