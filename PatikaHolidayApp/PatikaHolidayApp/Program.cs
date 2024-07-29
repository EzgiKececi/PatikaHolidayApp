using System;

class Program
{
    static void Main()
    {
        bool holidayPlan = true;

        while (holidayPlan)
        {
            // Lokasyonları ve fiyatları tanımla
            int bodrumPrice = 4000;
            int marmarisPrice = 3000;
            int cesmePrice = 5000;
            int busPrice = 1500;
            int airplanePrice = 4000;

            int locationPrice = 0;
            

            // Lokasyon seçimi
            bool validLocation = false;

            while (!validLocation)
            {
                Console.Write("Tatil rotanızı lütfen belirtiniz (Bodrum,Marmaris,Çeşme): ");
                string location = Console.ReadLine().ToLower();
                Console.WriteLine();

                switch (location)
                {
                    case "bodrum":
                        Console.WriteLine("Bodrum'un eşsiz koylarında denizin tadını çıkarabilir, çok sayıda antik kent gezebilirsiniz.");
                        locationPrice = bodrumPrice;                       
                        validLocation = true;
                        break;

                    case "marmaris":
                        Console.WriteLine("Marmaris'te başta Azmak Nehri olmak üzere doğanın eşsiz güzelliklerinde huzur bulacaksınız. ");
                        locationPrice = marmarisPrice;                      
                        validLocation = true;
                        break;

                    case "çeşme":
                        Console.WriteLine("Alaçatı'da pek çok beach ve plaj seçeneği sizi bekliyor. Çeşme Marina'da keyfili zamanlar geçirebilirsiniz.");
                        locationPrice = cesmePrice;                       
                        validLocation = true;
                        break;

                    default:
                        Console.WriteLine("Geçersiz lokasyon. Lütfen size sunulan seçeneklerden birini seçiniz:");
                        break;
                }
            }

            // Kişi sayısı
            int personNumber = 0;
            bool validPersonNumber = false;

            while (!validPersonNumber)
            {
                Console.Write("Tatil planınız kaç kişilik olacak?: ");
                if (int.TryParse(Console.ReadLine(), out personNumber))
                {
                    validPersonNumber = true;
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir kişi sayısı giriniz: ");
                }
            }

            // Ulaşım seçimi

            int transportPrice = 0;
            bool validTransportChoice = false;

            while (!validTransportChoice)
            {
                Console.WriteLine("Ulaşım tercihinizi belirtiniz(1 ya da 2 olarak):\n1 - Kara yolu (Kişi başı 1500 TL)\n2 - Hava yolu (Kişi başı 4000 TL)");
                string transportChoice = Console.ReadLine();
                Console.WriteLine();

                switch (transportChoice)
                {
                    case "1":
                        transportPrice = busPrice;
                        validTransportChoice = true;
                        break;

                    case "2":
                        transportPrice = airplanePrice;
                        validTransportChoice = true;
                        break;

                    default:
                        Console.WriteLine("Geçersiz seçenek. Lütfen 1 veya 2 giriniz.");
                        break;
                }
            }

            // Toplam maliyeti hesapla
            int totalPrice = ((locationPrice + transportPrice) * personNumber) * 3; // 3 günlük toplam tatil maliyeti



            Console.WriteLine($"Girmiş olduğunuz bilgilere göre toplam maliyet: {totalPrice} TL");

            // Başka bir plan isteniyor mu?
            Console.WriteLine("\nBaşka bir tatil planlamak ister misiniz? (Evet ya da Hayır olarak belirtiniz. )");
            string anotherPlan = Console.ReadLine().ToLower();
            Console.WriteLine();



            if (anotherPlan != "evet")
            {
                holidayPlan = false;
                Console.WriteLine("İyi günler dileriz!");
            }
        }
    }
}
