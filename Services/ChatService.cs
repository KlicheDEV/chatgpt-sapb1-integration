
using IntegracionChatGPT_SAPB1.Models;
using System.Threading.Tasks;

namespace IntegracionChatGPT_SAPB1.Services
{
    public class ChatService : IChatService
    {
        public async Task<string> ProcesarConsultaAsync(ChatRequest request)
        {
            // Simulación de procesamiento e integración con SAP
            await Task.Delay(100);
            return $"Consulta recibida: {request.Pregunta} (Usuario: {request.UsuarioSAP})";
        }
    }
}
