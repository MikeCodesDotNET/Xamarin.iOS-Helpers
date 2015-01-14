using System;
using UIKit;
using Foundation;

namespace MikeJames
{
    public static class Image
    {
        /// <summary>
        /// UIImage to byte array. Orginal from : Matteo Bortolu
        /// </summary>
        /// <returns>NSData</returns>
        /// <param name="image">Image.</param>
        public static byte[] ToNSData(this UIImage image){

            if (image == null) {
                return null;
            }
            NSData data = null;

            try {
                data = image.AsPNG();
                return data.ToArray ();
            } catch (Exception ) {
                return null;
            }
            finally
            {
                if (image != null) {
                    image.Dispose ();
                }
                if (data != null) {
                    data.Dispose ();
                }
            }
        }

        /// <summary>
        /// Byte array to UIImage. Orginal from : Matteo Bortolu
        /// </summary>
        /// <returns>The image.</returns>
        /// <param name="data">Data.</param>
        public static UIImage ToImage(this byte[] data)
        {
            if (data==null) {
                return null;
            }
            UIImage image = null;
            try {

                image = new UIImage(NSData.FromArray(data));
                data = null;
            } catch (Exception ) {
                return null;
            }
            return image;
        }
    }
}

