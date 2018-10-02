using Nop.Web.Framework.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nop.Web.Models.ChuyenPhatNhanh
{
    public class BangGiaCuocHangHoaModel : BaseNopEntityModel
    {
        public string TenHangHoa { get; set; }
        public decimal GiaCuoc { get; set; }
        public int SoLuong { get; set; }
    }
}