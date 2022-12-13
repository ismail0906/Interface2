using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Interface_2
{
    public class KullanıcıOperasyon
    {
        public void Oturumac() 
        {
            Console.WriteLine($"Oturum Açıldı...Tarih{DateTime.Now}");
        }
        public void OturumKapat() 
        {
            Console.WriteLine("Oturum Kapatıldı");
        }

    }

    public interface IAdminOperasyon 
    {
        public void YıllıkSatısRaporlari() 
        {
            Console.WriteLine("Yıllık satis raporları gosteriliyor");
        }
        public void KendiSatislariniGoster(); // Admin kendisine bağlı üyeleri göstersin
    }

    public class AdminIslemleri : KullanıcıIslemleri, IAdminOperasyon 
    {
        public void KendiSatislariniGoster()
        {
            Console.WriteLine("Admin 100 adet ürün satti");
        }
    }

    public class SuperAdminIslemleri : KullanıcıIslemleri, IAdminOperasyon
    {
        public void KendiSatislariniGoster() 
        {
            Console.WriteLine("SuperAdmin 50 adet ürün satti");
        }
    }

    public class KullanıcıIslemleri : KullanıcıOperasyon
    {

    }
}
