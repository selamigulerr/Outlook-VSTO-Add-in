using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookAddIn3
{
    public class ResultModel<T>
    {
        public bool succeed { get; set; }
        public string message { get; set; }
        public T data { get; set; }
        public T currentUser { get; set; }
    }
}
