using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Uygulama1.Dtos;
using Uygulama1.Services;

namespace Uygulama1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HavaController : ControllerBase
    {
        // Yüksek seviye bir sınıf olan HavaController
        // bu örnekte doğrudan doğruya MGMServis'e bağımlıdır
        // Bu da SOLID'in D (Dependency Inversion) prensibine aykırı
        // Bir sonraki örnekte bağımlılıkları tersine çevirerek
        // her iki sınıfı da interface'e bağımlı hale getireceğiz
        // controller'ın ihtiyaç duyduğu hizmeti bu soyut tür ile
        // enjeksiyonunu sağlayacağız
        // BU DA BİZE HİZMET TÜRÜNDEN BAĞIMSIZ OLARAK KOD YAZMA ESNEKLİĞİ 
        // SAĞLAYACAK (İSTER MGM SERVİS İSTER WEATHER COM SERVICE OLSUN)
        MGMServis _havaServis;

        public HavaController()
        {
            _havaServis = new MGMServis();
        }

        [HttpGet("Sicaklik")]
        public SonucDto GetSicaklik(string sehir)
        {
            var dto = new SonucDto()
            {
                Sehir = sehir,
                Sicaklik = _havaServis.Sicaklik(sehir)
            };

            return dto;
        }
    }
}
