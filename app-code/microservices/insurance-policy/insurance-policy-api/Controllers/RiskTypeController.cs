/*----------------------------------------------------------------------------*/
/* Source File:   RISKTYPECONTROLLER.CS                                       */
/* Description:   REST API Controller for Risk Type Domain Objects            */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          May.06/2018                                                 */
/* Last Modified: May.06/2018                                                 */
/* Version:       1.1                                                         */
/* Copyright (c), 2018 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/

/*-----------------------------------------------------------------------------
 History
 May.06/2018 COQ  File created.
 -----------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using Insurance.Policy.Api.Domain;
using Insurance.Policy.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Insurance.Policy.Api.Controllers
{
    /// <summary>
    /// REST API Controller for Risk Type Domain Objects
    /// </summary>
    [Route("insurance/api/v1/[controller]")]
    public class RiskTypeController : Controller
    {
        private IRiskTypeService riskTypeService;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Controllers.RiskTypeController"/> class.
        /// </summary>
        /// <param name="riskTypeService">Injects an instance to Risk type service.</param>
        public RiskTypeController(IRiskTypeService riskTypeService)
        {
            this.riskTypeService = riskTypeService;
        }

        /// <summary>
        /// Responds to the URL: GET /insurance/api/v1/risktype/all
        /// Retrieves all records.
        /// </summary>
        /// <returns>A list of all Coverage Type</returns>
        [HttpGet]
        public List<RiskType> GetAll()
        {
            return riskTypeService.GetAll();
        }
    }
}
