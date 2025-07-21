using Adarec_ui.Model.DTOs;
using System.Configuration;
using System.Text.Json;
using System.Windows.Forms;

namespace Adarec_ui.Controller
{
    public class RolController
    {
        private readonly string _baseUrl;

        public RolController()
        {
            _baseUrl = ConfigurationManager.AppSettings["baseUrl"]!;
        }

        public async Task<ApiResponseDto> GetRoles()
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/Roles";

            try
            {
                var response = await client.GetAsync(url);

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
                    Message = $"Error al procesar petición: {ex.Message}",
                    StatusCode = 500
                };
            }
        }
    }
}