// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.Serialization;

namespace System.IdentityModel.Tokens
{
    public class SecurityTokenValidationException : SecurityTokenException
    {
        public SecurityTokenValidationException()
            : base()
        {
        }

        public SecurityTokenValidationException(String message)
            : base(message)
        {
        }

        public SecurityTokenValidationException(String message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected SecurityTokenValidationException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            throw new PlatformNotSupportedException();
        }
    }
}
