/*----------------------------------------------------------------------------*/
/* Source File:   IRISKTYPESERVICE.CS                                         */
/* Description:   Interface to handle Risk Type Entities                      */
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
using Insurance.Policy.Api.Domain;

namespace Insurance.Policy.Api.Services.Interfaces
{
    /// <summary>
    /// Interface to handle Risk Type Entities
    /// </summary>
    public interface IRiskTypeService
    {
        /// <summary>
        /// Gets all records in Insurance Risk Type Table.
        /// </summary>
        /// <returns>List of existing records</returns>
        List<RiskType> GetAll();
    }
}
