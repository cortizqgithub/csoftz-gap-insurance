/*----------------------------------------------------------------------------*/
/* Source File:   USERCONTROLLER.CS                                           */
/* Description:   REST API Controller for User Domain Objects                 */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          May.07/2018                                                 */
/* Last Modified: May.07/2018                                                 */
/* Version:       1.1                                                         */
/* Copyright (c), 2018 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/

/*-----------------------------------------------------------------------------
 History
 May.07/2018 COQ  File created.
 -----------------------------------------------------------------------------*/
using System.Collections.Generic;
using Insurance.Policy.Api.Domain;
using Insurance.Policy.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Insurance.Policy.Api.Controllers
{
    /// <summary>
    /// REST API Controller for User Domain Objects
    /// </summary>
    [Route("insurance/api/v1/[controller]")]
    public class UserController : Controller
    {
        private IUserService userService;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Controllers.UserController"/> class.
        /// </summary>
        /// <param name="userService">Injects an instance to User service.</param>
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        /// <summary>
        /// Responds to the URL: GET /insurance/api/v1/user/all
        /// Retrieves all records.
        /// </summary>
        /// <returns>A list of all User</returns>
        [HttpGet("all")]
        public List<User> GetAll()
        {
            return userService.GetAll();
        }
    }
}
