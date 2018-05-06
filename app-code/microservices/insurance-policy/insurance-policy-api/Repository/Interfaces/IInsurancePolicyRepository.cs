/*----------------------------------------------------------------------------*/
/* Source File:   IINSURANCEPOLICYREPOSITORY.CS                               */
/* Description:   Interface to handle access to database (Insurance Policy)   */
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

namespace Insurance.Policy.Api.Repository.Interfaces
{
    /// <summary>
    /// Interface to handle access to database (Insurance Policy)
    /// </summary>
    public interface IInsurancePolicyRepository
    {

        /// <summary>
        /// Gets all records in InsurancePolicy Table.
        /// </summary>
        /// <returns>List of existing records</returns>
        List<InsurancePolicyView> GetAll();

        /// <summary>
        /// Finds a record by its identifier.
        /// </summary>
        /// <returns>The requested record else NULL</returns>
        /// <param name="id">Identifier.</param>
        InsurancePolicy FindById(int id);

        /// <summary>
        /// Inserts a new record to database storage.
        /// </summary>
        /// <returns>Count</returns>
        /// <param name="info">Information to be stored.</param>
        int Save(InsurancePolicy info);

        /// <summary>
        /// Update the specified info.
        /// </summary>
        /// <returns>Affected rows</returns>
        /// <param name="info">Information to be changed.</param>
        int Update(InsurancePolicy info);

        /// <summary>
        /// Delete the specified id.
        /// </summary>
        /// <returns>The delete.</returns>
        /// <param name="id">Identifier.</param>
        int Delete(int id);
    }
}
