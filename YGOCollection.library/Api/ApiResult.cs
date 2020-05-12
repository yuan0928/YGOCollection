using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGOCollection.library.Enums;

namespace YGOCollection.library.Api
{
    public class ApiResult
    {
        public Code Code { get; set; }
        public string Message { get; set; }
    }

    public class ApiResult<T> : ApiResult
    {
        public T Data { get; set; }
    }
}
