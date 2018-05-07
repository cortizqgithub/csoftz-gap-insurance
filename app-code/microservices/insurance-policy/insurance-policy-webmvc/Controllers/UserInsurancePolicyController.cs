/*----------------------------------------------------------------------------*/
/* Source File:   USERINSURANCEPOLICYCONTROLLER.CS                            */
/* Description:   Controller to administer linking Insurance Policies to Users*/
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          May.07/2018                                                 */
/* Last Modified: May.07/2018                                                 */
/* Version:       1.1                                                         */
/* Copyright (c), 2018 CSoftZ.                                                */
/*----------------------------------------------------------------------------*/
/*-----------------------------------------------------------------------------
 History
 May.07/2018 COQ  File created.
 -----------------------------------------------------------------------------*/
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Insurance.Policy.Web.Controllers
{
    /// <summary>
    /// Controller to administer linking Insurance Policies to Users
    /// </summary>
    public class UserController : Controller
    {
        /// <summary>
        /// Shows the Index Page for User Insurance Policy Assets.
        /// </summary>
        /// <returns>The Index page for User Insurance Policy</returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}