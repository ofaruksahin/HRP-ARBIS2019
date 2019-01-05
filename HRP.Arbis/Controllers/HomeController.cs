﻿using HRP.Arbis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HRP.Arbis.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {
        public async Task<ActionResult> Index()
        {           
            if (User.Identity.IsAuthenticated)
            {
                var user = await UserManager.FindByEmailAsync(User.Identity.Name);
                if (user != null)
                {
                    var roles = await UserManager.GetRolesAsync(user.Id);
                    if (roles.FirstOrDefault() == "Normal Kullanıcı")
                        return RedirectToAction("Index", "Handshake");
                    else
                        return RedirectToAction("Index", "Server");
                }               
            }
            return View();
        }     
        public ActionResult Error()
        {
            return View();
        }
    }
}