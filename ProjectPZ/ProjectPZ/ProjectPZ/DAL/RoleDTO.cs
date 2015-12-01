using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPZ.DAL
{
    class RoleDTO
    {
        public int id_role { get; set; }
        public string role_name { get; set; }

        public List<UserDTO> Users { get; set; }
    }
}
