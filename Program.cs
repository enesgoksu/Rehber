namespace Rehber.Rehber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan numarayı silmek");
            Console.WriteLine("(3) Rehberi listelemek");
            Console.WriteLine("(4) Rehberde arama yapmak");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.Write("Lütfen yapmak istediğiniz işlemi seçin: ");
            int islemNo = int.Parse(Console.ReadLine());

            Defter defter = new Defter();
            bool control = true;
            while (control)
            {
                switch (islemNo)
                {
                    case 1:
                        AddNumber.Add(Defter.userslist);
                        break;
                    
                    case 2:
                        DeleteNumber.Delete(Defter.userslist);
                        break;
                    
                    case 3:
                        WriteNumber.Write(Defter.userslist);
                        break;
                    
                    case 4:
                        SearchNumber.Search(Defter.userslist);
                        break;
                    
                }
            }
        }
    }
}