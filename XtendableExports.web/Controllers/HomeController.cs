using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using AutoMapper;
using XtendableExports.Models;
using XTendableExports.Domain;
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
        public async Task<string> GetPremadeExports()
        {
            var exports = await this.exportService.GetAllAsync();
            var exportvms = exports.Select(Mapper.Map<Export, ExportViewModel>).ToList();
            var serializer = new JavaScriptSerializer();
            return serializer.Serialize(exportvms);
        }
    }
}