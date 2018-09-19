namespace RGB_Converter
{
    using RGBConvert;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            fun3();
        }

        static void fun1()
        {
            UInt32 arg = Convert.ToUInt32(Console.ReadLine(), 16);
            UInt16 res = RGBConvert.RGB888_to_RGB565(arg);
            Console.WriteLine("{0:x}", res);
            Console.ReadKey();
        }

        static void fun2()
        {
            UInt16 arg = Convert.ToUInt16(Console.ReadLine(), 16);
            UInt32 res = RGBConvert.RGB565_to_RGB888(arg);
            Console.WriteLine("{0:x}", res);
            Console.ReadKey();
        }

        static void fun3()
        {
            byte res = RGBConvert.RGB_to_Gray(0x0010F030);
            Console.WriteLine("{0:x}", res);
            Console.ReadKey();
        }
    }
}
