﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

internal partial class Interop
{
    internal partial class User32
    {
        [LibraryImport(Libraries.User32, SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
        public static partial IntPtr FindWindowW(string lpClassName, string lpWindowName);
    }
}
