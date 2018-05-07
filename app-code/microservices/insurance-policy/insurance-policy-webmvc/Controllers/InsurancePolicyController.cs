/*----------------------------------------------------------------------------*/
/* Source File:   INSURANCEPOLICYCONTROLLER.CS                                */
/* Description:   Controller to administer Insurance Policy assets.           */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          May.06/2018                                                 */
/* Last Modified: May.06/2018                                                 */
/* Version:       1.1                                                         */
/* Copyright (c), 2018 CSoftZ.                                                */
/*----------------------------------------------------------------------------*/
/*-----------------------------------------------------------------------------
 History
 May.06/2018 COQ  File created.
 -----------------------------------------------------------------------------*/
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Insurance.Policy.Web.Controllers
{
    /// <summary>
    /// Controller to administer Insurance Policy assets. 
    /// </summary>
    public class InsurancePolicyController : Controller
    {
        /// <summary>
        /// Shows the Index Page for Insurance Policy Assets.
        /// </summary>
        /// <returns>The Index page for Insurance Policy</returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}
