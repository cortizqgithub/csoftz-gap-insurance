/*----------------------------------------------------------------------------*/
/* Source File:   COVERAGETYPESERVICE.CS                                      */
/* Description:   Implementation Service to handle Coverage Type Entities     */
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
    /// Implementation Service to handle Coverage Type Entities 
    /// </summary>
    public class CoverageTypeService : ICoverageTypeService
    {
        private ICoverageTypeRepository coverageTypeRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Services.CoverageTypeService"/> class.
        /// </summary>
        /// <param name="coverageTypeRepository">Injects an instance of an Coverage Type repository.</param>
        public CoverageTypeService(ICoverageTypeRepository coverageTypeRepository)
        {
            this.coverageTypeRepository = coverageTypeRepository;
        }

        /// <summary>
        /// Gets all records in Insurance Coverage Type Table.
        /// </summary>
        /// <returns>List of existing records</returns>
        public List<CoverageType> GetAll()
        {
            return this.coverageTypeRepository.GetAll();
        }
    }
}
