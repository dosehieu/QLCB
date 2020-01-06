using Microsoft.Extensions.Options;
using QLCBCore.Models;
using QLCBCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Base
{
    public class GetStoredProcedure
    {
        private readonly IOptions<ConnectionString> config;
        private readonly QLCBDbContext _context;

        public GetStoredProcedure()
        {
        }

        public GetStoredProcedure(QLCBDbContext context, IOptions<ConnectionString> config)
        {
            _context = context;
            this.config = config;
        }
        public List<CanBoNangLuongVM> GetListCanBoNangLuong()
        {
            
            List<CanBoNangLuongVM> lts = new List<CanBoNangLuongVM>();
            using (SqlConnection con = new SqlConnection(config.Value.myconn.ToString()))
            {
                var DenNgay = DateTime.Now;
                con.Open();
                SqlCommand cmd = new SqlCommand("DS_CBNL", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 90;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                CanBoNangLuongVM obj;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        obj = new CanBoNangLuongVM();
                        obj.ID = dt.Rows[i]["ID"].ToString().Equals("") ? 0 : int.Parse(dt.Rows[i]["ID"].ToString());
                        obj.HoTen = dt.Rows[i]["HoTen"].ToString();
                        obj.TenDonVi = dt.Rows[i]["TenDonVi"].ToString();
                        obj.NgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString()).ToString("dd/MM/yyyy");
                        obj.GioiTinh = dt.Rows[i]["GioiTinh"].ToString().Equals("1") ? "Nam" : (dt.Rows[i]["GioiTinh"].ToString().Equals("0") ? "Nữ" : "");
                        obj.MaNgach = dt.Rows[i]["MaNgach"].ToString();
                        obj.TenNgach = dt.Rows[i]["TenNgach"].ToString();
                        obj.BacLuong = dt.Rows[i]["BacLuong"].ToString();
                        obj.HeSo = dt.Rows[i]["HeSo"].ToString();
                        obj.NgayKetThuc = DateTime.Parse(dt.Rows[i]["NgayKetThuc"].ToString()).ToString("dd/MM/yyyy");
                        lts.Add(obj);
                    }
                }
                return lts;
            }
        }
        public List<CanBoSapHetHanChucVuVM> GetListCanBoSapHetHanChucVu()
        {
            List<CanBoSapHetHanChucVuVM> lts = new List<CanBoSapHetHanChucVuVM>();
            using (SqlConnection con = new SqlConnection(config.Value.myconn.ToString()))
            {
                var DenNgay = DateTime.Now;
                con.Open();

                SqlCommand cmd = new SqlCommand("DS_CBSHHCV", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 90;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                CanBoSapHetHanChucVuVM obj;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        obj = new CanBoSapHetHanChucVuVM();
                        obj.ID = dt.Rows[i]["ID"].ToString().Equals("") ? 0 : int.Parse(dt.Rows[i]["ID"].ToString());
                        obj.HoTen = dt.Rows[i]["HoTen"].ToString();
                        obj.TenDonVi = dt.Rows[i]["TenDonVi"].ToString();
                        obj.NgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString()).ToString("dd/MM/yyyy");
                        obj.GioiTinh = dt.Rows[i]["GioiTinh"].ToString().Equals("1") ? "Nam" : (dt.Rows[i]["GioiTinh"].ToString().Equals("0") ? "Nữ" : "");
                        obj.NgayBoNhiem = DateTime.Parse(dt.Rows[i]["NgayBoNhiem"].ToString()).ToString("dd/MM/yyyy");
                        obj.NgayHetHan = DateTime.Parse(dt.Rows[i]["NgayHetHan"].ToString()).ToString("dd/MM/yyyy");
                        lts.Add(obj);
                    }
                }
                return lts;
            }
        }
    }
}
