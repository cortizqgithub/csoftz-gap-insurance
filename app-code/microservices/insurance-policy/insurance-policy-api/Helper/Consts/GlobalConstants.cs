/*----------------------------------------------------------------------------*/
/* Source File:   GLOBALCONSTANTS.CS                                          */
/* Description:   Global application Constants                                */
/* Author:        Carlos Adolfo Ortiz Quirós (COQ)                            */
/* Date:          May.04/2018                                                 */
/* Last Modified: May.06/2018                                                 */
/* Version:       1.1                                                         */
/* Copyright (c), 2018 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/

/*-----------------------------------------------------------------------------
 History
 May.04/2018 COQ  File created.
 -----------------------------------------------------------------------------*/
namespace Insurance.Policy.Api.Helper.Consts
{
    /// <summary>
    /// Global application Constants. Used as a static class access only. This way it
    /// is assured that a change in the constant value is modified in one place.
    /// </summary>
    public class GlobalConstants
    {
        // General
        public const string POSTGRESQL_CONN_STRING = "Server=localhost;Port=5432;Database=csoftz-insurance;Userid=postgres;Password=Ceiba1234!;Pooling=true;MinPoolSize=1;MaxPoolSize=20;";

        // Insurance Policy SQL
        public const string INSURANCE_POLICY_GET_ALL = @"select * from vw_insurance_policy;";
        public const string INSURANCE_POLICY_FIND_BY_ID = @"select * from insurance_policy where ""Id"" = @Id;";
        public const string INSURANCE_POLICY_SAVE = @"insert into insurance_policy(""Name"", ""Description"", ""CoverageType"",
                                                     ""StartDate"", ""CoveragePeriod"", ""Price"", ""RiskType"") values(@Name,
                                                     @Description, @CoverageType, @StartDate, @CoveragePeriod, @Price, @RiskType)";
        public const string INSURANCE_POLICY_UPDATE = @"update insurance_policy 
                                                        set ""Name"" = @Name,
                                                            ""Description"" = @Description,
                                                            ""CoverageType"" = @CoverageType,
                                                            ""StartDate"" = @StartDate,
                                                            ""CoveragePeriod"" = @CoveragePeriod,
                                                            ""Price"" = @Price,
                                                            ""RiskType"" = @RiskType 
                                                        where ""Id"" = @Id;";
        public const string INSURANCE_POLICY_DELETE = @"delete from insurance_policy where ""Id"" = @Id;";

   }
}