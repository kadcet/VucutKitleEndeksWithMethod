using PratikVKIWithMethod;

namespace PratikVKIWithMethod
{
    public class Program
    {
        public static void Main()
        {
            Goster();
           
        }

         static (decimal boy,decimal kilo,decimal VKI) OperantAl()
        {
            
            Console.WriteLine("Hastanın Boyunu Girin :");
            decimal boy = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hastanın Kilosunu Girin :");
            decimal kilo = Convert.ToDecimal(Console.ReadLine());
            decimal VKI = kilo / (boy * boy);
            
            return (boy, kilo,VKI);
        }

        public static void Goster()
        {
            Console.Clear();
            var opr = OperantAl();
            
            if (opr.VKI <= 18.49m)
                Console.WriteLine($"Hastanın Boyu:{opr.boy} Hastanın Kilosu:{opr.kilo} VKI indeksi:{opr.VKI}, Teşhis: ZAYIF");
            else if (opr.VKI > 18.49m && opr.VKI <= 24.99m)
                Console.WriteLine($"Hastanın Boyu:{opr.boy} Hastanın Kilosu:{opr.kilo} VKI indeksi:{opr.VKI}, Teşhis: İDEAL");
            else if (opr.VKI >= 25m && opr.VKI <= 29.99m)
                Console.WriteLine($"Hastanın Boyu:{opr.boy} Hastanın Kilosu:{opr.kilo} VKI indeksi:{opr.VKI}, Teşhis: HAFİF KİLOLU");
            else if (opr.VKI > 30m)
                Console.WriteLine($"Hastanın Boyu:{opr.boy},Hastanın Kilosu:{opr.kilo}, VKI indeksi:{opr.VKI}, Teşhis: OBEZ");
            
            Yeniİslem();

        }

        static void Yeniİslem()
        {
            Console.WriteLine("Yeni bir hesaplama yapmak istiyor musunuz? (E/H)");
            string cevap = Console.ReadLine();
            if (cevap == "e" || cevap == "E")
                Goster();
            else if (cevap == "h" || cevap == "H")
                Environment.Exit(0);
            else
            {
                Console.Clear();
                Console.WriteLine("Hatalı Giriş Yaptınız");
                Yeniİslem();
            }
                
            
        }
    }
    
    
}

