using Microsoft.AspNetCore.Mvc;
using MvcCoreClienteApis.Models;
using MvcCoreClienteApis.Services;

namespace MvcCoreClienteApis.Controllers
{
    public class HospitalesController : Controller
    {
        private ServiceHospital service;

        public HospitalesController(ServiceHospital service)
        {
            this.service = service;
        }

        public async Task<IActionResult> Servidor()
        {
            List<Hospital> hospitales =
                await this.service.GetHospitalesAsync();
            return View(hospitales);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cliente()
        {
            return View();
        }
    }
}
