//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManagementMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_bookinfo
    {
        public string bookcode { get; set; }
        public string bookname { get; set; }
        public string type { get; set; }
        public string autor { get; set; }
        public string translator { get; set; }
        public string pubname { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<int> page { get; set; }
        public string bcase { get; set; }
        public Nullable<long> storage { get; set; }
        public Nullable<System.DateTime> inTime { get; set; }
        public string oper { get; set; }
        public Nullable<int> borrownum { get; set; }
    }
}
