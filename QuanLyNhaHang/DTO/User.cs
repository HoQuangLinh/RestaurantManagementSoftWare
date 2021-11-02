using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
   public class User
    {
        string username;
        string password;
        bool isAdmin;
       public User(string username, string password,bool isAdmin)
        {
            this.username = username;
            this.password = password;
            this.isAdmin = isAdmin;
        }
        public User(string username,string password)
        {
            this.username = username;
            this.password = password;
        }
        public static bool IsValidateUserName(string username)
        {
            if (CheckVietKey(username) == true)
            {
                return false;
            }
            if (string.IsNullOrEmpty(username))
            {
                return false;
            }
            if (username.Length > 100)
            {
                return false;
            }
            return true;

        }

        public static bool CheckVietKey(string chuCoDau)
        {
            const string FindText = "áàảãạâấầẩẫậăắằẳẵặđéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵÁÀẢÃẠÂẤẦẨẪẬĂẮẰẲẴẶĐÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴ";
            int n;
            int m = chuCoDau.Length;
            char[] arrS = chuCoDau.ToCharArray();
            for (int i = 0; i < m; i++)
            {
                n = FindText.IndexOf(arrS[i]);
                if (n != -1) return true;  //Tìm thấy kí tự có dấu trong dãy FindText
            }
            return false;    //Không tìm thấy kí tự có dấu
        }




        public static bool IsValidatePassWord(string password) {
            if (String.IsNullOrEmpty(password)){
                return false;
            }
            if (password.Length > 100)
            {
                return false;
            }
            return true;
        }
        public static bool IsValidateUser(string username,string password,bool isAdmin) 
        {
            if (username != "admin" && isAdmin == true)
            {
                return false;
            }
            if (username == "admin" && isAdmin == false)
            {
                return false;
            }
            if (IsValidatePassWord(password) == false)
            {
                return false;
            }
            if (IsValidateUserName(username) == false)
            {
                return false;
            }
           
            
            return true;
        }
    }
}
