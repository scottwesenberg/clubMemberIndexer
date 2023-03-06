namespace ClubMembersExample
{
    class Program
    {
        class ClubMembers
        {
            public const int Size = 15;  
            private string[] Members = new string[Size];
            public string ClubType { get; set; }
            public string ClubLocation { get; set; }
            public string MeetingDate { get; set; }

            public ClubMembers()
            {
                for (int i = 0; i < Size; i++)
                {
                    Members[i] = string.Empty;
                }
                ClubType = string.Empty;
                ClubLocation = string.Empty;
                MeetingDate = string.Empty;
            }

            public string this[int index]
            {
                get
                {
                    string tmp;

                    if (index >= 0 && index <= Size - 1)
                    {
                        tmp = Members[index];
                    }
                    else
                    {
                        tmp = "";
                    }

                    return (tmp);
                }
                set
                {
                    if (index >= 0 && index <= Size - 1)
                    {
                        Members[index] = value;
                    }
                }

            }
        }
        static void Main(string[] args)
        {
            ClubMembers myClub = new ClubMembers();
            bool end = false;
            while (!end)
            {
                int sub = 0;
                while (sub < 1 || sub > ClubMembers.Size)
                {
                    Console.WriteLine($"Which club member do you want to enter (enter 1-{ClubMembers.Size})?");
                    while (!int.TryParse(Console.ReadLine(), out sub))
                        Console.WriteLine($"Enter a value between 1-{ClubMembers.Size}");
                }
                Console.WriteLine("Enter the name of the club member");
                myClub[sub - 1] = Console.ReadLine();
                Console.WriteLine("Press any key to continue, q to stop");
                string stop = Console.ReadLine();
                if (stop == "q")
                    end = true;
            }
            Console.WriteLine("What type of club is it??");
            myClub.ClubType = Console.ReadLine();
            Console.WriteLine("Where will the club meet?");
            myClub.ClubLocation = Console.ReadLine();
            Console.WriteLine("When will the club be meeting next?");
            myClub.MeetingDate = Console.ReadLine();

            Console.WriteLine($"Here the club information:");
            Console.WriteLine($"Club Members:");
            for (int i = 0; i < ClubMembers.Size; i++)
            {
                if (myClub[i] != string.Empty)
                    Console.WriteLine(myClub[i]);
            }
            Console.WriteLine($"Club Type: {myClub.ClubType}");
            Console.WriteLine($"Meeting Location: {myClub.ClubLocation}");
            Console.WriteLine($"Next Meeting Date: {myClub.MeetingDate}");
        }
    }


}