/*----------------------------------------------------------------------------*/
/* Source File:   INSURANCEPOLICYREPOSITORY.CS                                */
/* Description:   Implementation Service to handle access to database objects */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          May.04/2018                                                 */
/* Last Modified: May.05/2018                                                 */
/* Version:       1.1                                                         */
/* Copyright (c), 2018 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/

/*-----------------------------------------------------------------------------
 History
 May.04/2018 COQ  File created.
 -----------------------------------------------------------------------------*/
using System.Collections.Generic;
using Insurance.Policy.Api.Entities;
using Insurance.Policy.Api.Repository.Interfaces;
using Dapper;
using Npgsql;

namespace Insurance.Policy.Api.Repository
{
    /// <summary>
    /// Implementation Service to handle access to database objects
    /// </summary>
    public class InsurancePolicyRepository : IInsurancePolicyRepository
    {
        private string connectionString;

        public InsurancePolicyRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<InsurancePolicyEntity> GetAll()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                return connection.Query<InsurancePolicyEntity>("select * from InsurancePolicy;");
            }
        }
    }
}
