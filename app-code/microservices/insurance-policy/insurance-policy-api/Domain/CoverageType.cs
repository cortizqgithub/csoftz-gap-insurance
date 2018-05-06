/*----------------------------------------------------------------------------*/
/* Source File:   COVERAGETYPE.CS                                             */
/* Description:   Domain definition for Coverage Type                         */
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
namespace Insurance.Policy.Api.Domain
{
    /// <summary>
    /// Domain definition for Coverage Type  
    /// </summary>
    public class CoverageType
    {
        public long CoverageTypeId { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Domain.CoverageType"/> class.
        /// Default constructor.
        /// </summary>
        public CoverageType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Domain.CoverageType"/> class.
        /// Constructor with parameters
        /// </summary>
        /// <param name="coverageTypeId">Coverage type identifier.</param>
        /// <param name="name">Name for coverage type</param>
        public CoverageType(long coverageTypeId, string name) 
        {
            this.CoverageTypeId = coverageTypeId;
            this.Name = name;
        }
    }
}
