﻿using Amplifier.OpenCL;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmplifierExamples.Kernels
{
    class SimpleKernels : OpenCLFunctions
    {
        [OpenCLKernel]
        void add_float([Global]float[] a, [Global] float[] b, [Global]float[] r)
        {
            int i = get_global_id(0);
            b[i] = 0.5f * b[i];
            r[i] = a[i] + b[i];
        }

        [OpenCLKernel]
        void Fill([Global] float[] x, float value)
        {
            int i = get_global_id(0);
            
            x[i] = value;
        }
    }
}