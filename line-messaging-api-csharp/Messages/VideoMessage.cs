﻿namespace LineDC.Messaging.Messages
{
    /// <summary>
    /// Video
    /// https://developers.line.me/en/docs/messaging-api/reference/#video
    /// </summary>
    public class VideoMessage : ISendMessage
    {
        public MessageType Type { get; } = MessageType.Video;

        /// <summary>
        /// These properties are used for the quick reply feature
        /// </summary>
        public QuickReply QuickReply { get; set; }

        /// <summary>
        /// When sending a message from the LINE Official Account, you can specify the sender in Message objects.
        /// </summary>
        public Sender Sender { get; set; }

        /// <summary>
        /// URL of video file (Max: 1000 characters)
        /// HTTPS
        /// mp4
        /// Less than 1 minute
        /// Max: 10 MB
        /// </summary>
        public string OriginalContentUrl { get; }

        /// <summary>
        /// URL of preview image (Max: 1000 characters)
        /// HTTPS
        /// JPEG
        /// Max: 240 x 240
        /// Max: 1 MB
        /// </summary>
        public string PreviewImageUrl { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="originalContentUrl">
        /// URL of video file (Max: 1000 characters)
        /// HTTPS
        /// mp4
        /// Less than 1 minute
        /// Max: 10 MB
        /// </param>
        /// <param name="previerImageUrl">
        /// URL of preview image (Max: 1000 characters)
        /// HTTPS
        /// JPEG
        /// Max: 240 x 240
        /// Max: 1 MB
        /// </param>
        /// <param name="quickReply">
        /// QuickReply
        /// </param>
        /// <param name="sender">
        /// Sender
        /// </param>
        public VideoMessage(string originalContentUrl, string previerImageUrl, QuickReply quickReply = null, Sender sender = null)
        {
            OriginalContentUrl = originalContentUrl;
            PreviewImageUrl = previerImageUrl;
            QuickReply = quickReply;
            Sender = sender;
        }
    }
}
