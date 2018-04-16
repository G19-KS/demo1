namespace QuanLiKhachSan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Data;
    using System.Data.SqlClient;
    using System.Configuration;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        string strConn;
        SqlConnection sql;
        [Key]
        public int MaKH { get; set; }

        [StringLength(10)]
        public string MaLoaiKhach { get; set; }

        [StringLength(50)]
        public string TenKhach { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        [StringLength(20)]
        public string CMND { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }
        public KhachHang()
        {  }
        public KhachHang(int MaKH,string MaLoaiKhach,string TenKhach,string GioiTinh, string CMND, string DiaChi)
        {
            this.MaKH = MaKH;
            this.MaLoaiKhach = MaLoaiKhach;
            this.TenKhach = TenKhach;
            this.GioiTinh = GioiTinh;
            this.CMND = CMND;
            this.DiaChi = DiaChi;
        }
        public KhachHang[] listKh()
        {
            KhachHang[] dsKh = null;
            strConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            sql = new SqlConnection();
            sql.Open();
            string query = "select * from KhachHang";
            SqlCommand cmd = new SqlCommand(query, sql);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(rd);
            sql.Close();
            dsKh = new KhachHang[data.Rows.Count];
            for (int i = 0; i < data.Rows.Count; i++)
            {
                int MaKH = int.Parse(data.Rows[i][0].ToString());
                string MaLoaiKhach = data.Rows[i][1].ToString();
                string TenKhach = data.Rows[i][2].ToString();
                string GioiTinh = data.Rows[i][3].ToString();
                string CMND = data.Rows[i][4].ToString();
                string DiaChi = data.Rows[i][5].ToString();
                KhachHang kh = new KhachHang(MaKH, MaLoaiKhach, TenKhach, GioiTinh, CMND, DiaChi);
                dsKh[i] = kh;
            }
            return dsKh;
        }
        public KhachHang[] SearchKh(string data)
        {
            KhachHang[] dsKh = null;
            strConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            sql = new SqlConnection(strConn);
            sql.Open();
            string query = "exec searchKH @search";
            SqlCommand cmd = new SqlCommand(query, sql);
            cmd.Parameters.AddWithValue("@search",data);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            sql.Close();
            dsKh = new KhachHang[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int MaKH = int.Parse(dt.Rows[i][0].ToString());
                string MaLoaiKhach = dt.Rows[i][1].ToString();
                string TenKhach = dt.Rows[i][2].ToString();
                string GioiTinh = dt.Rows[i][3].ToString();
                string CMND = dt.Rows[i][4].ToString();
                string DiaChi = dt.Rows[i][5].ToString();
                KhachHang kh = new KhachHang(MaKH, MaLoaiKhach, TenKhach, GioiTinh, CMND, DiaChi);
                dsKh[i] = kh;
            }
            return dsKh;
        }
    }
}
