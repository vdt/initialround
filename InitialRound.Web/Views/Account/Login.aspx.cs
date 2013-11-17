﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InitialRound.BusinessLogic.Controllers;
using InitialRound.BusinessLogic;
using InitialRound.BusinessLogic.Exceptions;
using InitialRound.BusinessLogic.Classes;
using InitialRound.BusinessLogic.Helpers;
using InitialRound.Web.Classes;

namespace InitialRound.Web.Views.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UserController.ClearAuthCookies(Request, Response);
            }
        }
    }
}