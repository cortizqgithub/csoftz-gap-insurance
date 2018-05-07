/*----------------------------------------------------------------------------*/
/* Source File:   USERSERVICE.CS                                              */
/* Description:   Implementation Service to handle User Entities              */
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
    /// Implementation Service to handle User Entities
    /// </summary>
    public class UserService : IUserService
    {
        private IUserRepository userRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Services.UserService"/> class.
        /// </summary>
        /// <param name="userRepository">Injects an instance of a User repository.</param>
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        /// <summary>
        /// Gets all records in Insurance User Table.
        /// </summary>
        /// <returns>List of existing records</returns>
        public List<User> GetAll()
        {
            return this.userRepository.GetAll();
        }
    }
}
