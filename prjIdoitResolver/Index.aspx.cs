using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Text;/*組合想要使用的字串*/

namespace prjIdoitResolver
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)/*如果是第一次連到這一頁*/
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["LeeLabDB"].ConnectionString;
                    cn.Open();
                    SqlCommand cmd = new SqlCommand
                        ("SELECT * FROM [Category]", cn);
                    SqlDataReader drMembers = cmd.ExecuteReader();


                    StringBuilder sb1 = new StringBuilder();//存放主要工作人力

                    /*如果要讀取欄位內容*/
                    while (drMembers.Read()) { 
                        sb1.Append("<li class='two columns'>");
                        sb1.Append("<p style='text-align:center;'>" + drMembers["categoryName"].ToString()  +"</p>");
                        sb1.Append("</li>");
                    }

                    Label1.Text = sb1.ToString();
                }
            }
        }

    }
}