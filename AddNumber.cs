namespace Rehber.Rehber
{
    class AddNumber
    {
        public static void Add(List<Users> userlist)
        {
            Console.Write("Lütfen isim giriniz: ");
            string isim = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz: ");
            string soyisim = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz: ");
            string no = Console.ReadLine();

            Users user = new Users{Isim = isim,Soyisim = soyisim,Number = no};
            userlist.Add(user);
        }
    }
}