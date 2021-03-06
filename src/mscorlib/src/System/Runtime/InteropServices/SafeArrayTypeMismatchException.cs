// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*=============================================================================
**
**
** Purpose: This exception is thrown when the runtime type of an array
**            is different than the safe array sub type specified in the 
**            metadata.
**
=============================================================================*/


using System;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
    public class SafeArrayTypeMismatchException : SystemException
    {
        public SafeArrayTypeMismatchException()
            : base(SR.Arg_SafeArrayTypeMismatchException)
        {
            HResult = __HResults.COR_E_SAFEARRAYTYPEMISMATCH;
        }

        public SafeArrayTypeMismatchException(String message)
            : base(message)
        {
            HResult = __HResults.COR_E_SAFEARRAYTYPEMISMATCH;
        }

        public SafeArrayTypeMismatchException(String message, Exception inner)
            : base(message, inner)
        {
            HResult = __HResults.COR_E_SAFEARRAYTYPEMISMATCH;
        }

        protected SafeArrayTypeMismatchException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            throw new PlatformNotSupportedException();
        }
    }
}
