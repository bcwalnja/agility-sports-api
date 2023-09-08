using AgilitySportsAPI.Dtos;
using AgilitySportsAPI.Models;

namespace AgilitySportsAPI.Data;
public interface INFLRepo
{
    #region NFL

    Task<IEnumerable<NFLRoster>> GetAllNFLRoster();
    Task<IEnumerable<NFLRosterDto>> GetNFLRoster();

    #endregion
}