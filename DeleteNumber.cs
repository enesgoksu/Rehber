namespace Rehber.Rehber
{
    class DeleteNumber
    {
        public static void Delete(List<Users> userlist)
        {
            Console.Write("Lütfen silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string deletename = Console.ReadLine();
            bool control = false;

            while (!control)
            {
                foreach (Users user in userlist)
                {
                    if (user.Isim.ToLower() == deletename || user.Isim.ToUpper() == deletename)
                    {
                        Console.WriteLine(user.Isim+" "+"isimli kişi rehberden silinmek üzere, onaylıyor musunuz?(y/n)");
                        char cevap = char.Parse(Console.ReadLine());
                        if (cevap == 'y' || cevap == 'Y')
                        {
                            userlist.Remove(user);
                            Console.WriteLine(user.Isim+" "+"isimli kişi silindi.");
                            control = true;
                            break;
                        }
                            else
                            {
                                control = true;
                            }
                    }
                        else if (user.Soyisim.ToLower() == deletename || user.Soyisim.ToUpper() == deletename)
                        {
                            Console.WriteLine(user.Soyisim+" "+"soyisimli kişi rehberden silinmek üzere, onaylıyor musunuz?(y/n)");
                            char cevap = char.Parse(Console.ReadLine());

                            if (cevap == 'y' || cevap == 'Y')
                            {
                                userlist.Remove(user);
                                Console.WriteLine(user.Soyisim+" "+"soyisimli kişi silindi.");
                                control = true;
                                break;
                            }
                            else
                            {
                                control = true;
                            }
                        }
                       
                }
               
            }
        }
    }
}