using SPL.Models.Dto;
using SPL.Models.SPLProcessResult;

namespace SPL.Services.IServices
{
    public interface ISPLService
    {
        /// <summary>
        /// SPL进站处理
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<SPLProcessResultDto> SPLBoxIn(SPLBoxInDto data);

        /// <summary>
        /// SPL出站处理
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<SPLProcessResultDto> SPLBoxOut(SPLBoxOutDto data);

        /// <summary>
        /// SPL上线指站
        /// </summary>
        /// <returns></returns>
        Task<SPLProcessResultDto> SPLBoxOnlineStationOver(SPLBoxStationOverDto data);

        Task<SPLProcessResultDto> SPLLogin(string UserName, string Password);

        Task<SPLProcessResultDto> SPLBoxBind(SPLBoxBindDto data);

        Task<SPLProcessResultDto> SPLBoxUnBind(SPLBoxUnBindDto data);

        Task<SPLProcessResultDto> SPLGetBoxData(string BoxSN, string UID, string StationCode);
    }
}
