using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using QLCBCore.Models.ThongKe;
using QLCBCore.ViewModels;

namespace QLCBCore.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly IOptions<ConnectionString> config;
        public HomeController(IOptions<ConnectionString> config)
        {
            this.config = config;
        }

        public IActionResult Index()
        {
            Home mymodel = new Home();
            mymodel.Genders = CountGender();
            mymodel.LevelUsers = CountLevelUser();
            mymodel.ClusterUsers = CountCluster();
            return View(mymodel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public Gender CountGender()
        {
            Gender lts = new Gender();
            using (SqlConnection con = new SqlConnection(config.Value.myconn.ToString()))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("Home_ChartGender", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 90;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                Gender obj;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        obj = new Gender();
                        obj.TongSo = dt.Rows[i]["TongSo"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["TongSo"].ToString()); ;
                        obj.Nam = dt.Rows[i]["TongSoNam"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["TongSoNam"].ToString()); ;
                        obj.Nu = obj.TongSo - obj.Nam;
                        lts = obj;
                    }
                }
                return lts;
            }
        }

        public ClusterUser CountCluster()
        {
            ClusterUser lts = new ClusterUser();
            using (SqlConnection con = new SqlConnection(config.Value.myconn.ToString()))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("Home_ChartClusterUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 90;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                ClusterUser obj;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        obj = new ClusterUser();
                        obj.TongSo = dt.Rows[i]["TongSo"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["TongSo"].ToString()); ;
                        obj.CongChuc = dt.Rows[i]["CongChuc"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["CongChuc"].ToString()); ;
                        obj.VienChuc = dt.Rows[i]["VienChuc"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["VienChuc"].ToString()); ;
                        obj.HopDong = dt.Rows[i]["HopDong"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["HopDong"].ToString()); ;
                        obj.HopDong68 = dt.Rows[i]["HopDong68"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["HopDong68"].ToString()); ;
                        lts = obj;
                    }
                }
                return lts;
            }
        }

        public LevelUser CountLevelUser()
        {
            LevelUser lts = new LevelUser();
            using (SqlConnection con = new SqlConnection(config.Value.myconn.ToString()))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("Home_ChartLevelUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 90;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                LevelUser obj;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        obj = new LevelUser();
                        obj.TongSo = dt.Rows[i]["TongSo"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["TongSo"].ToString()); ;
                        obj.TienSy = dt.Rows[i]["TienSy"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["TienSy"].ToString()); ;
                        obj.ThacSy = dt.Rows[i]["ThacSy"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["ThacSy"].ToString()); ;
                        obj.DaiHoc = dt.Rows[i]["DaiHoc"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["DaiHoc"].ToString()); ;
                        obj.CuNhan = dt.Rows[i]["CuNhan"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["CuNhan"].ToString()); ;
                        obj.CaoDang = dt.Rows[i]["CaoDang"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["CaoDang"].ToString()); ;
                        obj.TrungCap = dt.Rows[i]["TrungCap"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["TrungCap"].ToString()); ;
                        obj.Khac = dt.Rows[i]["Khac"].ToString().Equals("") ? (int?)null : int.Parse(dt.Rows[i]["Khac"].ToString()); ;
                        lts = obj;
                    }
                }
                return lts;
            }
        }
    }
}
