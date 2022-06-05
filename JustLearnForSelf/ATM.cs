namespace JustLearnForSelf
{
    public class ATM
    {
        public bool Start()
        {
            Bank bank =  new Bank();
            IO io = new IO();
            bool Flag = io.GetCommand();
            return Flag;
        }
    }
}