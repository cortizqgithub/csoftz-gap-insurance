/*----------------------------------------------------------------------------*/
/* Source File:   HOMECONTROLLER.CS                                           */
/* Description:   Controller for HOME assets.                                 */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          May.06/2018                                                 */
/* Last Modified: May.07/2018                                                 */
/* Version:       1.1                                                         */
/* Copyright (c), 2018 CSoftZ.                                                */
/*----------------------------------------------------------------------------*/
/*-----------------------------------------------------------------------------
 History
 May.06/2018 COQ  File created.
 -----------------------------------------------------------------------------*/
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Insurance.Policy.Web.Models;

namespace Insurance.Policy.Web.Controllers
{
    /// <summary>
    /// Controller for HOME assets.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Show the home page.
        /// </summary>
        /// <returns>The index.</returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Show the About page.
        /// </summary>
        /// <returns>The about.</returns>
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        /// <summary>
        /// Show the Contact page.
        /// </summary>
        /// <returns>The contact.</returns>
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        /// <summary>
        /// Show the Error page.
        /// </summary>
        /// <returns>The error.</returns>
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
