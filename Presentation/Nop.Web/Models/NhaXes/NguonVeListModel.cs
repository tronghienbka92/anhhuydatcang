using Nop.Core.Domain.NhaXes;
using Nop.Web.Framework;
using Nop.Web.Framework.Mvc;
using Nop.Web.Models.VeXeKhach;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nop.Web.Models.NhaXes
{
    public class NguonVeListModel : XeXuatBenModel
    {
        public NguonVeListModel()
        {
            DiemDonDi = new DiemDon();
            DiemDoDen = new DiemDon();
        }
        [NopResourceDisplayName("ChonVe.NhaXe.NguonVe.HanhTrinhId")]
        public int HanhTrinhId { get; set; }
        public int LichTrinhId { get; set; }
        public int ChuyenDiId { get; set; }
        public int DiemDonDiId { get; set; }
        public int DiemDonDenId { get; set; }
        public int SoLuongVe { get; set; }
        public decimal GiaVeHienTai { get; set; }
        public DiemDon DiemDonDi { get; set; }
        public DiemDon DiemDoDen { get; set; }
        public int SoNguonVe { get; set; }
        public int SoNgay { get; set; }
        [UIHint("Date")]
        [NopResourceDisplayName("Từ ngày")]
        public DateTime NgayDiFrom { get; set; }
        [UIHint("Date")]
        [NopResourceDisplayName("Đến ngày")]
        public DateTime NgayDiTo { get; set; }
        public string XeXuatBenResult { get; set; }
        public List<SelectListItem> HanhTrinhs { get; set; }
        public List<SelectListItem> LichTrinhs { get; set; }
        public List<SelectListItem> DiemDonDis { get; set; }
        public List<SelectListItem> DiemDonDens { get; set; }
        public DateModel[,] XepXeTheoNgay { get; set; }

        public class DateModel : BaseNopEntityModel
        {

            [UIHint("Date")]
            [NopResourceDisplayName("ChonVe.NhaXe.NguonVe.NgayDi")]
            public DateTime NgayXuatBen { get; set; }
            public int NguonVeId { get; set; }
            public string GioLichTrinh { get; set; }
            public int XeVanChuyenId { get; set; }
            public string BienSo { get; set; }
        }
    }
}