using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using Adarec_ui.Model.DTOs;
using Newtonsoft.Json;

namespace Adarec_ui.Controller
{
    internal class OrderController
    {
        private readonly string _baseUrl;

        public OrderController()
        {
            _baseUrl = ConfigurationManager.AppSettings["baseUrl"]!;
        }

        public async Task<ApiResponseDto> AddOrderAsync(OrderDto order)
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/Orders";
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
                    Message = $"Error al agregar la orden: {ex.Message}",
                    StatusCode = 500
                };
            }
        }

        public async Task<ApiResponseDto> UpdateOrderAsync(OrderDto order)
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/Orders";
            var json = JsonConvert.SerializeObject(order);
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
                    Message = $"Error al actualizar la orden: {ex.Message}",
                    StatusCode = 500
                };
            }
        }

        public async Task<ApiResponseDto> GetOrderDetailByIdAsync(int orderId)
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/Orders/{orderId}";
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
                    Message = $"Error al obtener detalle de la orden: {ex.Message}",
                    StatusCode = 500
                };
            }
        }

        public async Task<ApiResponseDto> GetAllOrdersAsync()
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/Orders";
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
                    Message = $"Error al obtener las órdenes: {ex.Message}",
                    StatusCode = 500
                };
            }
        }

        public async Task<ApiResponseDto> GetPendingOrdersByTechnicianAsync(int technicianId)
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/Orders/pending-by-technician?idTechnician={technicianId}";
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
                    Message = $"Error al obtener órdenes pendientes: {ex.Message}",
                    StatusCode = 500
                };
            }
        }

        public async Task<ApiResponseDto> GetAllOrderStatusesAsync()
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/Orders/statuses";
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
                    Message = $"Error al obtener los estados de orden: {ex.Message}",
                    StatusCode = 500
                };
            }
        }

        public async Task<ApiResponseDto> UpdateDeviceDetailAsync(DeviceDetailDto deviceDetail)
        {
            using var client = new HttpClient();
            var url = $"{_baseUrl}/api/Item/device-detail";
            var json = JsonConvert.SerializeObject(deviceDetail);
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
                    Message = $"Error al actualizar el detalle del dispositivo: {ex.Message}",
                    StatusCode = 500
                };
            }
        }
    }
}
