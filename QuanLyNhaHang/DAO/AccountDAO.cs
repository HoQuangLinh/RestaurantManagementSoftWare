using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace QuanLyNhaHang
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }
        public bool Login(string userName, string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            string query = " USP_Login @userName , @passWord  ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, hasPass });
            if (data.Rows.Count > 0) return true;
            else return false;
        }
        public bool InsertAccout(string userName, string passWord)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            string query = "EXEC USP_SIGNUP @USerName , @PassWord ";
            int result = DataProvider.Instance.ExecuteNonQuery(query,
                new object[] { userName, hasPass });
            return result > 0;
        }
        public bool IsExitAccount(string username)
        {
            string query = "Select count(*) from TAIKHOAN " +
                "where UserName='" + username + "'";
            int x = DataProvider.Instance.ExecuteScalar(query);
            if (x > 0) return true;
            return false;
        }
    }
}
