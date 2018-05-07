/*----------------------------------------------------------------------------*/
/* Source File:   USERINSURANCEPOLICYCOMPUTED.CS                              */
/* Description:   Used as an internal mapping for linked Insurance Policy to  */
/*                an user.                                                    */
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
using System;using Insurance.Policy.Api.Domain.View;

namespace Insurance.Policy.Api.Domain.Computed
{
    /// <summary>
    /// Used as an internal mapping for linked Insurance Policy to an user.
    /// That is, all existing 'Insurance Policies' are retrieved and given the UserId, 
    /// all 'User Existing Policy' table is filtered by this 'UserId' and if
    /// one 'Insurance Policy' exists then 'Selected' field is 1, else 0.
    /// </summary>
    public class UserInsurancePolicyComputed : InsurancePolicyView
    {
        public int Selected { get; set; }
        public long UserId { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Insurance.Policy.Api.Domain.Computed.UserInsurancePolicyComputed"/> class.
        /// </summary>
        public UserInsurancePolicyComputed()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Domain.InsurancePolicyView"/> class.
        /// This is a constructor with parameters
        /// </summary>
        /// <param name="id">Unique Identifier</param>
        /// <param name="name">Name of Insurance Policy</param>
        /// <param name="description">Meaning of the Insurance Policy</param>
        /// <param name="coverageType">Assigns the Coverage type</param>
        /// <param name="startDate">Indicates when the validity of the Insurance Policiy.</param>
        /// <param name="coveragePeriod">Indicates the months of coverage for the Insurance Policy</param>
        /// <param name="price">Value to be paid for the Insurance Policy.</param>
        /// <param name="riskType">What kind of risk is the Insurance Policy.</param>
        /// <param name="coverageTypeName">Description for Coverage Type</param>
        /// <param name="riskTypeName">Description for Risk Type</param>
        public UserInsurancePolicyComputed(long id, string name, string description, int coverageType,
                               DateTime startDate, int coveragePeriod, Double price, int riskType,
                               string coverageTypeName, string riskTypeName,
                               int selected, long userId)
        {
            this.Id = id;
            this.Name = name;
            this.PolicyName = name;
            this.Description = description;
            this.CoverageType = coverageType;
            this.StartDate = startDate;
            this.CoveragePeriod = coveragePeriod;
            this.Price = price;
            this.RiskType = riskType;
            this.CoverageTypeName = coverageTypeName;
            this.RiskTypeName = riskTypeName;
            this.Selected = selected;
            this.UserId = userId;
        }
    }
}
