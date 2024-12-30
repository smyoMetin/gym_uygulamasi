using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace gym_program
{
    internal class Program
    {
        private static string Gergel(string k)
        {
            // İŞLEM SORUSU METODU
            switch (k)
            {
                case "E": Console.Clear(); break;
                case "H": Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Çıkış yapılıyor..."); System.Threading.Thread.Sleep(2000); Environment.Exit(0); break;
                case "e": Console.Clear(); break;
                case "h": Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Çıkış yapılıyor..."); System.Threading.Thread.Sleep(2000); Environment.Exit(0); break;
                default: Console.Clear(); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Geçerli değer giremediniz."); Console.ForegroundColor = ConsoleColor.White; break;
            }
            return k;
        }
        static void Main(string[] args)
        {
           // Uye bilgileri icin liste olusturdum 
            List<string> uyeAd = new List<string>();
            List<double> uyeKilo = new List<double>();
            List<string> uyeSifre = new List<string>();
            List<double> uyeBoy = new List<double>();         
            List<double> uyeBmi = new List<double>();
            List<DateTime> tarih = new List<DateTime>();
           

            int iKarar;   // Alinan karar sayi olarak 
            string karar;   // Alinan karar
            double boykare; // boyun karesi
            double bmi; // bmi ı tanımladım 

            while (true)
            {   //Giris ekranı
                Console.WriteLine("GYM'E HOSGELDINIZ !!!");
                Console.WriteLine();
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: "); Console.WriteLine("1-) Uye İşlemleri"); Console.WriteLine("2-) Uye bilgileri "); Console.WriteLine("3-) Tüm üyeleri listele"); Console.WriteLine("4-) ÇIKIŞ");
                iKarar = Convert.ToInt32(Console.ReadLine());
               
                // Uye islemleri
                if (iKarar == 1)
                {
                    
                    Console.Clear();
                    Console.WriteLine("UYE İŞLEMLERİ");
                    Console.WriteLine();
                    Console.WriteLine("Uye bilgileri bu baslikta degildir!!!");
                    Console.WriteLine();
                    Console.WriteLine("Yapmak istediğiniz işlemi seçiniz."); Console.WriteLine("1-) Uye Kayıt"); Console.WriteLine("2-) Uye Bilgilerini Güncelle"); Console.WriteLine("3-) Kayitli uye sil ");
                    iKarar = Convert.ToInt32(Console.ReadLine());

                    // Uye kayit
                    if (iKarar == 1)
                    {
                        Console.Clear();                    
                        Console.WriteLine("UYE KAYIT EKRANI");
                        Console.WriteLine();
                        Console.WriteLine("İsminizi giriniz: ");
                        string isim = Console.ReadLine();                     
                        Console.WriteLine("Şifrenizi giriniz: ");
                        string sifre = Console.ReadLine();                 
                        Console.WriteLine("Kilonuzu giriniz: ");
                        double kilo = Convert.ToInt32(Console.ReadLine());             
                        Console.WriteLine("Boyunuzu giriniz: ");
                        double boy = Convert.ToDouble(Console.ReadLine());
                       
                    
                        // Uyelik süresi
                        Console.WriteLine("Kac aylik almak istiyorsunu?");
                        Console.WriteLine("3 aylik / 6 aylik / 12 aylik ");
                        while (true)
                        {
                            iKarar = Convert.ToInt32(Console.ReadLine());

                            if (iKarar == 3 || iKarar == 6 || iKarar == 12)

                            {
                                uyeAd.Add(isim);
                                uyeSifre.Add(sifre);
                                uyeKilo.Add(kilo);
                                uyeBoy.Add(boy);
                                boykare = boy * boy;
                                bmi = kilo / boykare;
                                uyeBmi.Add(bmi);

                                // 3 aylik uyelik
                                if (iKarar == 3)
                                {
                                    DateTime bugun = DateTime.Now;
                                    DateTime uyelıkSon = bugun.AddMonths(3);
                                    tarih.Add(uyelıkSon);
                                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("KAYIT BAŞARILI!!! "); Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Gergel(karar);
                                    break;
                                }
                                // 6 aylik uyelik
                                else if (iKarar == 6)
                                {
                                    DateTime bugun = DateTime.Now;
                                    DateTime uyelıkSon = bugun.AddMonths(6);
                                    tarih.Add(uyelıkSon);
                                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("KAYIT BAŞARILI!!! "); Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Gergel(karar);
                                    break;
                                }
                                // 1 senelik uyelik 
                                else if (iKarar == 12)
                                {
                                    DateTime bugun = DateTime.Now;
                                    DateTime uyelıkSon = bugun.AddYears(1);
                                    tarih.Add(uyelıkSon);
                                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("KAYIT BAŞARILI!!! "); Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Gergel(karar);
                                    break;
                                }


                            }
                            else
                            {
                                // gecersiz islem
                                Console.ForegroundColor = ConsoleColor.Red; Console.Write("Geçerli değer giremediniz tekrar deneyin: "); Console.ForegroundColor = ConsoleColor.White;
                              
                            }
                        }
                    Console.Clear();
                    }
                    //Bilgileri guncelle
                    else if (iKarar == 2)
                    {
                       
                        Console.Clear();
                        Console.WriteLine("MÜŞTERİ BİLGİLERİ GÜNCELLEME EKRANI");
                        Console.Write("İsim giriniz: "); string ism = Console.ReadLine();
                        Console.Write("Şifrenizi giriniz:");
                        while (true)
                        {  // sifre kontrol
                            string sifre = Console.ReadLine();
                            int index = uyeAd.IndexOf(ism);
                            if (sifre == uyeSifre[index])
                            {

                                if (uyeAd.Contains(ism))
                                {
                                    Console.WriteLine("Değiştirmek istediğiniz işlemi seçiniz.");
                                    Console.WriteLine("1-) Uye Kilo "); Console.WriteLine("2-) Uye Boy"); Console.WriteLine("3-) Uye Şifre"); 
                                    iKarar = Convert.ToInt32(Console.ReadLine());
                                    index = uyeAd.IndexOf(ism);
                                    // Kilo guncelleme 
                                    if (iKarar == 1)
                                    {
                                        Console.WriteLine("Yeni Kiloyu Giriniz: ");
                                        int kilo = Convert.ToInt32(Console.ReadLine()); 
                                        uyeKilo[index] = kilo ;
                                        boykare = uyeBoy[index] * uyeBoy[index];
                                        uyeBmi[index] = bmi= kilo/boykare;
                                    
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Kilo Güncellendi!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Gergel(karar); break;
                                    }
                                    // Boy Guncelleme 
                                    else if (iKarar == 2)
                                    {
                                        Console.WriteLine("Yeni Boyu Giriniz: ");
                                        double boy  = Convert.ToDouble(Console.ReadLine()); 
                                        uyeBoy[index] = boy;
                                        boykare = uyeBoy[index] * uyeBoy[index];
                                        uyeBmi[index] = bmi = uyeKilo[index] / boykare ;
                                      
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Boy Güncellendi!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Başka bir işlem yapmak istiyor musunuz? E - H"); karar = Console.ReadLine(); Gergel(karar); break;
                                    }
                                    //sifre guncelleme 
                                    else if (iKarar == 3)
                                    {
                                        Console.WriteLine("Yeni şifrenizi giriniz:");
                                        sifre = Console.ReadLine();
                                        uyeSifre[index] = sifre;
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Şifreniz Güncellendi!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Başka bir işlem yapmak istiyor musunuz? E - H"); karar = Console.ReadLine(); Gergel(karar); break;
                                    }
                                   
                                    else
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Geçerli bir değer giremediniz!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Başka bir işlem yapmak istiyor musunuz? E - H"); karar = Console.ReadLine(); Gergel(karar); break;
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Uye Bulunamadı!");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Başka bir işlem yapmak istiyor musunuz? E - H"); karar = Console.ReadLine(); Gergel(karar); break;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red; Console.Write("Şifreniz Yanlıştır! Tekrar Deneyiniz: "); Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                    }
                    //Uye silme 
                    else if (iKarar ==3) 
                    {
                        Console.Clear();
                        
                        int sayac = 0;

                        foreach (string i in uyeAd)
                        {
                            sayac++;
                            Console.WriteLine(sayac + "- "+ i);
                            
                        
                        }
                        Console.WriteLine("Silmek istedginiz kisiyi secin");
                        int secKisi=Convert.ToInt32(Console.ReadLine());
                        uyeAd.RemoveAt(secKisi - 1);
                        uyeKilo.RemoveAt(secKisi - 1);
                        uyeBmi.RemoveAt(secKisi - 1);
                        uyeBoy.RemoveAt(secKisi - 1);
                        uyeSifre.RemoveAt(secKisi - 1);
                        tarih.RemoveAt(secKisi - 1);
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Geçerli bir değer giremediniz!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Başka bir işlem yapmak istiyor musunuz? E - H"); karar = Console.ReadLine(); Gergel(karar); break;
                    }
                }
                //// Uye arama
                else if (iKarar == 2)
                {
                    
                    Console.Clear();
                    Console.WriteLine("Uyenin adini giriniz:");      
                        karar = Console.ReadLine();
                        Console.Clear();     
                            Console.WriteLine("UYE ADI                  BOY        KILO        BMI           UYELIK BITIS        ");
                            Console.WriteLine("-----------------------------------------------------------------------------------------");
                            for (int i = 0; i < uyeAd.Count; i++)
                            {
                                if (uyeAd[i].Equals(karar))
                                {
                                     
                                     Console.Write($"{uyeAd[i],-24}{uyeBoy[i],-10}{uyeKilo[i],-10}{uyeBmi[i],-20}{tarih[i],16}"); Console.ForegroundColor = ConsoleColor.Green;  Console.ForegroundColor = ConsoleColor.White;


                                        // Bmi Siniflandirmasi
                                        if (uyeBmi[i] < 18.5)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Çok zayıfsınız");
                                            Console.WriteLine("");
                                            Console.WriteLine("Kilo almanız lazım ");
                                            Console.WriteLine("");
                                            Console.WriteLine("Kalori fazlalığı bırakmanız lazım ");


                                        }
                                        else if (uyeBmi[i] >= 18.5 && uyeBmi[i] <25 )
                                        {

                                            Console.WriteLine("");
                                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Gayet Sağlıklısınız"); Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("");
                                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Kilonuzu koruyun"); Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("");
                                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Fazla kalori almamaya dikkat edin "); Console.ForegroundColor = ConsoleColor.White;


                                         }
                                        else if (uyeBmi[i] >= 25 && uyeBmi[i] < 30)
                                        {

                                            Console.WriteLine("");
                                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Biraz fazla kilolarınız var "); Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("");
                                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Kilo vermeniz lazım "); Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("");
                                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Antrenmazlarınıza kardiyo ekleyin ve biraz kalori açığı verin "); Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        else if (uyeBmi[i] >= 30 && uyeBmi[i] < 40)
                                        {

                                            Console.WriteLine("");
                                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Kilolusunuz");Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("");
                                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Kilo verin "); Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("");
                                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Kardiyolara ağırlık verin ve sıkı bir diyete girin "); Console.ForegroundColor = ConsoleColor.White;
                                         }
                                        else if (uyeBmi[i] >= 40)
                                        {

                                            Console.WriteLine("");
                                            Console.ForegroundColor = ConsoleColor.Red;Console.WriteLine("Aşırı kilolusunuz");Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("");
                                            Console.ForegroundColor = ConsoleColor.Red;Console.WriteLine("Bir doktora görünün ve kilo verin");Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("");
                                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Kardiyolara ağırlık verin ve sıkı bir diyete girin"); Console.ForegroundColor = ConsoleColor.White;
                                        }
    
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Gergel(karar);
                }
                // Tum uyelerin adini ve son uyelik tarihlerini listeleme
                else if (iKarar == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Tüm Üyelerimiz: ");
                    Console.WriteLine();
                    for (int i = 0; i < uyeAd.Count; i++)
                    {
                        Console.WriteLine($"{uyeAd[i],-20}{tarih[i]}");

                    }
                    Console.WriteLine();
                    Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Gergel(karar);
                }
                // cikis
                else if (iKarar == 4)
                {       // ÇIKIŞ
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Çıkış Yapılıyor.."); System.Threading.Thread.Sleep(2000); Environment.Exit(0);
                }
                // gecersiz islem 
                else
                {  
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Geçerli bir değer girmediniz"); Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Başka bir işlem yapmak ister misiniz? E - H"); karar = Console.ReadLine(); Gergel(karar);
                }
            }
        }
    }
}
