/*----------------------------------------------------------------------------*/
/* Source File:   INSURANCEPOLICYCONTROLLER.CS                                */
/* Description:   REST API Controller for Insurance Policy Domain Objects     */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          May.05/2018                                                 */
/* Last Modified: May.06/2018                                                 */
/* Version:       1.1                                                         */
/* Copyright (c), 2018 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/

/*-----------------------------------------------------------------------------
 History
 May.05/2018 COQ  File created.
 -----------------------------------------------------------------------------*/
using System.Collections.Generic;
using Insurance.Policy.Api.Domain;
using Insurance.Policy.Api.Domain.View;
using Insurance.Policy.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Insurance.Policy.Api.Controllers
{
    /// <summary>
    /// REST API Controller for Insurance Policy Domain Objects
    /// </summary>
    [Route("insurance/api/v1/[controller]")]
    public class InsurancePolicyController : Controller
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
        /// Responds to the URL: GET /insurance/api/v1/insurancepolicy/all
        /// Retrieves all records.
        /// </summary>
        /// <returns>A list of all Insurance Policy</returns>
        [HttpGet]
        public List<InsurancePolicyView> GetAll()
        {
            return insurancePolicyService.GetAll();
        }

        /// <summary>
        /// Responds to the URL: GET /insurance/api/v1/insurancepolicy/{id}.
        /// Where {id} is a placeholder for the id to look for.
        /// </summary>
        /// <returns>A HTTP Not Found or object found</returns>
        /// <param name="id">Identifier to look up.</param>
        [HttpGet("{id}", Name = "GetInsurancePolicyData")]
        public IActionResult GetById(long id)
        {
            var item = insurancePolicyService.FindById(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        /// <summary>
        /// Responds to the URL: POST /insurance/api/v1/insurancepolicy
        /// Create a record in storage.
        /// </summary>
        /// <returns>The created record and HTTP status created</returns>
        /// <param name="item">Record information to create.</param>
        [HttpPost]
        public IActionResult Create([FromBody] InsurancePolicy item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            insurancePolicyService.Save(item);
            return CreatedAtRoute("GetInsurancePolicyData", new { id = item.Id }, item);
        }

        /// <summary>
        /// Responds to URL: PUT /insurance/api/v1/insurancepolicy/{id}.
        /// Where {id} is a placeholder for the id to look for.
        /// </summary>
        /// <returns>A bad request if parameters are not corrrect.
        /// A not found record or the updated record.
        /// </returns>
        /// <param name="id">Identifier to update.</param>
        /// <param name="item">Record information to update.</param>
        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] InsurancePolicy item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var info = insurancePolicyService.Update(item);
            if (info == 0)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        /// <summary>
        /// Responds to URL: DELETE /insurance/api/v1/insurancepolicy/{id}.
        /// Removes ID from storage.
        /// </summary>
        /// <returns>Not found if ID is not in storage.</returns>
        /// <param name="id">Identifier.</param>
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var info = insurancePolicyService.Delete(id);
            if (info == 0)
            {
                return NotFound();
            }
            return new NoContentResult();
        }
    }
}
