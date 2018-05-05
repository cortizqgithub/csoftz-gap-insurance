/*----------------------------------------------------------------------------*/
/* Source File:   INSURANCEPOLICYCONTROLLER.CS                                */
/* Description:   REST API Controller for Insurance Policy Domain Objects     */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          May.05/2018                                                 */
/* Last Modified: May.05/2018                                                 */
/* Version:       1.1                                                         */
/* Copyright (c), 2018 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/

/*-----------------------------------------------------------------------------
 History
 May.05/2018 COQ  File created.
 -----------------------------------------------------------------------------*/
using Microsoft.AspNetCore.Mvc;
using Insurance.Policy.Api.Services.Interfaces;
using System.Collections.Generic;
using Insurance.Policy.Api.Domain;
using System;

namespace Insurance.Policy.Api.Controllers
{
    /// <summary>
    /// REST API Controller for Insurance Policy Domain Objects
    /// </summary>
    [Route("insurance/api/v1/[controller]")]
    public class InsurancePolicyController
    {
        private IInsurancePolicyService insurancePolicyService;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Controllers.InsurancePolicyController"/> class.
        /// </summary>
        /// <param name="insurancePolicyService">Injects instance to an Insurance policy service.</param>
        public InsurancePolicyController(IInsurancePolicyService insurancePolicyService)
        {
            this.insurancePolicyService = insurancePolicyService;
        }

        /// <summary>
        /// Responds to the URL: GET /userinfo/api/v1/user
        /// Retrieves all records.
        /// </summary>
        /// <returns>A list of all users</returns>
        [HttpGet]
        public List<InsurancePolicy> GetAll()
        {
            var ins = new InsurancePolicy()
            {
                Id = 1,
                Name = "info.Name-",
                Description = "info.Description",
                CoverageType = 1,
                StartDate = DateTime.Now,
                CoveragePeriod = 10,
                Price = 100000,
                RiskType = 1
            };
            insurancePolicyService.Save(ins);

            return insurancePolicyService.GetAll();
        }
    }
}
