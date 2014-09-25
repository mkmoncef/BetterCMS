﻿using System;
using System.IO;
using System.Runtime.Serialization;

namespace BetterCms.Module.Api.Operations.MediaManager.Images.Image
{
    /// <summary>
    /// The upload image model.
    /// </summary>
    [DataContract]
    [Serializable]
    public class UploadImageModel
    {
        /// <summary>
        /// Gets or sets image id.
        /// </summary>
        [DataMember]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or sets image title.
        /// </summary>
        [DataMember]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets image description.
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets image caption.
        /// </summary>
        [DataMember]
        public string Caption { get; set; }

        /// <summary>
        /// Gets or sets folder id.
        /// </summary>
        [DataMember]
        public Guid? FolderId { get; set; }

        /// <summary>
        /// Gets or sets file name.
        /// </summary>
        [DataMember]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets image file stream.
        /// </summary>
        [DataMember]
        public Stream FileStream { get; set; }
    }
}
