namespace Cerceve
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            bool degisken = true;
            bool degisken2=true;
            while (degisken)
            {
                degisken = false;
                Console.Write("Pozitif kenar uzunluğunu girin: ");
                string uzunluk = Console.ReadLine();
                bool result1 = int.TryParse(uzunluk, out int kenarUzunlugu);
                if (result1 == false || kenarUzunlugu <= 0)
                {
                   degisken=true;
                    Console.Clear();
                }
                else
                {

                        Console.Clear();
                        DrawBox(kenarUzunlugu);
                       
                        degisken2 = true;
                    while (degisken2)
                    {
                        degisken = true;
                        Console.Write("Çizime devam etmek için 'E', çıkış için 'H' tuşuna basın.");
                        ConsoleKeyInfo keyInfo = Console.ReadKey();

                      
                        
                        if (keyInfo.Key == ConsoleKey.E)
                        {
                            degisken = true;
                            degisken2 = false;
                            Console.Clear();
                        }
                        else if (keyInfo.Key == ConsoleKey.H)
                        {
                            degisken = false;
                            degisken2 = false;
                        }
                        else
                        {

                            Console.Write("Çizime devam etmek için 'E', çıkış için 'H' tuşuna basın.");
                            Console.Clear();
                        }

                    }

                }
            } 
        }

        static void DrawBox(int uzunluk)
        {
          
            Console.Write("+");
            for (int i = 0; i < uzunluk; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");

            for (int i = 0; i < uzunluk; i++)
            {
                Console.Write("|");
                for (int j = 0; j < uzunluk; j++) 
                {
                    Console.Write(" ");
                } 
                Console.WriteLine("|");
            }

            Console.Write("+");
            for (int i = 0; i < uzunluk; i++)
            {
                Console.Write("-");
            }  
            Console.WriteLine("+");
        }
    }
}