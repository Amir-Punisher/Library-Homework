using System;

namespace Library
{
    //inja ye faza baraye zakhire sazie information book tarif kardam
    public class Book
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Writer { get; set; }
        public int BookID { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Writer: " + Writer);
            Console.WriteLine("Book ID: " + BookID);
        }
    }

    //inja ham hamoon faza roo baraye member tarif kardam
    public class Member
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string PhoneNumber { get; set; }


        public void PrintMemberInfo()
        {
            Console.WriteLine("Member ID: " + MemberID);
            Console.WriteLine("Name: " + MemberName);
            Console.WriteLine("Phone Number: " + PhoneNumber);
        }
    }
    //inam bakhsh program barname hast
    class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book()
            {
                Name = "Dark Psychology",
                Year = 2020,
                Writer = "William Cooper",
                BookID = 1
            };
            book1.PrintInfo();

            Console.WriteLine();


            Member member1 = new Member()
            {
                MemberID = 69,
                MemberName = "Amir",
                PhoneNumber = "09339933505"
            };
            member1.PrintMemberInfo();
            Console.ReadKey();
        }
    }
    //chon nakhaste boodid ke karbar biad information ha ro vared kone man ham dastoor vorodi barash nazashtam va tamam information ha bayad dasti va az tarigh developer vared she.
} 