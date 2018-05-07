/*----------------------------------------------------------------------------*/
/* Source File:   USER.CS                                                     */
/* Description:   Domain definition for User                                  */
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
    public class User
    {
        public long UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Insurance.Policy.Api.Domain.User"/> class.
        /// Constructor with parameters.
        /// </summary>
        /// <param name="userId">User identifier.</param>
        /// <param name="name">User Name.</param>
        /// <param name="lastName">User Last name.</param>
        public User(long userId, string name, string lastName)
        {
            this.UserId = userId;
            this.Name = name;
            this.LastName = lastName;
        }
    }
}
