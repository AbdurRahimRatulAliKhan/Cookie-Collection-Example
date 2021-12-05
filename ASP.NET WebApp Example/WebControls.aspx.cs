using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_WebApp_Example
{
    public partial class WebControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cookies["computer"].Expires = DateTime.Now.AddDays(-1);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = "";

            if(apple.Checked)
                Response.Cookies["computer"]["apple"] = "Apple";
            if (dell.Checked)
                Response.Cookies["computer"]["dell"] = "Dell";
            if (lenevo.Checked)
                Response.Cookies["computer"]["lenevo"] = "Lenevo";
            if (acer.Checked)
                Response.Cookies["computer"]["acer"] = "Acer";
            if (Sony.Checked)
                Response.Cookies["computer"]["sony"] = "Sony";
            if (wipro.Checked)
                Response.Cookies["computer"]["wipro"] = "Wipro";


            if (Request.Cookies["computer"].Values.ToString() != null)
            {
                if (Request.Cookies["computer"]["apple"] != null)
                    Label2.Text += Request.Cookies["computer"]["apple"] + " ";
                if (Request.Cookies["computer"]["dell"] != null)
                    Label2.Text += Request.Cookies["computer"]["dell"] + " ";
                if (Request.Cookies["computer"]["lenevo"] != null)
                    Label2.Text += Request.Cookies["computer"]["lenevo"] + " ";
                if (Request.Cookies["computer"]["acer"] != null)
                    Label2.Text += Request.Cookies["computer"]["acer"] + " ";
                if (Request.Cookies["computer"]["sony"] != null)
                    Label2.Text += Request.Cookies["computer"]["sony"] + " ";
                if (Request.Cookies["computer"]["wipro"] != null)
                    Label2.Text += Request.Cookies["computer"]["wipro"] + " ";
            }
            else
                Label2.Text = "Please select your choice";
            Response.Cookies["computer"].Expires = DateTime.Now.AddDays(-1);

        }
    }
}