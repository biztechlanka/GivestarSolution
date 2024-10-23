using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiveStarModels
{
    public class ApiResponse
    {
        public int StatusCode { get; set; }
        public string? MessageTitle { get; set; }
        public bool ModelValid { get; set; }
        public string? Message { get; set; }
        public object? Data { get; set; }
    }
}
