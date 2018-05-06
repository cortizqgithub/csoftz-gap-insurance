/*----------------------------------------------------------------------------*/
/* Source File:   COVERAGETYPEREPOSITORY.CS                                   */
/* Description:   Implementation Service to handle access to database         */
/*                (Coverage Type).                                            */
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
    /// Implementation Service to handle access to database (Coverage Type). 
    /// </summary>
    public class CoverageTypeRepository : ICoverageTypeRepository
    {
        private string connectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Repository.CoverageTypeRepository"/> class.
        /// </summary>
        /// <param name="connectionString">Configuration to connect to database.</param>
        public CoverageTypeRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Gets all records in Insurance Coverage Type Table.
        /// </summary>
        /// <returns>List of existing records</returns>
        public List<CoverageType> GetAll()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                return connection.Query<CoverageType>(GlobalConstants.COVERAGE_TYPE_GET_ALL).ToList(); ;
            }
        }
    }
}
