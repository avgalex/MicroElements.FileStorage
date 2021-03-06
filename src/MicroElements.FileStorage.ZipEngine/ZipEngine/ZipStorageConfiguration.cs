﻿// Copyright (c) MicroElements. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.IO;

namespace MicroElements.FileStorage.ZipEngine
{
    /// <summary>
    /// Cjnfiguration for <see cref="ZipStorageEngine"/>.
    /// </summary>
    public class ZipStorageConfiguration
    {
        /// <summary>
        /// A relative or absolute path for the archive.
        /// </summary>
        public string Path { get; }

        /// <summary>
        /// Input zip stream.
        /// </summary>
        public Stream Stream { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZipStorageConfiguration"/> class.
        /// </summary>
        /// <param name="path">Relative or absolute path for the archive.</param>
        public ZipStorageConfiguration(string path)
        {
            Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZipStorageConfiguration"/> class.
        /// </summary>
        /// <param name="stream">Input zip stream.</param>
        public ZipStorageConfiguration(Stream stream)
        {
            Stream = stream;
        }

        /// <summary>
        /// A relative path in internal zip.
        /// </summary>
        public string ZipInternalBasePath { get; set; }

        /// <summary>
        /// To use FileStream or MemoryStream. For Memory available in read-only mode. For FileStream available in read-write mode.
        /// </summary>
        public ZipStorageEngineStreamType StreamType { get; set; } = ZipStorageEngineStreamType.FileStream;

        /// <summary>
        /// Read or Write mode.
        /// </summary>
        public ZipStorageEngineMode Mode { get; set; } = ZipStorageEngineMode.Read;

        /// <summary>
        /// True to leave the stream open after the ZiptorageEngine object is disposed; otherwise, false.
        /// </summary>
        public bool LeaveOpen { get; set; } = false;
    }
}
