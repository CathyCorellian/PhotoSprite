using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace PhotoSprite
{
    class Utility
    {
        static public void Save(Bitmap bmp, string filePath)
        {
            var bmpData = bmp.LockBits(new Rectangle(Point.Empty, bmp.Size), ImageLockMode.ReadOnly, PixelFormat.Format32bppRgb);

            try
            {
                using (var writer = new BinaryWriter(new FileStream(filePath, FileMode.Create, FileAccess.Write), Encoding.ASCII))
                {
                    writer.Write(Encoding.ASCII.GetBytes("PSF"));  //PSF Mark
                    writer.Write((byte)1);                         //version
                    writer.Write((Int16)bmp.Width);                //width
                    writer.Write((Int16)bmp.Height);               //height
                    writer.Write((byte)0xcc);                      //alpha Mark

                    var scanPointer = bmpData.Scan0;
                    var dataBuffer = new byte[bmpData.Width * 4];

                    for (var y = 0; y < bmpData.Height; y++, scanPointer += bmpData.Stride)
                    {
                        Marshal.Copy(scanPointer, dataBuffer, 0, dataBuffer.Length);
                        writer.Write(dataBuffer);
                    }
                }
            }
            finally
            {
                bmp.UnlockBits(bmpData);
            }
        }

        static public Bitmap Open(string filePath)
        {
            using (var reader = new BinaryReader(new FileStream(filePath, FileMode.Open, FileAccess.Read)))
            {
                if(new string(reader.ReadChars(3)) != "PSF" || reader.ReadByte() != 1)
                    throw new Exception();
                
                var width = reader.ReadInt16();
                var height = reader.ReadInt16();
                var alphaMark = reader.ReadByte();

                var bmp = new Bitmap(width, height);
                var bmpData = bmp.LockBits(new Rectangle(Point.Empty, bmp.Size), ImageLockMode.WriteOnly, PixelFormat.Format32bppRgb);
                try
                {
                    var scanPointer = bmpData.Scan0;
                    for (var y = 0; y < bmpData.Height; y++, scanPointer += bmpData.Stride)
                    {
                        var dataBuffer = reader.ReadBytes(bmpData.Width * 4);
                        Marshal.Copy(dataBuffer, 0, scanPointer, dataBuffer.Length);
                    }

                    return bmp;
                }
                finally
                {
                    bmp.UnlockBits(bmpData);
                }

            }
        }

        static public HSL ToHSL(this Color color)
        {
            return new HSL() 
            {
                Hue = color.GetHue(),
                Saturation = color.GetSaturation(),
                Lightness = color.GetBrightness(),
            };
        }
    }
}
