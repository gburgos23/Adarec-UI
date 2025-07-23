using Adarec_ui.Model.DTOs;
using Newtonsoft.Json;
using System.Configuration;

namespace Adarec_ui.Controller
{
    public class CustomerController
    {
        private readonly string _baseUrl;

        public CustomerController()
        {
            _baseUrl = ConfigurationManager.AppSettings["baseUrl"]!;
        }

        public async Task<ApiResponseDto> GetAllCustomers()
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/Customer";
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

        public async Task<ApiResponseDto> GetIdentificationTypes()
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/Customer/identification-types";
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

        public async Task<ApiResponseDto> AddCustomer(CustomerDto customer)
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/Customer";
            var content = new StringContent(JsonConvert.SerializeObject(customer), System.Text.Encoding.UTF8, "application/json");
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

        public async Task<ApiResponseDto> UpdateCustomer(CustomerDto customer)
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/Customer";
            var content = new StringContent(JsonConvert.SerializeObject(customer), System.Text.Encoding.UTF8, "application/json");
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
                    Message = $"Error al procesar petición: {ex.Message}",
                    StatusCode = 500
                };
            }
        }

        public async Task<ApiResponseDto> DeleteCustomer(int customerId)
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/Customer/{customerId}";
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
                    Message = $"Error al procesar petición: {ex.Message}",
                    StatusCode = 500
                };
            }
        }

        public async Task<ApiResponseDto> ListOrdersByCustomer()
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/Customer/orders";
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
