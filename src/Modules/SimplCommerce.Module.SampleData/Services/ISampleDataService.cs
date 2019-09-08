using SimplCommerce.Module.SampleData.Areas.SampleData.ViewModels;
using System.Threading.Tasks;

namespace SimplCommerce.Module.SampleData.Services
{
    public interface ISampleDataService
    {
        Task ResetToSampleData(SampleDataOption model);
    }
}
