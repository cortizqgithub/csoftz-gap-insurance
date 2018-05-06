/*----------------------------------------------------------------------------*/
/* Source File:   RISKTYPEREPOSITORY.CS                                       */
/* Description:   Implementation Service to handle access to database         */
/*                (Risk Type).                                                */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          May.06/2018                                                 */
/* Last Modified: May.06/2018                                                 */
/* Version:       1.1                                                         */
/* Copyright (c), 2018 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/

/*-----------------------------------------------------------------------------
 History
 May.06/2018 COQ  File created.
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
    /// Implementation Service to handle access to database  (Risk Type).
    /// </summary>
    public class RiskTypeRepository : IRiskTypeRepository
    {
        private string connectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Repository.RiskTypeRepository"/> class.
        /// </summary>
        /// <param name="connectionString">Configuration to connect to database.</param>
        public RiskTypeRepository(string connectionString)
        {
            this.connectionString = connectionString;   
        }

        /// <summary>
        /// Gets all records in Insurance Risk Type Table.
        /// </summary>
        /// <returns>List of existing records</returns>
        public List<RiskType> GetAll()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                return connection.Query<RiskType>(GlobalConstants.RISK_TYPE_GET_ALL).ToList();;
            }
        }
    }
}
