/*----------------------------------------------------------------------------*/
/* Source File:   INSURANCEPOLICYVIEW.CS                                      */
/* Description:   A mapping for Database VIEW vw_insurance_policy             */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          May.06/2018                                                 */
/* Last Modified: May.06/2018                                                 */
/* Version:       1.1                                                         */
/* Copyright (c), 2018 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/

/*-----------------------------------------------------------------------------
 History
 May.04/2018 COQ  File created.
 -----------------------------------------------------------------------------*/
using System;

namespace Insurance.Policy.Api.Domain.View
{
    /// <summary>
    /// A mapping for Database VIEW vw_insurance_policy.
    /// </summary>
    public class InsurancePolicyView : InsurancePolicy
    {
        public string PolicyName { get; set; }
        public string CoverageTypeName { get; set; }
        public string RiskTypeName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Domain.InsurancePolicyView"/> class.
        /// This is a default constructor.
        /// </summary>
        public InsurancePolicyView()
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
        public InsurancePolicyView(long id, string name, string description, int coverageType,
                               DateTime startDate, int coveragePeriod, Double price, int riskType,
                               string coverageTypeName, string riskTypeName)
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
        }
    }
}
