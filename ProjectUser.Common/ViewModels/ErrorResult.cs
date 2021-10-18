using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectUser.Common.ViewModels
{
    public class ErrorResult<T> : ResultBase<T>
    {
        public string[] ValidatiomErrors { get; set; }
        public ErrorResult()
        {

        }
        public ErrorResult(string msg)
        {
            IsSuccess = false;
            Message = msg;
        }
        public ErrorResult(string[] errors)
        {
            IsSuccess = false;
            ValidatiomErrors = errors;
        }
    }
}
