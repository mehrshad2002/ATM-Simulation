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

                io.PrintAt($"Enter Your Password<attempt{i}> : "); 
                Password = io.Get();// get password from user 

                if ( Password == PassVal)
                {
                    Flag = true;
                    break;
                }else if ( i == 2 && Password != PassVal)
                {
                    io.Print("Your Password is wrong!\nPlese take your card !");
                    Flag = false;
                    break;
                }



                ++i;

            }
            return Flag;
        }
        //--------------------------------


    }
}