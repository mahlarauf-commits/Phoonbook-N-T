using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Dto
{
    public class ReasultDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }    
    }
    public class ReasultDto<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
