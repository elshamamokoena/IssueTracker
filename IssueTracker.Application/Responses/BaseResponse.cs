using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Responses
{
    public class BaseResponse
    {
       public BaseResponse(string message)
        {
            Success = true;
            Message = message;
        }
        public BaseResponse(bool success, string message)
        {
            Success = success;
            Message = message;
        }
        public BaseResponse()
        {
            Success = true;
        }
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public List<string>? ValidationErrors { get; set; }
    }
}
