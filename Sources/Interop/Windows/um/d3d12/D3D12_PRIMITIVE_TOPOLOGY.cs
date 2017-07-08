// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public /* blittable */ struct D3D12_PRIMITIVE_TOPOLOGY
    {
        #region Fields
        internal D3D_PRIMITIVE_TOPOLOGY _value;
        #endregion

        #region Constructors
        /// <summary>Initializes a new instance of the <see cref="D3D12_PRIMITIVE_TOPOLOGY" /> struct.</summary>
        /// <param name="value">The <see cref="D3D_PRIMITIVE_TOPOLOGY" /> used to initialize the instance.</param>
        public D3D12_PRIMITIVE_TOPOLOGY(D3D_PRIMITIVE_TOPOLOGY value)
        {
            _value = value;
        }
        #endregion

        #region Operators
        /// <summary>Explicitly converts a <see cref="D3D12_PRIMITIVE_TOPOLOGY" /> value to a <see cref="D3D_PRIMITIVE_TOPOLOGY" /> value.</summary>
        /// <param name="value">The <see cref="D3D12_PRIMITIVE_TOPOLOGY" /> value to convert.</param>
        public static implicit operator D3D_PRIMITIVE_TOPOLOGY(D3D12_PRIMITIVE_TOPOLOGY value)
        {
            return value._value;
        }

        /// <summary>Implicitly converts a <see cref="D3D_PRIMITIVE_TOPOLOGY" /> value to a <see cref="D3D12_PRIMITIVE_TOPOLOGY" /> value.</summary>
        /// <param name="value">The <see cref="D3D_PRIMITIVE_TOPOLOGY" /> value to convert.</param>
        public static implicit operator D3D12_PRIMITIVE_TOPOLOGY(D3D_PRIMITIVE_TOPOLOGY value)
        {
            return new D3D12_PRIMITIVE_TOPOLOGY(value);
        }
        #endregion
    }
}