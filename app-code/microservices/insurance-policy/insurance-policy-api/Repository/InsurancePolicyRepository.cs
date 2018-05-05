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
using System.Linq;
using Dapper;
using Insurance.Policy.Api.Domain;
using Insurance.Policy.Api.Helper.Consts;
using Insurance.Policy.Api.Repository.Interfaces;
using Npgsql;

namespace Insurance.Policy.Api.Repository
{
    /// <summary>
    /// Implementation Service to handle access to database objects
    /// </summary>
    public class InsurancePolicyRepository : IInsurancePolicyRepository
    {
        private string connectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Repository.InsurancePolicyRepository"/> class.
        /// <param name="connectionString>Configuration to connect to database.</param>
        /// </summary>
        public InsurancePolicyRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Gets all records in InsurancePolicy Table.
        /// </summary>
        /// <returns>List of existing records</returns>
        public List<InsurancePolicy> GetAll()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                return connection.Query<InsurancePolicy>(GlobalConstants.INSURANCE_POLICY_GET_ALL).ToList();
            }
        }

        /// <summary>
        /// Finds a record by its identifier.
        /// </summary>
        /// <returns>The requested record else NULL</returns>
        /// <param name="id">Identifier.</param>
        public InsurancePolicy FindById(int id)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                List<InsurancePolicy> insurancePolicyList = connection.Query<InsurancePolicy>(GlobalConstants.INSURANCE_POLICY_FIND_BY_ID, new { Id = id }).ToList();

                return insurancePolicyList.FirstOrDefault<InsurancePolicy>();
            }
        }

        /// <summary>
        /// Inserts a new record to database storage.
        /// </summary>
        /// <returns>Count</returns>
        /// <param name="info">Information to be stored.</param>
        public int Save(InsurancePolicy info)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                int rowsAffected = connection.Execute(GlobalConstants.INSURANCE_POLICY_SAVE,
                                                  new
                                                  {
                                                      Id = info.Id,
                                                      Name = info.Name,
                                                      Description = info.Description,
                                                      CoverageType = info.CoverageType,
                                                      StartDate = info.StartDate,
                                                      CoveragePeriod = info.CoveragePeriod,
                                                      Price = info.Price,
                                                      RiskType = info.RiskType
                                                  });

                return rowsAffected;
            }
        }
    }
}
