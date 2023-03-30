namespace Rehber.Rehber
{
    class Defter
    {
        public static List<Users> userslist = new List<Users>();
        public Defter()
        {

        Users user1 = new Users{Isim = "Enes",Soyisim = "Göksu",Number = "5342695632"};
        Users user2 = new Users{Isim = "Arda",Soyisim = "Güler",Number = "5356327856"};
        Users user3 = new Users{Isim = "Ozan",Soyisim = "Tufan",Number = "5469876325"};
        Users user4 = new Users{Isim = "Rıdvan",Soyisim = "Dilmen",Number = "5324569823"};
        userslist.Add(user1);
        userslist.Add(user2);
        userslist.Add(user3);
        userslist.Add(user4);

        
        }
    }
}