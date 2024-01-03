using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise2
{
	public partial class WebForm : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}
		protected void Button1_Click(object sender, EventArgs e)
		{
			WebService webService = new WebService();
			int a = 5;
			int b = 6;
			Label1.Text = "Output of WebService: " + webService.Add(a,b).ToString();
			Label1.Text = "Output of WebService: " + webService.Subtract(a, b).ToString();
			Label1.Text = "Output of WebService: " + webService.Multiply(a, b).ToString();
			Label1.Text = "Output of WebService: " + webService.Divide(a, b).ToString();
		}
	}
}