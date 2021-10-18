using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectUser.Common.ViewModels
{
    public class ResultBase<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Obj { get; set; }
    }
}
