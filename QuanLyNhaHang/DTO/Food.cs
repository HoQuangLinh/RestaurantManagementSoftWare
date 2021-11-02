using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyNhaHang
{
    public class Food
    {
        private int mathucan;
        private int gia;     
        private int maloai;
        private string tenthucan;
        public Food(string mathucan,string gia,string maloai,string tenthucan)
        {
            try
            {
                this.mathucan = Convert.ToInt32(mathucan);
                this.maloai = Convert.ToInt32(maloai);
                this.gia = Convert.ToInt32(gia);
                this.tenthucan = tenthucan;

            }
            catch(FormatException ex)
            {
              
              
            }
        }
        public Food(DataRow row)
        {
            mathucan =(int) row["MATHUCAN"];
            gia = (int)row["GIA"];
            tenthucan = (string)row["TENTHUCAN"];
            maloai = (int)row["MALOAI"];
        }
        public Food(int mathucan,int gia,string tenthucan,int maloai)
        {
            this.mathucan= mathucan;
            this.gia= gia;
            this.tenthucan= tenthucan;
            this.maloai=maloai;
        }
       public Food() { }
        public int Mathucan { get => mathucan; set => mathucan = value; }
        public int Gia { get => gia; set => gia = value; }
        public string Tenthucan { get => tenthucan; set => tenthucan = value; }
        public int Maloai { get => maloai; set => maloai = value; }
        public static bool IsValidateInsertFood(string mathucan, string gia , string maloai, string tenthucan)
        {
            if (String.IsNullOrEmpty(mathucan) || String.IsNullOrEmpty(tenthucan)
               || String.IsNullOrEmpty(maloai) || String.IsNullOrEmpty(gia))
            {
                return false;
            }

            if (tenthucan.Length > 100)
            {
                return false;
            }

            try
            {

                if (Int32.Parse(mathucan) < 0 || Int32.Parse(maloai) < 0 || Int32.Parse(gia) < 0)
                {
                    return false;
                }
               
                return true;
            }
            catch (FormatException e)
            {
                return false;
            }
        }
        public bool CompareFood(Food food)
        {
            if (mathucan ==food.mathucan &&
                gia == food.gia && maloai==food.maloai
                && tenthucan == food.tenthucan )
            {
                return true;
            }
            return false;
        }
        
        public static Food ValidateUpdateFood(string mathucan, string gia, string maloai, string tenthucan)
        {
            if ( String.IsNullOrEmpty(mathucan)||String.IsNullOrEmpty(tenthucan)
               || String.IsNullOrEmpty(maloai) || String.IsNullOrEmpty(gia))
            {
                return null;
            }

            if (tenthucan.Length > 100)
            {
                return null;
            }

            try
            {
                 
                if (Int32.Parse(mathucan) < 0|| Int32.Parse(maloai)<0 ||Int32.Parse(gia) < 0)
                {
                    return null;
                }

                return new Food() {
                    mathucan = Int32.Parse(mathucan),
                    gia = Int32.Parse(gia),
                    maloai = Int32.Parse(maloai),
                    tenthucan = tenthucan
                };
            }
            catch (FormatException e)
            {
                return null;
            }



        }
        public static bool ValidateDeleteFood(List<Food> foods, string mathucan)
        {
           
            try
            {
                int index = foods.FindIndex(food => food.mathucan == Convert.ToInt32(mathucan));

                if (index == -1)
                {
                    return false;
                }
                return true;
            }
            catch(FormatException e)
            {
                return false;
            }
            
        }

    }
}
