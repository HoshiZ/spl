//using Microsoft.EntityFrameworkCore;
//using SPL.Data;
//using SPL.Models;
//using SPL.Repositories.IRepositories;

//namespace SPL.Repositories
//{
//    public class PDStationRepository : IPDStationRepository
//    {
//        private readonly PDDBContext _context;

//        public PDStationRepository(PDDBContext pDDBContext)
//        {
//            _context = pDDBContext;
//        }

//        public async Task<List<PDTrace>> GetByProductSNAsync(IEnumerable<string> productSNs)
//        {
//            return await _context.PD_Trace
//                                .Where(pdTrace => productSNs.Contains(pdTrace.ProductSN))
//                                .ToListAsync();
//        }

//        public Task<List<PDFormulasProcess>> GetFormulasProcessInfoAsync(string ProductCode)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<List<PDLineProcess>> GetLineProcessInfoAsync(string StationCode, string LineCode)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<PDStation> GetStationInfoAsync(string StationCode)
//        {
//            var stationsInfo = (await _context.PD_Station.Where(_ => _.StationCode == StationCode).ToListAsync()).FirstOrDefault();
//            return stationsInfo;
//        }

//        public Task<List<PDTrace>> GetTraceInfoAsync(string StationCode)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
