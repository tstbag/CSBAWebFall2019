﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using CSBA.BusinessLogicLayer;
using CSBA.DomainModels;

namespace CSBA.Account
{
    public partial class Login : System.Web.UI.Page
    {
        aspnet_UsersBusinessLogic aspUserBLL = new aspnet_UsersBusinessLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string uname = Login1.UserName.ToString();
            string pass = Login1.Password.ToString();
            if (Membership.ValidateUser(uname, pass))
            {
                aspnet_UsersDomainModel aspUser = aspUserBLL.ListAspUser(uname.Trim());
                Session["UserID_GUID"] = aspUser.UserId;

                if (Request.QueryString["ReturnUrl"] != null)
                {
                    FormsAuthentication.RedirectFromLoginPage(uname, false);
                }
                else
                {
                    FormsAuthentication.SetAuthCookie(uname, false);                    
                    Response.Redirect("~/Default.aspx");
                }
            }
            else
            {
                Response.Write("Invalid Login");
            }
        }
    }
}