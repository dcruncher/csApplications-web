﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Class1.checkLogin(TextBox1.Text,TextBox2.Text))
            {
                Response.Redirect("WebForm2.aspx?user="+TextBox1.Text);
            }
            else
            {
                Response.Write("Invalid usename or password");
            }
        }

       
    }
}