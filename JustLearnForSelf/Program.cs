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
            //string name;
            //Console.WriteLine("Enter Your name : ");
            //name = Console.ReadLine();
            
            
            //var class100 = new[]
            //{
            //    new Student($"{name}" , "Asadi" , "12345"),
            //    new Student("Aria" , "TaghiZadeh" , "10011"),
            //    new Student("Ronak" , "Asadi" , "23231"),
            //    new Student("Bahar" , "Asadi" , "23421"),
            //};

            //Console.WriteLine("All Students: ");
            //foreach( var student in class100)
            //{
            //    Console.WriteLine(student.Name);
            //}
            //IO io = new IO();
            //Card card = new Card();
            //string showCard = card.CardNumber();
            //Console.WriteLine(showCard);
            //Bank bank = new Bank();
            //bank.AddUser();
            //bool Flag = true;
            //while( Flag )
            //{
            //    io.Print("Welcome To command");
            //    Flag = io.GetCommand();
            //}

            IO io = new IO();
            Card card = new Card();
            var CardNumber = io.ReadCard();
            bool FlagSatrt = io.CallCheck();

            while ( FlagSatrt)
            {
                ATM atm = new ATM();
                FlagSatrt = atm.Start();
            }


        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        private string phoneNumber;

        public Student(string name , string Lastname ,string number)
        {
            phoneNumber = number;
            Name = name ;
            LastName = Lastname;
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if( value.Length > 5)
                {
                    PhoneNumber = value;
                }
            }
        }
    }
}
