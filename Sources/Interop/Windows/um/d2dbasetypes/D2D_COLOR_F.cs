// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2dbasetypes.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public /* blittable */ struct D2D_COLOR_F
    {
        #region Fields
        [FieldOffset(0)]
        internal D3DCOLORVALUE _value;
        #endregion

        #region D3DCOLORVALUE Fields
        [FieldOffset(0)]
        public float r;

        [FieldOffset(4)]
        public float g;

        [FieldOffset(8)]
        public float b;

        [FieldOffset(12)]
        public float a;
        #endregion

        #region Constructors
        /// <summary>Initializes a new instance of the <see cref="D2D_COLOR_F" /> struct.</summary>
        /// <param name="value">The <see cref="D3DCOLORVALUE" /> used to initialize the instance.</param>
        public D2D_COLOR_F(D3DCOLORVALUE value) : this()
        {
            _value = value;
        }
        #endregion

        #region Cast Operators
        /// <summary>Implicitly converts a <see cref="D2D_COLOR_F" /> value to a <see cref="D3DCOLORVALUE" /> value.</summary>
        /// <param name="value">The <see cref="D2D_COLOR_F" /> value to convert.</param>
        public static implicit operator D3DCOLORVALUE(D2D_COLOR_F value)
        {
            return value._value;
        }

        /// <summary>Implicitly converts a <see cref="D3DCOLORVALUE" /> value to a <see cref="D2D_COLOR_F" /> value.</summary>
        /// <param name="value">The <see cref="D3DCOLORVALUE" /> value to convert.</param>
        public static implicit operator D2D_COLOR_F(D3DCOLORVALUE value)
        {
            return new D2D_COLOR_F(value);
        }
        #endregion
    }
}
