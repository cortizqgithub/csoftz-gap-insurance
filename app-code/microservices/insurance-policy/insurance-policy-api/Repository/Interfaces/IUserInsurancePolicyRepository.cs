/*----------------------------------------------------------------------------*/
/* Source File:   USERINSURANCEPOLICYREPOSITORY.CS                            */
/* Description:   Interface to handle access to database (User Insurance Policy)*/
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

namespace Insurance.Policy.Api.Repository.Interfaces
{
    /// <summary>
    /// Interface to handle access to database (User Insurance Policy)
    /// </summary>
    public interface IUserInsurancePolicyRepository
    {
        /// <summary>
        /// Gets all records in User Insurance Policy Table.
        /// </summary>
        /// <returns>List of existing records</returns>
        List<UserInsurancePolicy> GetAll();

        /// <summary>
        /// Gets all records in User Insurance Policty Table filterd
        /// by UserId.
        /// </summary>
        /// <returns>List of existing records with search criteria.</returns>
        /// <param name="userId">User identifier.</param>
        List<UserInsurancePolicy> GetAllByUser(long userId);
    }
}
