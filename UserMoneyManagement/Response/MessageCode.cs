using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserMoneyManagement.Response
{
    public enum MessageCode
    {
        /// <summary>
        /// Entity to be inserted already exists (a primary key violation would occur).
        /// </summary>
        EntityAlreadyExist = 1001,

        /// <summary>
        /// Entity to be updated or deleted does not exist.
        /// </summary>
        EntityNotExist = 1002,

        /// <summary>
        /// The provided password does not match the one stored in the database.
        /// </summary>
        IncorrectPassword = 1003,

        /// <summary>
        /// The provided password does not meet password strength criteria.
        /// </summary>
        WeakPassword = 1004,

        /// <summary>
        /// The user with the specified username already exists.
        /// </summary>
        UserAlreadyExists = 1005,

        /// <summary>
        /// User use same password when attempt to change password.
        /// </summary>
        SamePasswordUsed = 1006,

        /// <summary>
        /// The provided date parameters in request are invalid.
        /// </summary>
        InvalidDate = 1007,

        /// <summary>
        /// The authentication token is not valid (missing claims, refresh token not found in the database, etc.)
        /// </summary>
        InvalidToken = 1008,

        /// <summary>
        /// User email is not verified.
        /// </summary>
        EmailNotVerified = 1009,

        /// <summary>
        /// User email was already confirmed.
        /// </summary>
        EmailAlreadyConfirmed = 1010,

        /// <summary>
        /// The user is not authorised to perform the requested operation.
        /// </summary>
        Unauthorised = 4011,

        /// <summary>
        /// An exception occured while performing the requested operation.
        /// </summary>
        HandledException = 5001
    }

}
