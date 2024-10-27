﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTO.Response
{
    public  class UserDataResponseDTO
    {
        public int? Id { get; set; }

        public string? FullName { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Boolean? IsAuthenticated { get; set; } = false;
        public string? token { get; set; }
    }
}
