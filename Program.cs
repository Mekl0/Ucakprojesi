namespace UcakProje
{
    public class Program
    {
        static List<Ucak> ucaklar;
        static List<Lokasyon> lokasyonlar;
        static List <Musteri> musteriler;
        static List<Rezervasyon> rezervasyonlar=new List<Rezervasyon>();   

        public static void Main(string[] args)
        {
            List<Musteri> Musteriler = new List<Musteri>();
            List<Ucak> ucaklar = new List<Ucak>();
            List<Lokasyon> lokasyonlar = new List<Lokasyon>();
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();
            // Örnek verileri oluştur
            Ucak ucak1 = new Ucak { Model = "Model 1", Marka = "Marka 1", SeriNo = "123", KoltukKapasitesi = 100 };
            Ucak ucak2 = new Ucak { Model = "Model 2", Marka = "Marka 2", SeriNo = "456", KoltukKapasitesi = 150 };
            
            

            Lokasyon lokasyon1 = new Lokasyon { Ulke = "Ülke 1", Sehir = "Şehir 1", Havaalani = "Havaalanı 1", Aktif = true };
            Lokasyon lokasyon2 = new Lokasyon { Ulke = "Ülke 2", Sehir = "Şehir 2", Havaalani = "Havaalanı 2", Aktif = true };

            ucaklar.Add(ucak1);
            ucaklar.Add(ucak2);

            lokasyonlar.Add(lokasyon1);
            lokasyonlar.Add(lokasyon2);

            // Kullanıcı arayüzü
            Console.WriteLine("Rezervasyon Yapma Uygulaması");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("1. Uçakları Listele");
                Console.WriteLine("2. Lokasyonları Listele");
                Console.WriteLine("3. Rezervasyon Yap");
                Console.WriteLine("4. Rezervasyonları Listele");
                Console.WriteLine("5. Çıkış");
                Console.WriteLine();

                Console.Write("Seçiminizi yapın");
                int secim;
                bool devamEt = true;
                while (devamEt)
                {
                    Console.Write("Seçiminizi yapın (1-5): ");
                    string secimStr = Console.ReadLine();

                    if (int.TryParse(secimStr, out secim))
                    {
                        switch (secim)
                        {
                            case 1:
                                UcaklariListele(ucaklar);
                                break;
                            case 2:
                                LokasyonlariListele(lokasyonlar);
                                break;
                            case 3:
                                RezervasyonYap();
                                break;
                            case 4:
                                RezervasyonlariListele();
                                break;
                            case 5:
                                devamEt = false;
                                break;
                            default:
                                Console.WriteLine("Geçersiz seçim!");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçim!");
                    }

                    Console.WriteLine();
                }
            }
            
        }
        public static void UcaklariListele(List<Ucak> ucaklar)
        {
            Console.WriteLine("Uçaklar:");
            for (int i = 0; i < ucaklar.Count; i++)
            {
                Ucak ucak = ucaklar[i];
                Console.WriteLine($"Model: {ucak.Model}");
                Console.WriteLine($"Marka: {ucak.Marka}");
                Console.WriteLine($"Seri No: {ucak.SeriNo}");
                Console.WriteLine($"Koltuk Kapasitesi: {ucak.KoltukKapasitesi}");
                Console.WriteLine();
            }
        }

         static void LokasyonlariListele(List<Lokasyon> lokasyonlar)
        {
            Console.WriteLine("Lokasyonlar:");
            for (int i = 0; i < lokasyonlar.Count; i++)

            {
                Lokasyon lokasyon = lokasyonlar[i];
                Console.WriteLine($"Ülke: {lokasyon.Ulke}");
                Console.WriteLine($"Şehir: {lokasyon.Sehir}");
                Console.WriteLine($"Havaalanı: {lokasyon.Havaalani}");
                Console.WriteLine($"Aktif: {lokasyon.Aktif}");
                Console.WriteLine();
            }
        }

        public static void RezervasyonYap()
        {
            Ucak ucak=new Ucak();
            Lokasyon lokasyon= new Lokasyon();
            Musteri musteri =new Musteri();
            Console.WriteLine("Rezervasyon Yapma Ekranı");
            Console.WriteLine();

            Rezervasyon rezervasyon = new Rezervasyon();

            Console.Write("Adınız :");
            musteri.Ad = Console.ReadLine();
            
            Console.Write("Soyadınız :");
            musteri.Soyad = Console.ReadLine(); 

            Console.Write("Telefonunuz :");
            musteri.Telefon = Console.ReadLine();

            Console.Write("Emailiniz :");
            musteri.Email = Console.ReadLine();
            Console.Write("Uçağın Kalkış Tarihi (yyyy-MM-dd HH:mm): ");
            musteri.Kalkistarihi = Console.ReadLine();

            rezervasyon.Musteri= musteri ;
            Console.WriteLine(musteriler);

            Console.Write("Varış Yeri Ülke: ");
            lokasyon.Ulke = Console.ReadLine();

            Console.Write("Varış Yeri Şehir: ");
            lokasyon.Sehir = Console.ReadLine();

            Console.Write("Varış Yeri Havaalanı: ");
            lokasyon.Havaalani = Console.ReadLine();
            rezervasyon.Lokasyon = lokasyon ;
            Console.Write("Uçak modeli : ");
            ucak.Model = Console.ReadLine();

            Console.Write("Uçak markası: ");
            ucak.Marka = Console.ReadLine();

            Console.Write("ucakseri no : ");
            ucak.SeriNo=Console.ReadLine();
            rezervasyon.Ucak = ucak ;
            rezervasyonlar.Add(rezervasyon);

            
            
            

            

            Console.WriteLine("Rezervasyon başarıyla yapıldı!");
            
            Console.WriteLine("Reservation Details:");
            Console.WriteLine($"Ad: {rezervasyon.Musteri.Ad}");
            Console.WriteLine($"Soyad: {rezervasyon.Musteri.Soyad}");
            Console.WriteLine($"Telefon: {rezervasyon.Musteri.Telefon}");
            Console.WriteLine($"Email: {rezervasyon.Musteri.Email}");
            Console.WriteLine($"Kalkış Tarihi: {rezervasyon.Musteri.Kalkistarihi}");

            Console.WriteLine(); // Add a line break between reservations
           

        }

        public static void RezervasyonlariListele()
        {
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();
            Console.WriteLine("Rezervasyonlar:");
            foreach (var rezervasyon in rezervasyonlar)
            {
                Console.WriteLine($"Müsteri: {rezervasyon.Musteri}");
                Console.WriteLine($"Uçak: {rezervasyon.Ucak}");
                Console.WriteLine($"Varış Yeri: {rezervasyon.Lokasyon}");
              
                
               
                Console.WriteLine();
           }
        }
    }
}
        