using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductWeb.Models
{
    public class ReturnRes<T> where T : class
    {
        public ReturnRes(short code, T data, string error = null)
        {
            StatusCode = code;
            Data = data;
            Error = error;
        }
        public ReturnRes(short code, string error)
        {
            StatusCode = code;
            Data = null;
            Error = error;
        }
        public short StatusCode { get; private set; }
        public T Data { get; private set; }
        public string Error { get; private set; }
    }
    class ReturnRes : ReturnRes<object>
    {
        public ReturnRes(short code, string error) : base(code, error)
        {

        }
    }
}
