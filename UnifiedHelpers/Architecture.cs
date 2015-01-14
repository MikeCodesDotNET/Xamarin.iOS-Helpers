using System;

namespace MikeJames
{
    public static class Architecture
    {
        public static bool Is64Bit()
        {
            return IntPtr.Size != 4;
        }
    }
}

