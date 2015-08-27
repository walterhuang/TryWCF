using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomerManager.WebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CustomerService.CustomerServiceClient proxy = new CustomerService.CustomerServiceClient();
            try
            {
                GridView1.DataSource = proxy.GetCustomerList();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                // TODO: handle exception
            }
            finally
            {
                proxy.Close();
            }
        }
    }
}