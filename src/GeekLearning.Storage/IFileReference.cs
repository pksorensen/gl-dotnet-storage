﻿namespace GeekLearning.Storage
{
    using System.IO;
    using System.Threading.Tasks;

    public interface IFileReference: IPrivateFileReference
    {
        string PublicUrl { get; }

        Task ReadToStreamAsync(Stream targetStream);

        Task<Stream> ReadAsync();

        Task<string> ReadAllTextAsync();

        Task<byte[]> ReadAllBytesAsync();

        Task DeleteAsync();

        Task UpdateAsync(Stream stream);

        Task<string> GetExpirableUriAsync();
    }
}
