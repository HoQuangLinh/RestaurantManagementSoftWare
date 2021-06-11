
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    public class FoodCategoryDAO
    {
        private FoodCategoryDAO() { }
        private static FoodCategoryDAO instance;
        public static FoodCategoryDAO Instance
        {
            get
            {
                if (instance == null) instance = new FoodCategoryDAO();
                return instance;
            }
        }
        public bool InsertFoodCateGory(string TenLoai)
        {
            string query = "USP_InsertFoodCategory @TenLoai";

            int x=DataProvider.Instance.ExecuteNonQuery(query,new object[] {TenLoai });
            if (x > 0) return true;
            return false;
        }
        public bool DeleteFoodCategory(string TenLoai)
        {
            string query = "Delete from LOAITHUCAN where TENLOAI =N'" + TenLoai + "'"; 
            int x = DataProvider.Instance.ExecuteNonQuery(query);
            if (x > 0) return true;
            return false;
                    
        }
        public List<FoodCategory> GetListFoodCategories()
        {
            string query = "Select *from LOAITHUCAN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<FoodCategory> categories = new List<FoodCategory>();
            foreach(DataRow i in data.Rows)
            {
                FoodCategory category = new FoodCategory(i);
                categories.Add(category);

            }
            return categories;
        }

       public bool UpdateFoodCateGory(string TenMoi,string TenCu)
        {
            string query = "USP_UpdateFoodCategory @TenMoi , @TenCu";
            int result = DataProvider.Instance.ExecuteNonQuery(
                                                  query, new object[] { TenMoi, TenCu });
            if (result > 0) return true;
            return false;
        }
        public DataTable LoadFoodCategory()
        {
            DataTable data = new DataTable();
            data=DataProvider.Instance.ExecuteQuery("Select MALOAI as N'Mã loại'" +
                ",TENLOAI as N'Tên loại 'from LOAITHUCAN");
            return data;
        }
        public int GetIdByNameFoodCategory(string tenloai)
        {
            int maloai =-1; 
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery
                ("Select MALOAI From LOAITHUCAN where TENLOAI=N'" + tenloai+"'");
            try
            {
                maloai = (int)data.Rows[0][0];
                return maloai;
            }
           catch
            {
                return -1;
            }
               
        }
      
    }
}
