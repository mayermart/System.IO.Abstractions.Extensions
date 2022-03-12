﻿namespace System.IO.Abstractions.Extensions
{
    public static class IFileSystemExtensions
    {
        /// <summary>
        /// Get the current directory for the specified <paramref name="fileSystem"/>
        /// </summary>
        /// <param name="fileSystem">FileSystem in use</param>
        /// <returns>An <see cref="IDirectoryInfo"/> for the current directory</returns>
        public static IDirectoryInfo CurrentDirectory(this FileSystem fileSystem)
        {
            return fileSystem.DirectoryInfo.FromDirectoryName(fileSystem.Directory.GetCurrentDirectory());
        }
    }
}
