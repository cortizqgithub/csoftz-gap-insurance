/*----------------------------------------------------------------------------*/
/* Source File:   USERINSURNACEPOLICYREPOSITORY.CS                            */
/* Description:   Implementation Service to handle access to database         */
/*                (User Insurance Policy).                                    */
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
using Dapper;
using Insurance.Policy.Api.Domain;
using Insurance.Policy.Api.Helper.Consts;
using Insurance.Policy.Api.Repository.Interfaces;
using Npgsql;

namespace Insurance.Policy.Api.Repository
{
    /// <summary>
    /// Implementation Service to handle access to database  (User Insurance Policy).
    /// </summary>
    public class UserInsurancePolicyRepository : IUserInsurancePolicyRepository
    {
        private string connectionString;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Insurance.Policy.Api.Repository.UserInsurancePolicyRepository"/> class.
        /// </summary>
        /// <param name="connectionString">Configuration to connect to database.</param>
        public UserInsurancePolicyRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Gets all records in User Insurance Policy Table.
        /// </summary>
        /// <returns>List of existing records</returns>
        public List<UserInsurancePolicy> GetAll()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                return connection.Query<UserInsurancePolicy>(GlobalConstants.USER_INSURANCE_POLICY_GET_ALL).ToList(); ;
            }
        }

        /// <summary>
        /// Gets all records in User Insurance Policty Table filterd
        /// by UserId.
        /// </summary>
        /// <returns>List of existing records with search criteria.</returns>
        /// <param name="userId">User identifier.</param>
        public List<UserInsurancePolicy> GetAllByUser(long userId)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                return connection.Query<UserInsurancePolicy>(GlobalConstants.USER_INSURANCE_POLICY_GET_ALL_USER_ID,
                                                             new
                                                             {
                                                                 Id = userId
                                                             }).ToList();
            }
        }
    }
}
