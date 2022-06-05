namespace JustLearnForSelf
{
    public class Check
    {
        public bool CheckMellat( string val)
        {
            IO io = new IO();
            string Password;
            Bank bank = new Bank();
            string PassVal = bank.MellatPassword(val); //get Orginal Password from our data
            int i = 1; // 3 attempt for user enter correct password 
            bool Flag = true;
            while ( i < 3)
            {
                if( i == 1 )
                {
                    io.Print("Welcome to the Mellat Bank.");

                }

                io.PrintAt("Enter Your Password : "); 
                Password = io.Get();// get password from user 

                if ( Password == PassVal)
                {
                    Flag = true;
                    break;
                }
                else
                {
                    io.PrintAt($"\nYour Password Was incorect<attempt {i}");
                    if( i == 3)
                    {
                        io.Print("PLESE TAKE YOUR CARD !");
                    }
                    io.GetAt();
                    Flag = false;
                }

                ++i;

            }
            return Flag;
        }
        //--------------------------------


    }
}