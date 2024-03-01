using SPL.Models;

namespace SPL.Repositories.IRepositories
{
    public interface IPDStationRepository
    {
        Task<PDStation> GetStationInfoAsync(string StationCode);
        Task<List<PDTrace>> GetTraceInfoAsync(string StationCode);
        Task<List<PDLineProcess>> GetLineProcessInfoAsync(string StationCode, string LineCode);
        Task<List<PDFormulasProcess>> GetFormulasProcessInfoAsync(string ProductCode);
        Task<List<PDTrace>> GetByProductSNAsync(IEnumerable<string> productSNs);
    }
}
