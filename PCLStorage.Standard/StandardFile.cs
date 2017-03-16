using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace PCLStorage
{
    public class StandardFile : IFile
    {
        private string _path;
        private string _name;
        public StandardFile(string path)
        {
            _path = path;
            _name = System.IO.Path.GetFileName(path);
        }

        public string Name => _name;

        public string Path => _path;

        public Task DeleteAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task MoveAsync(string newPath, NameCollisionOption collisionOption = NameCollisionOption.ReplaceExisting, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<Stream> OpenAsync(FileAccess fileAccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task RenameAsync(string newName, NameCollisionOption collisionOption = NameCollisionOption.FailIfExists, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
    }
}
