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

        public static byte RGB_to_Gray(UInt32 rgb)
        {
            byte Gray;
            UInt16 B = (UInt16)(rgb & 0xFF);
            UInt16 G = (UInt16)((rgb & 0xFF00) >> 8);
            UInt16 R = (UInt16)((rgb & 0xFF0000) >> 16);

            // Gray = (byte)((R * 1 + G * 2 + B * 1) >> 2);
            // Gray = (byte)((R * 2 + G * 5 + B * 1) >> 3);
            // Gray = (byte)((R * 4 + G * 10 + B * 2) >> 4);
            // Gray = (byte)((R * 9 + G * 19 + B * 4) >> 5);
            // Gray = (byte)((R * 19 + G * 37 + B * 8) >> 6);
            Gray = (byte)((R * 38 + G * 75 + B * 15) >> 7);
            // Gray = (byte)((R * 76 + G * 150 + B * 30) >> 8);
            // Gray = (byte)((R * 153 + G * 300 + B * 59) >> 9);
            // Gray = (byte)((R * 306 + G * 601 + B * 117) >> 10);
            // Gray = (byte)((R * 612 + G * 1202 + B * 234) >> 11);
            // Gray = (byte)((R * 1224 + G * 2405 + B * 467) >> 12);
            // Gray = (byte)((R * 2449 + G * 4809 + B * 934) >> 13);
            // Gray = (byte)((R * 4898 + G * 9618 + B * 1868) >> 14);
            // Gray = (byte)((R * 9797 + G * 19235 + B * 3736) >> 15);
            // Gray = (byte)((R * 19595 + G * 38469 + B * 7472) >> 16);
            // Gray = (byte)((R * 39190 + G * 76939 + B * 14943) >> 17);
            // Gray = (byte)((R * 78381 + G * 153878 + B * 29885) >> 18);
            // Gray = (byte)((R * 156762 + G * 307757 + B * 59769) >> 19);
            // Gray = (byte)((R * 313524 + G * 615514 + B * 119538) >> 20);

            return Gray;
        }
    }
}
