// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*=============================================================================
**
** Class: ICustomAdapter
**
**
** Purpose: This the base interface that custom adapters can chose to implement
**          when they want to expose the underlying object.
**
**
=============================================================================*/

using System;

namespace System.Runtime.InteropServices
{
    public interface ICustomAdapter
    {
        [return: MarshalAs(UnmanagedType.IUnknown)]
        object GetUnderlyingObject();
    }
}
