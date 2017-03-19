using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using AutoMapper;
using Microsoft.AspNet.Identity;
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

        [HttpGet]
        public void GetExport(string id)
        {
            User.Identity.GetUserName()
            MemoryStream ms = new MemoryStream();
            TextWriter tw = new StreamWriter(ms);
            tw.WriteLine("Line 1");
            tw.WriteLine("Line 2");
            tw.WriteLine("Line 3");
            tw.Flush();
            byte[] bytes = ms.ToArray();
            ms.Close();

            Response.Clear();
            Response.ContentType = "application/force-download";
            Response.AddHeader("content-disposition", "attachment;    filename=file.txt");
            Response.BinaryWrite(bytes);
            Response.End();
        }
    }
}
