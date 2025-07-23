using System.Text;
using Adarec_ui.Model.DTOs;
using Newtonsoft.Json;
using System.Configuration;

namespace Adarec_ui.Controller
{
    internal class MailController
    {
        private readonly string _baseUrl;

        public MailController()
        {
            _baseUrl = ConfigurationManager.AppSettings["baseUrl"]!;
        }

        public async Task<ApiResponseDto> SendOrderCompletionMailAsync(OrderDto order)
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/mail/send-mail";
            var json = JsonConvert.SerializeObject(order);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await client.PostAsync(url, content);
                var message = await response.Content.ReadAsStringAsync();
                return new ApiResponseDto
                {
                    Message = message,
                    StatusCode = (int)response.StatusCode
                };
            }
            catch (Exception ex)
            {
                return new ApiResponseDto
                {
                    Message = $"Error al enviar el correo: {ex.Message}",
                    StatusCode = 500
                };
            }
        }
    }
}
