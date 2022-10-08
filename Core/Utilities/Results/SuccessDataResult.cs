using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, bool success, string massege):base(data, true, massege)
        {

        }
        public SuccessDataResult(T data, bool success) : base(data, true)
        {

        }
        public SuccessDataResult(string massege) : base(default, true, massege) 
        {

        }
        public SuccessDataResult():base(default, true)
        {

        }
    }
}
