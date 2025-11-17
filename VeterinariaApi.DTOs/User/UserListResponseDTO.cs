using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaApi.DTOs.User
{
    public class UserListResponseDTO
    {
        public int Id {set; get;}
        public string Name { set; get; } = null!;
        public string  LastName {set; get;} = null!;
        public string Email {set; get;} = null!;
    }
}
