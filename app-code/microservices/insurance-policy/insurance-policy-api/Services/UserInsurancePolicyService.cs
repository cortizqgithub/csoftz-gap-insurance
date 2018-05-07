/*----------------------------------------------------------------------------*/
/* Source File:   USERINSURANCEPOLICYSERVICE.CS                               */
/* Description:   Implementation Service to handle User Insurance Policy      */
/*                Entities                                                    */
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
using Insurance.Policy.Api.Repository.Interfaces;
using Insurance.Policy.Api.Services.Interfaces;

namespace Insurance.Policy.Api.Services
{
    /// <summary>
    /// Implementation Service to handle User Insurance Policy Entities.
    /// </summary>
    public class UserInsurancePolicyService : IUserInsurancePolicyService 
    {
        private IUserInsurancePolicyRepository userInsurancePolicyRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Services.UserInsurancePolicyService"/> class.
        /// </summary>
        /// <param name="userInsurancePolicyRepository">Injects a reference to an User insurance policy repository.</param>
        public UserInsurancePolicyService(IUserInsurancePolicyRepository userInsurancePolicyRepository)
        {
            this.userInsurancePolicyRepository = userInsurancePolicyRepository;
        }

        /// <summary>
        /// Gets all records in User Insurance Policy Table.
        /// </summary>
        /// <returns>List of existing records</returns>
        public List<UserInsurancePolicy> GetAll()
        {
            return this.userInsurancePolicyRepository.GetAll();
        }

        /// <summary>
        /// Gets all records in User Insurance Policty Table filterd
        /// by UserId.
        /// </summary>
        /// <returns>List of existing records with search criteria.</returns>
        /// <param name="userId">User identifier.</param>
        public List<UserInsurancePolicy> GetAllByUser(long userId) 
        {
            return this.userInsurancePolicyRepository.GetAllByUser(userId);
        }
    }
}
