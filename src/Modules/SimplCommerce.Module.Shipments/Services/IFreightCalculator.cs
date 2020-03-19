using System.Threading.Tasks;
using SimplCommerce.Module.Shipments.Models;
using SimplCommerce.Module.Shipments.Models.Requests;
using SimplCommerce.Module.Shipments.Models.Responses;

namespace SimplCommerce.Module.Shipments.Services
{
    public interface IFreightCalculator
    {        
        Task<CalculateFreightResponse> CalculateFreightForPackage(CalculatePackageFreightRequest request);

    }
}
