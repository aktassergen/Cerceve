namespace Cerceve
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool degisken = true;
            while (degisken)
            {
                degisken = false;
                Console.Write("Kutu için Genişlik(width) ve Yükseklik(height) değeri giriniz (Örn, 2x3): ");
                string[] deger = Console.ReadLine().Split('x');
                if (string.IsNullOrWhiteSpace(deger[0]) || string.IsNullOrWhiteSpace(deger[1]))
                {
                    degisken = true;
                    Console.Clear();
                }
                else
                {
                    bool result1 = int.TryParse(deger[0], out int width);
                    bool result2 = int.TryParse(deger[1], out int height);
                    if (deger.Length != 2 || result1 == false || result2 == false)
                    {
                        degisken = true;
                        Console.Clear();
                    }
                    else if (width <= 0 || height <= 0)
                    {
                        bool degisken2 = true;
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
                    else
                    {
                        Console.Clear();
                        DrawBox(width, height);
                        //buradan aşağı kadar kod tekrari var burasini duzeltmeye zamanım yetmedi
                        bool degisken2 = true;
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
                        //buraya kadar cansın söyledi de fark ettim
                    }
                }

            }
        }

        static void DrawBox(int width, int height)
        {
            Console.Write("+");
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");

            for (int i = 0; i < height; i++)
            {
                Console.Write("|");
                for (int j = 0; j < width; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }

            Console.Write("+");
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}