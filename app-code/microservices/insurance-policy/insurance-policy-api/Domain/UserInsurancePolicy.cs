/*----------------------------------------------------------------------------*/
/* Source File:   USERINSURANCEPOLICY.CS                                      */
/* Description:   Domain definition for User Insurance Policy                 */
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
namespace Insurance.Policy.Api.Domain
{
    /// <summary>
    /// Domain definition for User Insurance Policy
    /// </summary>
    public class UserInsurancePolicy
    {
        public long UserId { get; set; }
        public long InsurancePolicyId { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Domain.UserInsurancePolicy"/> class.
        /// Constructor with parameters.
        /// </summary>
        /// <param name="userId">User identifier.</param>
        /// <param name="insurancePolicyId">Insurance policy identifier.</param>
        public UserInsurancePolicy(long userId, long insurancePolicyId)
        {
            this.UserId = userId;
            this.InsurancePolicyId = insurancePolicyId;
        }
    }
}
