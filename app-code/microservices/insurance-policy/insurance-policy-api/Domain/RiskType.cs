/*----------------------------------------------------------------------------*/
/* Source File:   RISKTYPE.CS                                                 */
/* Description:   Domain definition for Risk Type                             */
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
    /// Domain definition for Risk Type
    /// </summary>
    public class RiskType
    {
        public long RiskTypeId { get; set; }
        public string Name { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Domain.RiskType"/> class.
        /// Default constructor.
        /// </summary>
        public RiskType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Domain.RiskType"/> class.
        /// Constructor with parameters.
        /// </summary>
        /// <param name="riskTypeId">Risk type identifier.</param>
        /// <param name="name">Name of risk type.</param>
        public RiskType(long riskTypeId, string name)
        {
            this.RiskTypeId = riskTypeId;
            this.Name = name;
        }
    }
}
