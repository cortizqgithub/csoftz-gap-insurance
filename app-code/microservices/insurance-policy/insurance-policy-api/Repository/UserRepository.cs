/*----------------------------------------------------------------------------*/
/* Source File:   USERREPOSITORY.CS                                           */
/* Description:   Implementation Service to handle access to database         */
/*                (User).                                                     */
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

namespace Insurance.Policy.Api.Repository.Interfaces
{
    /// <summary>
    /// Implementation Service to handle access to database  (User).
    /// </summary>
    public class UserRepository : IUserRepository
    {
        private string connectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Repository.Interfaces.UserRepository"/> class.
        /// </summary>
        /// <param name="connectionString">Configuration to connect to database.</param>
        public UserRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Gets all records in Insurance User Table.
        /// </summary>
        /// <returns>List of existing records</returns>
        public List<User> GetAll()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                return connection.Query<User>(GlobalConstants.USER_GET_ALL).ToList(); ;
            }
        }
    }
}
