/*----------------------------------------------------------------------------*/
/* Source File:   GLOBALCONSTANTS.CS                                          */
/* Description:   Global application Constants                                */
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
namespace Insurance.Policy.Api.Helper.Consts
{
    /// <summary>
    /// Global application Constants. Used as a static class access only. This way it
    /// is assured that a change in the constant value is modified in one place.
    /// </summary>
    public class GlobalConstants
    {
        // General
        public const string POSTGRESQL_CONN_STRING = "Server=localhost;Port=5432;Database=myDataBase;Userid=myUsername;Password=myPassword;Protocol=3;Pooling=true;MinPoolSize=1;MaxPoolSize=20;ConnectionLifeTime=15;";

    }
}
