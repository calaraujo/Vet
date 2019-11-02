using System.Threading.Tasks;

namespace Vet.Web.Helpers
{
    public interface IAgendaHelper
    {
        Task AddDaysAsync(int days);
    }
}
