using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Abstract
{
    public interface IDataResult<T>:IResult
    {
    T Data { get; }

        //Generic tipte T data alacak bunun yanında success ve message de IResulttan gelecek zaten..
    }
}
