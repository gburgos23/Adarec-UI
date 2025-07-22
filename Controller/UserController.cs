using System.Text;
using System.Configuration;
using Adarec_ui.Model.DTOs;
using Newtonsoft.Json;

namespace Adarec_ui.Controller
{
    internal class UserController
    {
        private readonly string _baseUrl;

        public UserController()
        {
            _baseUrl = ConfigurationManager.AppSettings["baseUrl"]!;
        }

        public async Task<ApiResponseDto> GetUsersAsync()
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/Users";
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
                    Message = $"Error al obtener usuarios: {ex.Message}",
                    StatusCode = 500
                };
            }
        }

        public async Task<ApiResponseDto> AddUserAsync(TechnicianDto user)
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/Users";
            var json = JsonConvert.SerializeObject(user);
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
                    Message = $"Error al agregar usuario: {ex.Message}",
                    StatusCode = 500
                };
            }
        }

        public async Task<ApiResponseDto> UpdateUserAsync(TechnicianDto user)
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/Users";
            var json = JsonConvert.SerializeObject(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await client.PutAsync(url, content);
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
                    Message = $"Error al actualizar usuario: {ex.Message}",
                    StatusCode = 500
                };
            }
        }

        public async Task<ApiResponseDto> DeleteUserAsync(int userId)
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/Users/{userId}";
            try
            {
                var response = await client.DeleteAsync(url);
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
                    Message = $"Error al eliminar usuario: {ex.Message}",
                    StatusCode = 500
                };
            }
        }

        public async Task<ApiResponseDto> GetTechnicianWorkloadAsync()
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/Users/workload";
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
                    Message = $"Error al obtener carga de trabajo: {ex.Message}",
                    StatusCode = 500
                };
            }
        }

        public async Task<ApiResponseDto> GetCustomerByIdentificationAsync(string identificationClient)
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/Customer/{identificationClient}";
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
                    Message = $"Error al obtener cliente: {ex.Message}",
                    StatusCode = 500
                };
            }
        }
    }
}
