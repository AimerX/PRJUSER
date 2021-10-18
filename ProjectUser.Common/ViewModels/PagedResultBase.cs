using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectUser.Common.ViewModels
{
    public class PagedResultBase
    {
        public class PageResultBase
        {
            public int Index { get; set; }
            public int Total { get; set; }
            public int Size { get; set; }
            public int PageCount { 
                get
                {
                    double pageCount = Total/Size;
                    return (int)Math.Ceiling(pageCount);
                } 
            }
        }
    }
}
