namespace Rehber.Rehber
{
    class WriteNumber
    {
        public static void Write(List<Users> userlist)
        {
            foreach (Users user in userlist)
            {
                Console.Write("İsim: "+ user.Isim);
                Console.Write("Soyisim: "+ user.Soyisim);
                Console.Write("Telefon Numarası: "+ user.Number);
                Console.WriteLine("********************************");
            }
        }
    }
}