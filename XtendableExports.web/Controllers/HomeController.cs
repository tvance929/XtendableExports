using System;
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
        IExportFileService exportFileService;

        public HomeController(IExportService exportService, IExportFileService exportFileService)
        {
            this.exportService = exportService;
            this.exportFileService = exportFileService;
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
        public async Task GetExport(string id, string fileNameFormat)
        {
            var byteFile = await this.exportFileService.GetExportFileAsync(id, User.Identity.GetUserName());
            var fileDateFormat = fileNameFormat.Substring(0, 8);
            var fileDate = DateTime.Now.ToString(fileDateFormat);
            
            Response.Clear();
            Response.ContentType = "application/force-download";
            Response.AddHeader("content-disposition", $"attachment; filename={fileDate}{fileNameFormat.Substring(8)}");
            Response.BinaryWrite(byteFile);
            Response.End();
        }
    }
}
