using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectUser.Common.ViewModels
{
    public class PagingRequestBase
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
