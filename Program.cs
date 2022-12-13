namespace _7_Interface_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KullanıcıIslemleri k = new KullanıcıIslemleri();
            k.Oturumac();
            k.OturumKapat();

            AdminIslemleri a = new AdminIslemleri();
            a.Oturumac();
            a.KendiSatislariniGoster(); // interface den gelen üye
            a.OturumKapat();

            SuperAdminIslemleri s = new SuperAdminIslemleri();
            a.Oturumac();  // interfaceden gelen üye
            s.Oturumac();

            IAdminOperasyon adminlereOzelOperasyon;

            adminlereOzelOperasyon = a;
            adminlereOzelOperasyon.KendiSatislariniGoster();
            adminlereOzelOperasyon.YıllıkSatısRaporlari();

            adminlereOzelOperasyon = s;
            adminlereOzelOperasyon.KendiSatislariniGoster();
            adminlereOzelOperasyon.YıllıkSatısRaporlari();

            a.OturumKapat();
            s.OturumKapat();

            Console.ReadKey();


        }

    }
}