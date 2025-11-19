using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaApi.DTOs.User;

namespace VeterinariaApi.DTOs.Auth
{
    public class AuthResponseDto
    {
        public UserDetailResponseDto User { get; set; }
        public string Token { get; set; }
    }

    public class TokenResponseDto
    {
        public string Token { get; set; }
    }
}
