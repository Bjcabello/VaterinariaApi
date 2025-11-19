using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaApi.DTOs.User
{
    public class UserDetailResponseDto
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int rol_id { get; set; }
    }
}
