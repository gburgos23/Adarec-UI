using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adarec_ui.Model.DTOs
{
    public class LoginDto(string username, string password)
    {
        [JsonProperty("username")]
        public string Username { get; set; } = username;

        [JsonProperty("password")]
        public string Password { get; set; } = password;
    }
}
