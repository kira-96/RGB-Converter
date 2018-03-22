namespace RGBConvert
{
    using System;

    public static class RGBConvert
    {
        public static UInt16 RGB888_to_RGB565(UInt32 rgb888)
        {
            UInt16 B = (UInt16)((rgb888 & 0x000000F8) >> 3);
            UInt16 G = (UInt16)((rgb888 & 0x0000FC00) >> 5);
            UInt16 R = (UInt16)((rgb888 & 0x00F80000) >> 8);
            return (UInt16)(R | G | B);
        }

        public static UInt32 RGB565_to_RGB888(UInt16 rgb565)
        {
            UInt32 B = (UInt32)(((rgb565 & 0x001F) << 3) | (rgb565 & 0x0007));
            UInt32 G = (UInt32)(((rgb565 & 0x07E0) << 5) | ((rgb565 & 0x0060) << 3));
            UInt32 R = (UInt32)(((rgb565 & 0xF800) << 8) | ((rgb565 & 0x3800) << 5));

            return (R | G | B);
        }
    }
}
