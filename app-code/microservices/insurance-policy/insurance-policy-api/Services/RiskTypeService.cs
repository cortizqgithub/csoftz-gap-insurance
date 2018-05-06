/*----------------------------------------------------------------------------*/
/* Source File:   RISKTYPESERVICE.CS                                          */
/* Description:   Implementation Service to handle Risk Type Entities         */
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
using Insurance.Policy.Api.Repository.Interfaces;
using Insurance.Policy.Api.Services.Interfaces;

namespace Insurance.Policy.Api.Services
{
    /// <summary>
    /// Implementation Service to handle Risk Type Entities
    /// </summary>
    public class RiskTypeService : IRiskTypeService
    {
        private IRiskTypeRepository riskTypeRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Services.RiskTypeService"/> class.
        /// </summary>
        /// <param name="riskTypeRepository">Injects an instance of a Risk Type repository.</param>
        public RiskTypeService(IRiskTypeRepository riskTypeRepository)
        {
            this.riskTypeRepository = riskTypeRepository;
        }

        /// <summary>
        /// Gets all records in Insurance Risk Type Table.
        /// </summary>
        /// <returns>List of existing records</returns>
        public List<RiskType> GetAll()
        {
            return this.riskTypeRepository.GetAll();
        }
    }
}
