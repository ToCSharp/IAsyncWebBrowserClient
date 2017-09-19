// Copyright (c) Oleg Zudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// This file is based on or incorporates material from the project Selenium, licensed under the Apache License, Version 2.0. More info in THIRD-PARTY-NOTICES file.

using System;
//using System.Drawing;
//using System.Drawing.Imaging;
//using System.IO;

namespace Zu.WebBrowser.BasicTypes
{
    /// <summary>
    /// File format for saving screenshots.
    /// </summary>
    public enum ScreenshotImageFormat
    {
        /// <summary>
        /// W3C Portable Network Graphics image format.
        /// </summary>
        Png,

        /// <summary>
        /// Joint Photgraphic Experts Group image format.
        /// </summary>
        Jpeg,

        /// <summary>
        /// Graphics Interchange Format image format.
        /// </summary>
        Gif,

        /// <summary>
        /// Tagged Image File Format image format.
        /// </summary>
        Tiff,

        /// <summary>
        /// Bitmap image format.
        /// </summary>
        Bmp
    }

    /// <summary>
    /// Represents an image of the page currently loaded in the browser.
    /// </summary>
    [Serializable]
    public class Screenshot
    {
        private string base64Encoded = string.Empty;
        private byte[] byteArray;

        /// <summary>
        /// Initializes a new instance of the <see cref="Screenshot"/> class.
        /// </summary>
        /// <param name="base64EncodedScreenshot">The image of the page as a Base64-encoded string.</param>
        public Screenshot(string base64EncodedScreenshot)
        {
            this.base64Encoded = base64EncodedScreenshot;
            this.byteArray = Convert.FromBase64String(this.base64Encoded);
        }

        /// <summary>
        /// Gets the value of the screenshot image as a Base64-encoded string.
        /// </summary>
        public string AsBase64EncodedString
        {
            get { return this.base64Encoded; }
        }

        /// <summary>
        /// Gets the value of the screenshot image as an array of bytes.
        /// </summary>
        public byte[] AsByteArray
        {
            get { return this.byteArray; }
        }

        ///// <summary>
        ///// Saves the screenshot to a file, overwriting the file if it already exists.
        ///// </summary>
        ///// <param name="fileName">The full path and file name to save the screenshot to.</param>
        ///// <param name="format">A <see cref="ScreenshotImageFormat"/> value indicating the format
        ///// to save the image to.</param>
        //public void SaveAsFile(string fileName, ScreenshotImageFormat format)
        //{
        //    this.SaveAsFile(fileName, ConvertScreenshotImageFormat(format));
        //}

        ///// <summary>
        ///// Saves the screenshot to a file, overwriting the file if it already exists.
        ///// </summary>
        ///// <param name="fileName">The full path and file name to save the screenshot to.</param>
        ///// <param name="format">A <see cref="System.Drawing.Imaging.ImageFormat"/> object indicating the format
        ///// to save the image to.</param>
        ////[Obsolete("System.Drawing.Imaging.ImageFormat is not supported in .NET Core, and depending on it is being removed from WebDriver. Please convert to ScreenshotImageFormat.")]
        //public void SaveAsFile(string fileName, ImageFormat format)
        //{
        //    using (MemoryStream imageStream = new MemoryStream(this.byteArray))
        //    {
        //        Image screenshotImage = Image.FromStream(imageStream);
        //        screenshotImage.Save(fileName, format);
        //    }
        //}

        /// <summary>
        /// Returns a <see cref="string">String</see> that represents the current <see cref="object">Object</see>.
        /// </summary>
        /// <returns>A <see cref="string">String</see> that represents the current <see cref="object">Object</see>.</returns>
        public override string ToString()
        {
            return this.base64Encoded;
        }

        //private static ImageFormat ConvertScreenshotImageFormat(ScreenshotImageFormat format)
        //{
        //    ImageFormat returnedFormat = ImageFormat.Png;
        //    switch (format)
        //    {
        //        case ScreenshotImageFormat.Jpeg:
        //            returnedFormat = ImageFormat.Jpeg;
        //            break;

        //        case ScreenshotImageFormat.Gif:
        //            returnedFormat = ImageFormat.Gif;
        //            break;

        //        case ScreenshotImageFormat.Bmp:
        //            returnedFormat = ImageFormat.Bmp;
        //            break;

        //        case ScreenshotImageFormat.Tiff:
        //            returnedFormat = ImageFormat.Tiff;
        //            break;
        //    }

        //    return returnedFormat;
        //}
    }
}