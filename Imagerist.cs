using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encoder = System.Drawing.Imaging.Encoder;

namespace Avacircle
{
    class Imagerist
    {
        private Bitmap _bitmap;
        private Encoder myEncoderQuality;
        ImageCodecInfo myImageCodecInfo;
        Encoder myEncoderDepth;
        EncoderParameters myEncoderParameters;
        private EncoderParameter myParameterDepth;
        private EncoderParameter myParameterQuality;

        public Imagerist()
        {
            _bitmap = new Bitmap(100,100);
            Quality = 90L;
        }
        public Bitmap GetBitmap()
        {
            return _bitmap;
        }
        public void SetBitmap(Bitmap value)
        {
            _bitmap = value;
        }
        public int GetHeight()
        {
            return _bitmap.Height;
        }
        public int GetWidth()
        {
            return _bitmap.Width;
        }

        public long Quality { get; set; }

        internal void SavePNG(string fileName)
        {
            //
            myEncoderDepth = Encoder.ColorDepth;
            myImageCodecInfo = GetEncoderInfo("image/png");
            myEncoderParameters = new EncoderParameters(1);
            myParameterDepth = new EncoderParameter(myEncoderDepth, Quality);
            myEncoderParameters.Param[0] = myParameterDepth;
            
            try
            {
                _bitmap.Save(fileName, myImageCodecInfo, myEncoderParameters);
            }
            catch
            {

            }
        }
        internal void SaveJPG(string fileName)
        {
            myEncoderQuality = Encoder.Quality;
            myImageCodecInfo = GetEncoderInfo("image/jpeg");
            myEncoderParameters = new EncoderParameters(1);
            myParameterQuality = new EncoderParameter(myEncoderQuality, Quality);
            myEncoderParameters.Param[0] = myParameterQuality;
            try
            {
                _bitmap.Save(fileName, myImageCodecInfo, myEncoderParameters);
            }
            catch
            {

            }
        }

        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }
    }
}
