using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AzureDemo
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sReturnCode;
                string sReturnMsg;
                Label1.Text = ClassLibrary.Class1.Sum(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text), out sReturnCode, out sReturnMsg).ToString();
            }
            catch
            {

            }
        }
    }
}