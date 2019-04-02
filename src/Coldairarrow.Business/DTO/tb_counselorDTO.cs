using Coldairarrow.Entity.Admin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coldairarrow.Business.DTO
{
    public class tb_counselorDTO : tb_counselor
    {
        public string categorys { get; set; }
        public string CounselorAvatar { get; set; }
        public decimal price { get; set; }
        public int maxquestion { get; set; }
        public decimal quickprice { get; set; }
    }
}
