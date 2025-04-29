namespace Ehliyet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ehliyet kontrol uygulamasına hoşgeldiniz!");

            int yas;
            while (true)
            {
                Console.Write("Yaşınızı giriniz: ");
                if (int.TryParse(Console.ReadLine(), out yas) && yas > 0)
                    break;
                else
                    Console.WriteLine("Lütfen geçerli bir yaş girin (0'dan büyük bir sayı).");
            }

            string saglik;
            while (true)
            {
                Console.Write("Sağlık durumunuz (evet = sağlıklı, hayır = sağlıksız): ");
                saglik = Console.ReadLine().ToLower();
                if (saglik == "evet" || saglik == "hayır")
                    break;
                else
                    Console.WriteLine("Lütfen sadece 'evet' ya da 'hayır' yazın.");
            }

            string sabika;
            while (true)
            {
                Console.Write("Sabıkanız var mı? (evet / hayır): ");
                sabika = Console.ReadLine().ToLower();
                if (sabika == "evet" || sabika == "hayır")
                    break;
                else
                    Console.WriteLine("Lütfen sadece 'evet' ya da 'hayır' yazın.");
            }

            if (yas >= 18 && saglik == "evet" && sabika == "hayır")
                Console.WriteLine("Ehliyet alabilirsiniz!");
            else
                Console.WriteLine("Ehliyet alamazsınız!");
        }
    }
}
