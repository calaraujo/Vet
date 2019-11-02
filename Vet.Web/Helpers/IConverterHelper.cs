using System.Threading.Tasks;
using Vet.Web.Data.Entities;
using Vet.Web.Models;

namespace Vet.Web.Helpers
{
    public interface IConverterHelper
    {
        Task<Pet> ToPetAsync(PetViewModel model, string path, bool isNew);
        PetViewModel ToPetViewModel(Pet pet);
        Task<History> ToHistoryAsync(HistoryViewModel model, bool isNew);
        HistoryViewModel ToHistoryViewModel(History history);


    }
}