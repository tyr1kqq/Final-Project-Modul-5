using System.Globalization;

namespace Final_Project_Modul_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
           Console.WriteLine ( EnterUser());
            Console.WriteLine (ShowUserInfo);
        }
        static string ShowUserInfo(in String  HavePet,in string[] NumPet ,in string[] favoriteColor)
        {
            (string name, string lastname, int age) User;
            EnterUser();
            Console.WriteLine("Pet - " +HavePet);
            foreach (String name in NumPet)
            {
                Console.WriteLine(name);
            }
            foreach (string favcolor in favoriteColor)
            {
                Console.WriteLine(favcolor);
            }
            return HavePet;
            
        }
        static  (string name, string lastname, int age) EnterUser()
        {
            (string name, string lastname, int age) User;
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
                    Console.WriteLine("Сколько у тебя питомцев - ");
                    NumPet = Console.ReadLine();
                }
                while ( CheckNumber(NumPet , out CheckNumPet));
                Pet = CheckNumPet;

                string[] NamesPet;
                NamePet(Pet, out NamesPet);
                foreach (var name in NamesPet)
                {
                    Console.WriteLine(name);
                }
            }
            string color;
            int ColorNum;
            do
            {
                Console.Write("Enter number your favoite color - ");
                color = Console.ReadLine();
            }
            while (CheckNumber(color , out ColorNum));
            Console.WriteLine("Nuber favorite color - {0}", ColorNum);
            Console.WriteLine();

            string[] FavoriteColore;
            FavoriteColor(ColorNum, out FavoriteColore);
            foreach (var item in FavoriteColore)
            {
                Console.WriteLine(item);
            }

            
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
                Console.WriteLine("Name Pet Number {0} - " , i + 1);

                NamesPet[i] = Console.ReadLine();
            }
            return NamesPet;
        }
        static string[] FavoriteColor ( int colorNum ,  out string[] FavoriteColore)
        {
             FavoriteColore = new string[colorNum];
            for (int i = 0; i < colorNum ; i++)
            {
                Console.WriteLine("Your favorite color numbe {0}" , i+1);
                FavoriteColore[i] = Console.ReadLine();
                
            }
            return FavoriteColore;
        }
    }
}