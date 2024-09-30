using System;

namespace UserInputApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan T.C. Kimlik Numarası, Ad, Soyad, Telefon Numarası, Yaş ve Ürün Fiyatları bilgilerini alıyoruz.
            Console.WriteLine("Lütfen T.C. Kimlik Numaranızı giriniz:");
            string tcKimlikNo = Console.ReadLine();

            Console.WriteLine("Lütfen adınızı giriniz:");
            string ad = Console.ReadLine();

            Console.WriteLine("Lütfen soyadınızı giriniz:");
            string soyad = Console.ReadLine();

            Console.WriteLine("Lütfen telefon numaranızı giriniz:");
            string telefonNo = Console.ReadLine(); // Telefon numarası için string veri tipini kullandım çünkü numaralarla matematiksel işlem yapılmayacak.

            Console.WriteLine("Lütfen yaşınızı giriniz:");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen ilk aldığınız ürünün fiyatını giriniz:");
            double ilkUrunFiyati = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lütfen ikinci aldığınız ürünün fiyatını giriniz:");
            double ikinciUrunFiyati = Convert.ToDouble(Console.ReadLine()); // Fiyat değerleri ondalıklı olabileceği için double veri tipi tercih edildi.

            // Ürün fiyatlarına göre mesaj gösteriyoruz.
            if (ilkUrunFiyati > ikinciUrunFiyati)
            {
                Console.WriteLine("İlk aldığınız ürünün fiyatı ikinci aldığınız üründen daha pahalı.");
            }
            else if (ilkUrunFiyati < ikinciUrunFiyati)
            {
                Console.WriteLine("İkinci aldığınız ürünün fiyatı ilk aldığınız üründen daha pahalı.");
            }
            else
            {
                Console.WriteLine("Her iki ürünün fiyatı da aynı.");
            }

            // Kullanıcının girdiği bilgileri ekrana yazdırıyoruz.
            Console.WriteLine("\nGirdiğiniz bilgiler:");
            Console.WriteLine($"T.C. Kimlik No: {tcKimlikNo}");
            Console.WriteLine($"Ad: {ad}");
            Console.WriteLine($"Soyad: {soyad}");
            Console.WriteLine($"Telefon No: {telefonNo}");
            Console.WriteLine($"Yaş: {yas}");
            Console.WriteLine($"İlk Ürün Fiyatı: {ilkUrunFiyati}");
            Console.WriteLine($"İkinci Ürün Fiyatı: {ikinciUrunFiyati}");
        }
    }
}

