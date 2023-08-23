using ExchangeRateApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace ExchangeRateApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // 환율 계산 메소드
        private ExchangeRateModel Exchange(double won)
        {
            ExchangeRateModel exchangeM = new ExchangeRateModel();

            // 원화 -> 달러
            exchangeM.Dallar = won / exchangeM.getWON_PER_DALLAR();
            // 원화 -> 유로
            exchangeM.Euro = won / exchangeM.getWON_PER_EURO();
            // 원화 -> 엔
            exchangeM.Yen = won / exchangeM.getWON_PER_YEN();
            // 원화 -> 위안
            exchangeM.Yuan = won / exchangeM.getWON_PER_YUAN();

            return exchangeM;
        }

        [HttpPost]
        public IActionResult Index(double won)
        {
            //환율 계산
            ExchangeRateModel exchangeM = Exchange(won);

            // 환율 계산 객체 ViewBag에 삽입
            ViewBag.exchangeM = exchangeM;

            // 뷰로 전송
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
