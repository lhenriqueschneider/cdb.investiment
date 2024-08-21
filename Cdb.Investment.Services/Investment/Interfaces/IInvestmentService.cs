using System.Threading.Tasks;
using Cdb.Investment.Services.Investment.Dto;

namespace Cdb.Investment.Services.Investment.Interfaces
{
    public interface IInvestmentService
    {
        Task<CalculateCdbResponse> Calculate(decimal monetaryValue, int mounths);
    }
}
