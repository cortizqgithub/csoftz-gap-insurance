/*----------------------------------------------------------------------------*/
/* Source File:   COVERAGETYPECONTROLLER.CS                                   */
/* Description:   REST API Controller for Coverage Type Domain Objects        */
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
    /// REST API Controller for Coverage Type Domain Objects.
    /// </summary>
    [Route("insurance/api/v1/[controller]")]
    public class CoverageTypeController : Controller
    {
        private ICoverageTypeService coverageTypeService;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Controllers.CoverageTypeController"/> class.
        /// </summary>
        /// <param name="coverageTypeService">Injects an instance to a Coverage type service.</param>
        public CoverageTypeController(ICoverageTypeService coverageTypeService) 
        {
            this.coverageTypeService = coverageTypeService;
        }

        /// <summary>
        /// Responds to the URL: GET /insurance/api/v1/coveragetype/all
        /// Retrieves all records.
        /// </summary>
        /// <returns>A list of all Coverage Type</returns>
        [HttpGet]
        public List<CoverageType> GetAll()
        {
            return coverageTypeService.GetAll();
        }
    }
}
