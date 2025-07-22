using Adarec_ui.Model.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Adarec_ui.Controller
{
    public class CommentController
    {
        private readonly string _baseUrl;

        public CommentController()
        {
            _baseUrl = ConfigurationManager.AppSettings["baseUrl"]!;
        }

        public async Task<ApiResponseDto> AddCommentAsync(OrderCommentsDto comment)
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/Comments";
            var content = new StringContent(JsonConvert.SerializeObject(comment), Encoding.UTF8, "application/json");
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
                    Message = $"Error al procesar petición: {ex.Message}",
                    StatusCode = 500
                };
            }
        }
    }
}
