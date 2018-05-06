/*----------------------------------------------------------------------------*/
/* Source File:   INSURANCEPOLICYSERVICE.CS                                   */
/* Description:   Implementation Service to handle Insurance Police Entities  */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          May.04/2018                                                 */
/* Last Modified: May.06/2018                                                 */
/* Version:       1.1                                                         */
/* Copyright (c), 2018 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/

/*-----------------------------------------------------------------------------
 History
 May.04/2018 COQ  File created.
 -----------------------------------------------------------------------------*/
using System.Collections.Generic;
using Insurance.Policy.Api.Domain;
using Insurance.Policy.Api.Domain.View;
using Insurance.Policy.Api.Repository.Interfaces;
using Insurance.Policy.Api.Services.Interfaces;

namespace Insurance.Policy.Api.Services
{
    /// <summary>
    /// Implementation Service to handle Insurance Police Entities.
    /// </summary>
    public class InsurancePolicyService : IInsurancePolicyService
    {
        private IInsurancePolicyRepository insurancePolicyRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Services.InsurancePolicyService"/> class.
        /// </summary>
        /// <param name="insurancePolicyRepository">Injects an instance of an Insurance policy repository.</param>
        public InsurancePolicyService(IInsurancePolicyRepository insurancePolicyRepository)
        {
            this.insurancePolicyRepository = insurancePolicyRepository;
        }

        /// <summary>
        /// Gets all records in InsurancePolicy Table.
        /// </summary>
        /// <returns>List of existing records</returns>
        public List<InsurancePolicyView> GetAll()
        {
            return this.insurancePolicyRepository.GetAll();
        }

        /// <summary>
        /// Finds a record by its identifier.
        /// </summary>
        /// <returns>The requested record else NULL</returns>
        /// <param name="id">Identifier.</param>
        public InsurancePolicy FindById(long id)
        {
            return this.insurancePolicyRepository.FindById(id);
        }

        /// <summary>
        /// Inserts a new record to database storage.
        /// </summary>
        /// <returns>Count</returns>
        /// <param name="info">Information to be stored.</param>
        public int Save(InsurancePolicy info)
        {
            return this.insurancePolicyRepository.Save(info);
        }

        /// <summary>
        /// Update the specified info.
        /// </summary>
        /// <returns>Affected rows</returns>
        /// <param name="info">Information to be changed.</param>
        public int Update(InsurancePolicy info) 
        {
            return this.insurancePolicyRepository.Update(info);    
        }

        /// <summary>
        /// Delete the specified id.
        /// </summary>
        /// <returns>The delete.</returns>
        /// <param name="id">Identifier.</param>
        public int Delete(long id)
        {
            return this.insurancePolicyRepository.Delete(id);
        }
    }
}
