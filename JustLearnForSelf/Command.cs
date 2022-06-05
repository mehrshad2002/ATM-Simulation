using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JustLearnForSelf
{
    public class Command
    {
        public void Account(string cardNumber, List<UserAccount> user)
        {

            IO io = new IO();
            Bank bank = new Bank();
            string Card4digit = cardNumber.Substring(0, 4);

            string Money;
            switch (Card4digit)
            {
                case "6104":
                    //
                    user = bank.MelatData();

                    foreach (UserAccount userAccount in user)//
                    {
                        if (userAccount.NumberCard == cardNumber)
                        {
                            Money = userAccount.Money;
                            io.Print($"\n-------\nYour Accounts --> {Money}\n-------\n");
                        }
                    }
                    break;

                case "6393":
                    break;

                case "5892":
                    break;

                default:
                    break;

            }

        }

        public void GetMoney(string cardNumber, List<UserAccount> user)
        {
            IO io = new IO();
            Bank bank = new Bank();
            string Card4digit = cardNumber.Substring(0, 4);
            switch (Card4digit)
            {
                case "6104":
                    user = bank.MelatData();
                    int MoneyWant;
                    io.PrintAt("\n------\nEnter How many Hezaar Toman You Need : ");
                    MoneyWant = Convert.ToInt32(io.Get());
                    io.Print("------\n");
                    foreach (UserAccount userAccount in user)
                    {
                        if (userAccount.NumberCard == cardNumber)
                        {
                            int MoneyInt = Convert.ToInt32(userAccount.Money);// money in user account 
                            if (MoneyInt < MoneyWant)
                            {
                                io.Print("Sorry Your Money Is not Enogh!");
                            }
                            else
                            {
                                io.Print("-----\nWait...!");
                                io.Print("Plese Take Your Money\n-----");
                                string NewMoney = Convert.ToString(MoneyInt - MoneyWant);

                                string NameUser;
                                foreach (UserAccount users in user)
                                {
                                    if (userAccount.NumberCard == cardNumber)
                                    {
                                        NameUser = users.Name;
                                        File.WriteAllText($"{NameUser}.txt", NewMoney);
                                    }
                                }
                            }
                        }
                    }
                    break;

                case "6393":
                    break;

                case "5892":
                    break;

                default:
                    break;

            }

        }
        public void GetCharge(string cardNumber, List<UserAccount> user)
        {
            IO io = new IO();
            Bank bank = new Bank();
            string Card4digit = cardNumber.Substring(0, 4);
            switch (Card4digit)
            {
                case "6104":
                    user = bank.MelatData();
                    int MoneyWant;
                    int GigWant;
                    int Sum;
                    io.PrintAt("-----\nHow Many GB Do you want ??");
                    GigWant = Convert.ToInt32(io.Get());
                    io.Print("-----\n");
                    Sum = GigWant * 4;

                    foreach (UserAccount userAccount in user)
                    {
                        if (userAccount.NumberCard == cardNumber)
                        {
                            int MoneyInt = Convert.ToInt32(userAccount.Money);// money in user account 
                            if (MoneyInt < Sum)
                            {
                                io.Print("-----\nSorry Your Money Is not Enogh!\n-----");
                            }
                            else
                            {
                                io.Print("----\nWait...!");
                                io.Print("Charge Is succsesful!\n----");
                                // WITH FILE AND FOLDER WE CAN HAVE IS DATA GB 
                                string NewMoney = Convert.ToString(MoneyInt - Sum);

                                string NameUser;
                                foreach (UserAccount users in user)
                                {
                                    if (userAccount.NumberCard == cardNumber)
                                    {
                                        NameUser = users.Name;
                                        int SumGig = Convert.ToInt32(File.ReadAllText($"./MobileData/{NameUser}.txt"));
                                        SumGig += GigWant;
                                        File.WriteAllText($"./MobileData/{NameUser}.txt", Convert.ToString(SumGig));
                                        File.WriteAllText($"{NameUser}.txt", NewMoney);
                                    }
                                }
                            }
                        }
                    }
                    break;

                case "6393":
                    break;

                case "5892":
                    break;

                default:
                    break;

            }

        }

        public void SendCharge(string cardNumber, List<UserAccount> user)
        {
            IO io = new IO();
            Bank bank = new Bank();
            string Card4digit = cardNumber.Substring(0, 4);
            switch (Card4digit)
            {
                case "6104":
                    user = bank.MelatData();
                    int MoneyWant;
                    int GigWant;
                    int Sum;
                    string secendNumber;
                    string NameUser, NameSecendUser;
                    
                        io.Print("Enter Secend Number : ");
                        secendNumber = io.Get();// get secend number 
                        List<Mobile> mobile = bank.MobileData();


                        foreach (Mobile userPhone in mobile)
                        {
                            if (secendNumber == userPhone.PhoneNumber)
                            {
                                io.PrintAt("How many GB you want? : ");
                                GigWant = Convert.ToInt32(io.Get());
                                Sum = GigWant * 4;
                                NameSecendUser = userPhone.Name;
                                foreach (UserAccount userAccount in user)
                                {
                                    if (userAccount.NumberCard == cardNumber)
                                    {
                                        NameUser = userAccount.Name;
                                        int MoneyInt = Convert.ToInt32(userAccount.Money);// money in user account 
                                        
                                        if (MoneyInt < Sum)
                                        {
                                            io.Print("Sorry Your Money Is not Enogh!");
                                            
                                        }
                                        else
                                        {
                                            io.Print("\n----Wait...!");
                                            io.Print("Charge Is succsesful!\n----");
                                            string NewMoney = Convert.ToString(MoneyInt - Sum);

                                            int SumGig = Convert.ToInt32(File.ReadAllText($"./MobileData/{NameSecendUser}.txt"));
                                            SumGig += GigWant;
                                            File.WriteAllText($"{NameUser}.txt", NewMoney);
                                            File.WriteAllText($"./MobileData/{NameSecendUser}.txt", Convert.ToString(SumGig));
                                            
                                        }

                                    }
                                }
                                
                        }

                    }

                    break;

                    

            }
        }
    }
}
