// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The resource requirements for the container (cpu and memory). </summary>
    public partial class ContainerResourceRequirements
    {
        /// <summary> Initializes a new instance of ContainerResourceRequirements. </summary>
        public ContainerResourceRequirements()
        {
        }

        /// <summary> Initializes a new instance of ContainerResourceRequirements. </summary>
        /// <param name="cpu"> The number of CPU cores on the container. </param>
        /// <param name="memoryInGB"> The amount of memory on the container in GB. </param>
        /// <param name="gpu"> The number of GPU cores in the container. </param>
        /// <param name="fpga"> The number of FPGA PCIE devices exposed to the container. Must be multiple of 2. </param>
        internal ContainerResourceRequirements(double? cpu, double? memoryInGB, int? gpu, int? fpga)
        {
            Cpu = cpu;
            MemoryInGB = memoryInGB;
            Gpu = gpu;
            Fpga = fpga;
        }

        /// <summary> The number of CPU cores on the container. </summary>
        public double? Cpu { get; set; }
        /// <summary> The amount of memory on the container in GB. </summary>
        public double? MemoryInGB { get; set; }
        /// <summary> The number of GPU cores in the container. </summary>
        public int? Gpu { get; set; }
        /// <summary> The number of FPGA PCIE devices exposed to the container. Must be multiple of 2. </summary>
        public int? Fpga { get; set; }
    }
}
