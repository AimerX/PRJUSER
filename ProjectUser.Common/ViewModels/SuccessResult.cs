using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectUser.Common.ViewModels
{
    public class SuccessResult<T> : ResultBase<T>
    {
        public SuccessResult()
        {
            IsSuccess = true;
        }
        public SuccessResult(T obj)
        {
            IsSuccess = true;
            Obj = obj;
        }
    }
}
