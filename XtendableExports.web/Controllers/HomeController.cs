using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using XtendableExports.Models;
using XTendableExports.Domain.Contracts.Services;

namespace XtendableExports.Controllers
{
    public class HomeController : Controller
    {
        IExportService exportService;

        public HomeController(IExportService exportService)
        {
            this.exportService = exportService;
        }

        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IEnumerable<ExportViewModel>> GetPremadeExports()
        {
                var response = await this.exportService.GetAllAsync();
                return response;
        }
    }
}