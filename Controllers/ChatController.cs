
using Microsoft.AspNetCore.Mvc;
using IntegracionChatGPT_SAPB1.Services;

namespace IntegracionChatGPT_SAPB1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly IChatService _chatService;

        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpPost("consultar")]
        public async Task<IActionResult> ConsultarSAP([FromBody] ChatRequest request)
        {
            var respuesta = await _chatService.ProcesarConsultaAsync(request);
            return Ok(respuesta);
        }
    }
}
