using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adarec_ui.Model.DTOs
{
    public class LoginDto(string username, string password)
    {
        public string Username { get; set; } = username;
        public string Password { get; set; } = password;
    }
}
