﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using FileActionsMenu.Interfaces;

namespace PowerToys.FileActionsMenu.Plugins.PowerToys
{
    public class Class1 : IFileActionsMenuPlugin
    {
        public string Name => "PowerToys modules";

        public string Description => "Adds entries for PowerToys modules.";

        public string Author => "Microsoft Corporation";

        public IAction[] TopLevelMenuActions =>
        [
            new PowerRename(),
            new ImageResizer(),
            new FileLocksmith(),
        ];
    }
}