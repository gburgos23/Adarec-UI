using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Configuration;
using Adarec_ui.Model.DTOs;

namespace Adarec_ui.Controller
{
    internal class DeviceController
    {
        private readonly string _baseUrl;

        public DeviceController()
        {
            _baseUrl = ConfigurationManager.AppSettings["baseUrl"]!;
        }

        public async Task<ApiResponseDto> GetActiveModelsAsync()
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/Models";
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
                    Message = $"Error al obtener modelos: {ex.Message}",
                    StatusCode = 500
                };
            }
        }

        public async Task<ApiResponseDto> GetAllItemStatusesAsync()
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/Item/statuses";
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
                    Message = $"Error al obtener estados de ítem: {ex.Message}",
                    StatusCode = 500
                };
            }
        }
    }
}
