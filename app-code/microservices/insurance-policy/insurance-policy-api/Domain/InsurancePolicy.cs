/*----------------------------------------------------------------------------*/
/* Source File:   INSURANCEPOLICY.CS                                          */
/* Description:   Domain definition for Insurance Policy                      */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          May.04/2018                                                 */
/* Last Modified: May.05/2018                                                 */
/* Version:       1.1                                                         */
/* Copyright (c), 2018 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/

/*-----------------------------------------------------------------------------
 History
 May.04/2018 COQ  File created.
 -----------------------------------------------------------------------------*/
using System;

namespace Insurance.Policy.Api.Domain
{
    /// <summary>
    /// Domain definition for Insurance Policy
    /// </summary>
    public class InsurancePolicy
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CoverageType { get; set; }
        public DateTime StartDate { get; set; }
        public int CoveragePeriod { get; set; } // In months
        public Double Price { get; set; } 
        public int RiskType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Domain.InsurancePolicy"/> class.
        /// This is a default constructor.
        /// </summary>
        public InsurancePolicy()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Domain.InsurancePolicy"/> class.
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
        public InsurancePolicy(long id, string name, string description, int coverageType, 
                               DateTime startDate, int coveragePeriod, Double price, int riskType) {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.CoverageType = coverageType;
            this.StartDate = startDate;
            this.CoveragePeriod = coveragePeriod;
            this.Price = price;
            this.RiskType = riskType;
        }
    }
}