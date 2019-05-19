// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    [Unmanaged]
    public unsafe struct D3D12_CLEAR_VALUE
    {
        #region Fields
        [FieldOffset(0)]
        public DXGI_FORMAT Format;

        #region union
        [FieldOffset(4)]
        [NativeTypeName("FLOAT[4]")]
        public fixed float Color[4];

        [FieldOffset(4)]
        public D3D12_DEPTH_STENCIL_VALUE DepthStencil;
        #endregion
        #endregion

        #region Constructors
        public D3D12_CLEAR_VALUE(DXGI_FORMAT format, float* color)
        {
            fixed (D3D12_CLEAR_VALUE* pThis = &this)
            {
                Format = format;
                Buffer.MemoryCopy(color, pThis->Color, sizeof(float) * 4, sizeof(float) * 4);
            }
        }

        public D3D12_CLEAR_VALUE(DXGI_FORMAT format, float depth, byte stencil)
        {
            fixed (D3D12_CLEAR_VALUE* pThis = &this)
            {
                Format = format;
                /* Use memcpy to preserve NAN values */
                Buffer.MemoryCopy(&depth, &pThis->DepthStencil.Depth, sizeof(float), sizeof(float));
                DepthStencil.Stencil = stencil;
            }
        }
        #endregion
    }
}
