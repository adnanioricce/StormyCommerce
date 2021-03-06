﻿using StormyCommerce.Core.Entities.Media;
using System.IO;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Interfaces
{
    public interface IMediaService
    {
        Media GetMediaByFilename(string fileName);
        string GetMediaUrl(Media media);

        string GetMediaUrl(string filename);

        string GetThumbnailUrl(Media media);

        Task SaveMediaAsync(Stream mediaBinaryStream, string filename, string mimeType = null);

        Task DeleteMediaAsync(Media media);

        Task DeleteMediaAsync(string filename);
    }
}
