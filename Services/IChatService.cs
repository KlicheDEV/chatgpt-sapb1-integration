
using IntegracionChatGPT_SAPB1.Models;
using System.Threading.Tasks;

namespace IntegracionChatGPT_SAPB1.Services
{
    public interface IChatService
    {
        Task<string> ProcesarConsultaAsync(ChatRequest request);
    }
}
