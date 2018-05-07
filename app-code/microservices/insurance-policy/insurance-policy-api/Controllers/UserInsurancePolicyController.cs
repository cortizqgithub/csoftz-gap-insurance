﻿/*----------------------------------------------------------------------------*/
/* Source File:   USERINSURANCEPOLICYCONTROLLER.CS                            */
/* Description:   REST API Controller for User Insurance Policy Domain Objects*/
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
    /// REST API Controller for User Insurance Policy Domain Objects
    /// </summary>
    [Route("insurance/api/v1/[controller]")]
    public class UserInsurancePolicyController : Controller
    {
        private IUserInsurancePolicyService userInsurancePolicyService;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Controllers.UserInsurancePolicyController"/> class.
        /// </summary>
        /// <param name="userInsurancePolicyService">Injects an instance to User Insurance Policy service.</param>
        public UserInsurancePolicyController(IUserInsurancePolicyService userInsurancePolicyService)
        {
            this.userInsurancePolicyService = userInsurancePolicyService;
        }

        /// <summary>
        /// Responds to the URL: GET /insurance/api/v1/user/all
        /// Retrieves all records.
        /// </summary>
        /// <returns>A list of all User InsurancePolicy</returns>
        [HttpGet("all")]
        public List<UserInsurancePolicy> GetAll()
        {
            return this.userInsurancePolicyService.GetAll();
        }
    }
}
