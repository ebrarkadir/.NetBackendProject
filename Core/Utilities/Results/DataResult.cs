using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T Data { get; }

        public DataResult(T data, bool success, string massege) : base(success,massege)
        {
            Data = data;
        }
        public DataResult(T data, bool success): base(success)
        {
            Data = data;
        }
    }
}
