using System.Threading.Tasks;

namespace XTendableExports.Domain.Contracts.Services
{
    public interface IExportFileService
    {
        Task<byte[]> GetExportFileAsync(string exportId, string loggedInUserName);
    }
}
