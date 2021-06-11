using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyNhaHang
{
    public class FoodDAO
    {
        private  FoodDAO() { }
        private static FoodDAO instance;
        public static FoodDAO Instance
        {
            get
            {
                if (instance == null) instance = new FoodDAO();
                return instance;
            }
        }
        public DataTable LoadFood()
        {
            DataTable data = new DataTable();
            string query = "select MATHUCAN as N'Mã thức ăn',TENTHUCAN as N'Tên thức ăn'," +
                "GIA as N'Giá',THUCAN.MALOAI as N'Mã loại',TENLOAI as N'Tên loại' " +
                "from THUCAN,LOAITHUCAN " +
              "where THUCAN.MALOAI = LOAITHUCAN.MALOAI";
            data=DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public bool InsertFood( string tenthucan, int gia, int maloai)
        {
            string query = "Insert into THUCAN(TENTHUCAN,GIA,MALOAI)"
                + "values (N'" + tenthucan + "'," + gia + "," + maloai + ")";
            int x = DataProvider.Instance.ExecuteNonQuery(query);
            if (x > 0) return true;
            return false;
        }
        public bool UpdateFood(int mathucan,string tenthucan,int gia,int maloai)
        {
            string query = "Update THUCAN "
                + "set TENTHUCAN=N'" + tenthucan + "',GIA=" + gia
                + ",MALOAI=" + maloai + "where MATHUCAN=" + mathucan;
            int x = DataProvider.Instance.ExecuteNonQuery(query);
                if (x > 0) return true;
            return false;
        }
        public bool  DeleteFood(int mathucan)
        {
            string query = "Delete from THUCAN where mathucan=" + mathucan;
            int x = DataProvider.Instance.ExecuteNonQuery(query);
                if (x > 0) return true;
            return false;
        }
        public List<Food> GetFoodByCategoryID(int maloai)
        {
            List<Food> list = new List<Food>();

            string query = "select * from THUCAN where MALOAI = " + maloai ;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }
        public DataTable SearchFoodByName(string tenthucan)
        {
            string query = "Select MATHUCAN as N'Mã thức ăn',TENTHUCAN as N'Tên thức ăn'," +
                "GIA as N'Giá',THUCAN.MALOAI as N'Mã loại',TENLOAI as N'Tên loại'" +
                " from THUCAN,LOAITHUCAN where TENTHUCAN like N'%" + tenthucan + "%' " +
                "and THUCAN.MALOAI=LOAITHUCAN.MALOAI";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;

        }
        public int GetMaxIdFood()
        {
            string query = "select max(MATHUCAN) from THUCAN";
            //tra ve gia tri lon nhat cua ma thuc an
            int x = DataProvider.Instance.ExecuteScalar(query);
            return x;

        }
            
    }
}
