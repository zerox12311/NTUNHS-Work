using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;/*組合想要使用的字串*/

namespace prjIdoitResolver.categorys
{
    public partial class eat : System.Web.UI.Page
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
                        ("SELECT * FROM [Question] WHERE [categoryID] = 1", cn);
                    SqlDataReader drMembers = cmd.ExecuteReader();


                    StringBuilder sb1 = new StringBuilder();//存放主要工作人力






                    /*如果要讀取欄位內容*/
                    while (drMembers.Read())
                    {
                        //sb1.Append("<div class='col-12 col-md-4 mb-4 mb-lg-5'>");
                        //sb1.Append("<a href ='#'>");
                        //sb1.Append("<img src='/assets/custom/images/cat-larg5.jpg' alt='' class='w-100'>");
                        //sb1.Append("</a>");
                        //sb1.Append("<h2 class='font-18 semi-font font-18  mt-3'>");
                        //sb1.Append("<a href='#' class='fables-main-text-color fables-second-hover-color'>" + drMembers["title"].ToString() + "</a>");
                        //sb1.Append("</h2>");
                        //sb1.Append("<p class='fables-forth-text-color font-14'>" + drMembers["content"].ToString() + "</p>");
                        //sb1.Append("<a href='' class='btn fables-main-text-color fables-second-hover-color p-0 underline mt-2'>Read More</a>");
                        //sb1.Append("</div>");

                        sb1.Append(@"
<div class='col-12 col-md-4 mb-4 mb-lg-5'>
<a href ='#'>
    <img src='/assets/custom/images/cat-larg5.jpg' alt='' class='w-100'>
</a>
<h2 class='font-18 semi-font font-18  mt-3'>
    <a href='#' class='fables-main-text-color fables-second-hover-color'>213123</a>
</h2>
<p class='fables-forth-text-color font-14'>testests</p>
<a href='' class='btn fables-main-text-color fables-second-hover-color p-0 underline mt-2'>Read More</a>
</div>
");
                    }

                    Label1.Text = sb1.ToString();
                }
            }
        }
    }
}