using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, bool error, string massege):base(data, false, massege)
        {
                
        }
        public ErrorDataResult(T data, bool error):base(data, false)
        {

        }
        public ErrorDataResult(string massege):base(default,false,massege)
        {

        }
        public ErrorDataResult():base(default,false)
        {

        }
    }
}
