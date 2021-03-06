﻿using System;

namespace is2emu
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var emulator = new EmulatorIS2())
                emulator.Run();
        }
    }
#endif
}
