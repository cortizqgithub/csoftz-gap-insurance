/*----------------------------------------------------------------------------*/
/* Source File:   USERSERVICE.CS                                              */
/* Description:   Interface to handle User Entities                           */
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

namespace Insurance.Policy.Api.Services.Interfaces
{
    /// <summary>
    /// Interface to handle User Entities
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Gets all records in Insurance User Table.
        /// </summary>
        /// <returns>List of existing records</returns>
        List<User> GetAll();
    }
}
