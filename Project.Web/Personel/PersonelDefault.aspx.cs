﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Web.Personel
{
    public partial class PersonelDefault : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            this.MasterPageFile = "~/MainMasterPage.Master";

            if (Session["role"] == null)
            {
                this.MasterPageFile = "~/Unauthorized.Master";
            }

            else if (Session["role"].Equals(1))
            {
                this.MasterPageFile = "~/MainMasterPage.Master";
            }
            else
            {
                this.MasterPageFile = "~/Unauthorized.Master";
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void myGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                int id = Convert.ToInt32(e.CommandArgument);

                // delete from tblcountry where countryid="+id+";

            }
        }

        protected void btnNewPer_Click(object sender, EventArgs e)
        {
            Response.Redirect("PersonelEkle.aspx");
        }
    }
}