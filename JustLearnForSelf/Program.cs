using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustLearnForSelf
{
    public class App
    {
        public static void Main()
        {
            IO io = new IO();
            Card card = new Card();
            var CardNumber = io.ReadCard();
            bool FlagSatrt = io.CallCheck();
            //
            Bank bank = new Bank();
            List<UserAccount> user = new List<UserAccount>();
            user = bank.MelatData();
            //
            while ( FlagSatrt)
            {
                ATM atm = new ATM();
                FlagSatrt = atm.Start( user);
            }
        }
    }
}
