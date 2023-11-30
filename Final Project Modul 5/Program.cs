using System.Globalization;

namespace Final_Project_Modul_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
          ShowUserInfo(EnterUser());
            Console.ReadKey();
        }
        static void ShowUserInfo((string , string, int , string[] , string[])user)
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Your Info:");
            Console.WriteLine("Your Name is {0}", user.Item1);
            Console.WriteLine("Your Lastname is {0}", user.Item2);
            Console.WriteLine("Your Age is {0}",user.Item3);

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Your pets:");
            foreach (String name in user.Item4)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Your favorite color:");
            foreach (string favcolor in user.Item5)
            {
                Console.Write(favcolor + " ");
            }
            
            
        }
        static  (string name, string lastname, int age , string[] PetName , string[] FavColor) EnterUser()
        {
            (string name, string lastname, int age, string[] PetName, string[] FavColor) User = (null, null, 0, new string[0], new string[0]);
            Console.Write("Enter your name - ");
            User.name  = Console.ReadLine();
            Console.Write("Enter your lastname - ");
            User.lastname = Console.ReadLine();

            string age;
            int CheckAge;
            do
            {
                Console.Write("Enter your age - ");
                age = Console.ReadLine();
            }
            
            while (CheckNumber(age , out  CheckAge));
            User.age = CheckAge;

            Console.WriteLine("You have a pet ? \n Yes or No?");
            
            string HavePet = Console.ReadLine();

            if (HavePet == "Yes")
            {

                string NumPet;
                int CheckNumPet;
                int Pet;

                do
                {
                    Console.Write("Сколько у тебя питомцев - ");
                    NumPet = Console.ReadLine();
                }
                while ( CheckNumber(NumPet , out CheckNumPet));
                Pet = CheckNumPet;

                string[] NamesPet;
                NamePet(Pet, out NamesPet);
                User.PetName = NamesPet;
            }
            string color;
            int ColorNum;
            do
            {
                Console.Write("Enter number your favoite color - ");
                color = Console.ReadLine();
            }
            while (CheckNumber(color , out ColorNum));
           

            string[] FavoriteColore;
            FavoriteColor(ColorNum, out FavoriteColore);
            User.FavColor = FavoriteColore;

            
            return User;

        }
        static bool CheckNumber(string Num , out int ChekNum)
        {
           
            if (int.TryParse(Num , out int ChekedNum))
            {
                if ( ChekedNum > 0)
                {
                    ChekNum = ChekedNum;
                    return false;
                }     
            }
            {
                ChekNum = 0;
                return true;
            }
            
        }
        static string[] NamePet( int Number , out  string[] NamesPet)
        {
            NamesPet = new string[Number];
            for (int i = 0; i < Number; i++)
            {
                Console.Write("Name Pet Number {0} - " , i + 1);

                NamesPet[i] = Console.ReadLine();
            }
            return NamesPet;
        }
        static string[] FavoriteColor ( int colorNum ,  out string[] FavoriteColore)
        {
             FavoriteColore = new string[colorNum];
            for (int i = 0; i < colorNum ; i++)
            {
                Console.Write("Your favorite color number {0} - " , i+1);
                FavoriteColore[i] = Console.ReadLine();
                
            }
            return FavoriteColore;
        }
    }
}