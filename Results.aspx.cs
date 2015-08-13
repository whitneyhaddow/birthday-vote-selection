using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Results : System.Web.UI.Page
{
    //GET AND DISPLAY VOTING RESULTS
    protected void Page_Load(object sender, EventArgs e)
    {  
        lblDay1.Text = Application["day1Count"].ToString();
        lblDay2.Text = Application["day2Count"].ToString();
        lblDay3.Text = Application["day3Count"].ToString();
    }
}