/*----------------------------------------------------------------------------*/
/* Source File:   RISKTYPE.CS                                                 */
/* Description:   Risk types associated to the Insurance Policy               */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          May.05/2018                                                 */
/* Last Modified: May.05/2018                                                 */
/* Version:       1.1                                                         */
/* Copyright (c), 2018 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/

/*-----------------------------------------------------------------------------
 History
 May.05/2018 COQ  File created.
 -----------------------------------------------------------------------------*/
namespace Insurance.Policy.Api.Helper.Consts
{
    /// <summary>
    /// Risk types associated to the Insurance Policy
    /// </summary>
    public class RiskType
    {
        public const int LOW = 1;
        public const int MEDIUM = 2;
        public const int MEDIUM_HIGH = 3;
        public const int HIGH = 4;
    }
}
