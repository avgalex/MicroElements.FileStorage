﻿// Copyright (c) MicroElements. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace MicroElements.FileStorage.NuGetEngine
{
    /// <summary>
    /// Configuration for <see cref="NuGetStorageEngine"/>.
    /// </summary>
    public class NuGetStorageConfiguration
    {
        /// <summary>
        /// Nuget package source.
        /// </summary>
        public string PackageSource { get; set; } = "https://api.nuget.org/v3/index.json";

        /// <summary>
        /// Package id.
        /// </summary>
        public string PackageId { get; set; } = "NUnit";

        /// <summary>
        /// Package version.
        /// </summary>
        public string PackageVersion { get; set; } = "3.9.0";

        /// <summary>
        /// Global package cache folder. All packages cached in this folder.
        /// </summary>
        public string GlobalPackagesFolder { get; set; } = "GlobalPackagesFolder";

        /// <summary>
        /// If direct download then <see cref="GlobalPackagesFolder"/> is not uses.
        /// </summary>
        public bool DirectDownload { get; set; } = false;

        /// <summary>
        /// Folder for install packages.
        /// </summary>
        public string InstallPackagesFolder { get; set; } = "packages";
    }
}
