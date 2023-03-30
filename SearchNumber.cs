namespace Rehber.Rehber
{
    class SearchNumber
    {
        public static void Search(List<Users> userlist)
        {
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            Console.WriteLine("Arama yapmak istediğiniz tipi seçin.");
            int cevap = int.Parse(Console.ReadLine());

            if (cevap == 1)
            {
                Console.WriteLine("Arama yapmak istediğiniz ismi ve soyismi girin: ");
                string searchname = Console.ReadLine();
                foreach (Users user in userlist)
                {
                    if (user.Isim.ToLower() == searchname || user.Isim.ToUpper() == searchname)
                    {
                        Console.WriteLine("İsim: "+ user.Isim);
                        Console.WriteLine("Soyisim: "+ user.Soyisim);
                        Console.WriteLine("Telefon numarası: "+ user.Number);
                        break;
                    }
                    else if (user.Soyisim.ToLower() == searchname || user.Soyisim.ToUpper() == searchname)
                    {
                        Console.WriteLine("İsim: "+ user.Isim);
                        Console.WriteLine("Soyisim: "+ user.Soyisim);
                        Console.WriteLine("Telefon numarası: "+ user.Number);
                        break;
                    }
                }
            }
            else if (cevap == 2)
            {
                Console.WriteLine("Arama yapmak istediğiniz telefon numarasını girin: ");
                string searchnumber = Console.ReadLine();
                foreach (Users user in userlist)
                {
                    if (user.Number == searchnumber)
                    {
                        Console.WriteLine("İsim: "+ user.Isim);
                        Console.WriteLine("Soyisim: "+ user.Soyisim);
                        Console.WriteLine("Telefon numarası: "+ user.Number);
                        break;
                    }
                }
            }
        }
    }
}