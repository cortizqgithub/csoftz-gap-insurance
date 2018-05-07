/*----------------------------------------------------------------------------*/
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
using System.Linq;
using Insurance.Policy.Api.Domain;
using Insurance.Policy.Api.Domain.Computed;
using Insurance.Policy.Api.Domain.View;
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
        private IInsurancePolicyService insurancePolicyService;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Controllers.UserInsurancePolicyController"/> class.
        /// </summary>
        /// <param name="userInsurancePolicyService">Injects an instance to User Insurance Policy service.</param>
        public UserInsurancePolicyController(IUserInsurancePolicyService userInsurancePolicyService,
                                             IInsurancePolicyService insurancePolicyService)
        {
            this.userInsurancePolicyService = userInsurancePolicyService;
            this.insurancePolicyService = insurancePolicyService;
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

        /// <summary>
        /// Responds to the URL: GET /insurance/api/v1/user/all
        /// Retrieves all records.
        /// </summary>
        /// <returns>A list of all User InsurancePolicy</returns>
        [HttpGet("all/{id}")]
        public List<UserInsurancePolicyComputed> GetAllByUser(long id)
        {
            List<UserInsurancePolicy> userInsurancePolicyList = this.userInsurancePolicyService.GetAllByUser(id);
            List<InsurancePolicyView> insurancePolicyList = this.insurancePolicyService.GetAll();
            List<UserInsurancePolicyComputed> userInsurancePolicyComputedList =
                insurancePolicyList.Select(e => new UserInsurancePolicyComputed()
                {
                    Id = e.Id,
                    Name = e.Name,
                    Description = e.Description,
                    CoverageType = e.CoverageType,
                    StartDate = e.StartDate,
                    CoveragePeriod = e.CoveragePeriod,
                    Price = e.Price,
                    RiskType = e.RiskType,
                    PolicyName = e.Name,
                    CoverageTypeName = e.CoverageTypeName,
                    RiskTypeName = e.RiskTypeName,
                    Selected = 0,
                    UserId = id
                }).ToList();
            userInsurancePolicyComputedList.ForEach(y =>
            {
                UserInsurancePolicy userInsurancePolicy =
                    userInsurancePolicyList
                        .Where(x => x.UserId == y.UserId &&
                                   x.InsurancePolicyId == y.Id)
                        .FirstOrDefault();
                y.Selected = (userInsurancePolicy != null) ? 1 : 0;
            });
            return userInsurancePolicyComputedList;
        }

        /// <summary>
        /// Links the insurance policies to given user.
        /// </summary>
        /// <returns>The very same ids.</returns>
        /// <param name="userId">User identifier.</param>
        /// <param name="ids">Identifiers for Insurance Policies to set.</param>
        [HttpPost("link/{userId")]
        public string LinkInsurancePolicy(long userId, [FromBody] string ids)
        {
            // TODO: May.07/2018 (no time left as today).
            return ids;
        }

    }
}
