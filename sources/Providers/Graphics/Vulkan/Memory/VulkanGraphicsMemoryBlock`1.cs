// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// This file includes code based on the MemoryBlock class from https://github.com/GPUOpen-LibrariesAndSDKs/D3D12MemoryAllocator/
// The original code is Copyright © Advanced Micro Devices, Inc. All rights reserved. Licensed under the MIT License (MIT).

using TerraFX.Interop;
using TerraFX.Utilities;
using static TerraFX.Graphics.Providers.Vulkan.HelperUtilities;
using static TerraFX.Interop.VkStructureType;
using static TerraFX.Interop.Vulkan;
using static TerraFX.Utilities.ExceptionUtilities;
using static TerraFX.Utilities.State;

namespace TerraFX.Graphics.Providers.Vulkan
{
    /// <inheritdoc />
    public sealed unsafe class VulkanGraphicsMemoryBlock<TMetadata> : GraphicsMemoryBlock<TMetadata>
        where TMetadata : struct, GraphicsMemoryBlock.IMetadata
    {
        private ValueLazy<VkDeviceMemory> _vulkanDeviceMemory;
        private State _state;

        internal VulkanGraphicsMemoryBlock(VulkanGraphicsMemoryBlockCollection collection, ulong size, ulong marginSize, ulong minimumFreeRegionSizeToRegister)
            : base(collection, size, marginSize, minimumFreeRegionSizeToRegister)
        {
            _vulkanDeviceMemory = new ValueLazy<VkDeviceMemory>(CreateVulkanDeviceMemory);
            _ = _state.Transition(to: Initialized);
        }

        /// <summary>Finalizes an instance of the <see cref="VulkanGraphicsMemoryBlock{TMetadata}" /> class.</summary>
        ~VulkanGraphicsMemoryBlock() => Dispose(isDisposing: true);

        /// <summary>Gets the <see cref="VkDeviceMemory" /> for the memory block.</summary>
        public VkDeviceMemory VulkanDeviceMemory => _vulkanDeviceMemory.Value;

        /// <inheritdoc cref="GraphicsMemoryBlock.Collection" />
        public new VulkanGraphicsMemoryBlockCollection Collection => (VulkanGraphicsMemoryBlockCollection)base.Collection;

        /// <inheritdoc />
        public override T GetHandle<T>()
        {
            if (typeof(T) != typeof(VkDeviceMemory))
            {
                ThrowArgumentExceptionForInvalidType(nameof(T), typeof(T));
            }
            return (T)(object)_vulkanDeviceMemory.Value;
        }

        /// <inheritdoc />
        protected override void Dispose(bool isDisposing)
        {
            var priorState = _state.BeginDispose();

            if (priorState < Disposing)
            {
                _vulkanDeviceMemory.Dispose(DisposeVulkanDeviceMemory);
            }

            _state.EndDispose();
        }

        private VkDeviceMemory CreateVulkanDeviceMemory()
        {
            _state.ThrowIfDisposedOrDisposing();

            VkDeviceMemory vulkanDeviceMemory;

            var collection = Collection;
            var vulkanDevice = collection.Allocator.Device.VulkanDevice;

            var memoryAllocateInfo = new VkMemoryAllocateInfo {
                sType = VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO,
                allocationSize = Size,
                memoryTypeIndex = collection.VulkanMemoryTypeIndex,
            };
            ThrowExternalExceptionIfNotSuccess(nameof(vkAllocateMemory), vkAllocateMemory(vulkanDevice, &memoryAllocateInfo, pAllocator: null, (ulong*)&vulkanDeviceMemory));

            return vulkanDeviceMemory;
        }

        private void DisposeVulkanDeviceMemory(VkDeviceMemory vulkanDeviceMemory)
        {
            if (vulkanDeviceMemory != VK_NULL_HANDLE)
            {
                vkFreeMemory(Collection.Allocator.Device.VulkanDevice, vulkanDeviceMemory, pAllocator: null);
            }
        }
    }
}
