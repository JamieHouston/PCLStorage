using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace PCLStorage
{
    public class StandardFileSystem : IFileSystem
    {
        /// <summary>
        /// Gets a file, given its path.  Returns null if the file does not exist.
        /// </summary>
        /// <param name="path">The path to a file, as returned from the <see cref="Path"/> property.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A file for the given path, or null if it does not exist.</returns>
        public async Task<IFile> GetFileFromPathAsync(string path, CancellationToken cancellationToken)
        {
            if (File.Exists(path))
            {
                return new StandardFile(path);
            }

            return null;
        }

        public IFolder LocalStorage { get; }
        public IFolder RoamingStorage { get; }
        public Task<IFolder> GetFolderFromPathAsync(string path, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }
    }
}