﻿using Adarec_ui.Model.DTOs;
using Newtonsoft.Json;
using System.Configuration;
using System.Text;

namespace Adarec_ui.Controller
{
    public class LoginController
    {
        private readonly string _baseUrl;

        public LoginController()
        {
            _baseUrl = ConfigurationManager.AppSettings["baseUrl"]!;
        }

        public async Task<ApiResponseDto> LoginAsync(LoginDto login)
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/Auth/login";
            var json = JsonConvert.SerializeObject(login);
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
                    Message = $"Error al procesar petición: {ex.Message}",
                    StatusCode = 500
                };
            }
        }
    }
}
