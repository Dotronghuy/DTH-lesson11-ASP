using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DTHK22CNT1lesson11.Models
{

    public partial class DthTaikhoan
    {
        public int DthID { get; set; }
        public string DthUserName { get; set; }
        public string DthPassword { get; set; }
        public string DthFullName { get; set; }
        public Nullable<int> DthAge { get; set; }
        public string DthEmail { get; set; }
        public string DthPhone { get; set; }
        public Nullable<bool> DthStatus { get; set; }
    }
}