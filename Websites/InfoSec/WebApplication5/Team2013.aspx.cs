﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Team2013 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void GH_ANTHONY(object sender, EventArgs e)
        {
            Response.Redirect("https://github.com/ViviTurtle");
        }
        protected void GH_JOSH(object sender, EventArgs e)
        {
            Response.Redirect("https://github.com/conceptofproof");
        }
    }
}