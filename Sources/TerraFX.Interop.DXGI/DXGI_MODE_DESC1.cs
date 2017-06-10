// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Unknown;

namespace TerraFX.Interop.DXGI
{
    public struct DXGI_MODE_DESC1
    {
        #region Fields
        public DXGI_MODE_DESC BaseValue;

        public BOOL Stereo;
        #endregion
    }
}
