﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Producer.Configuration
{
    // This is simply just a separate file for configuration parameters for cleanliness.
    // https://www.programiz.com/csharp-programming/struct
    public struct ConfigParameter
    {
        public static int nConsumerThreads;
        public static int nMaxQueueLength;
    }

    public struct Video
    {
        public byte[] videosByte;
    }

    public struct Queue
    {
        public static Queue<Video> videoQueue = new Queue<Video>();
    }
}
