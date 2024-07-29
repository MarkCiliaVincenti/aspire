﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace Aspire.Dashboard.Model.BrowserStorage;

public class LocalBrowserStorage : BrowserStorageBase, ILocalStorage
{
    public LocalBrowserStorage(ProtectedLocalStorage protectedLocalStorage) : base(protectedLocalStorage)
    {
    }
}