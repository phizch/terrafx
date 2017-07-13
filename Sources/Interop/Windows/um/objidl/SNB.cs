// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\objidl.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using TerraFX.Utilities;

namespace TerraFX.Interop
{
    unsafe public /* blittable */ struct SNB : IEquatable<SNB>, IFormattable
    {
        #region Fields
        internal LPOLESTR* _value;
        #endregion

        #region Constructors
        /// <summary>Initializes a new instance of the <see cref="SNB" /> struct.</summary>
        /// <param name="value">The <see cref="LPOLESTR" />* used to initialize the instance.</param>
        public SNB(LPOLESTR* value)
        {
            _value = value;
        }
        #endregion

        #region Comparison Operators
        /// <summary>Compares two <see cref="SNB" /> instances to determine equality.</summary>
        /// <param name="left">The <see cref="SNB" /> to compare with <paramref name="right" />.</param>
        /// <param name="right">The <see cref="SNB" /> to compare with <paramref name="left" />.</param>
        /// <returns><c>true</c> if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, <c>false</c>.</returns>
        public static bool operator ==(SNB left, SNB right)
        {
            return (left._value == right._value);
        }

        /// <summary>Compares two <see cref="SNB" /> instances to determine inequality.</summary>
        /// <param name="left">The <see cref="SNB" /> to compare with <paramref name="right" />.</param>
        /// <param name="right">The <see cref="SNB" /> to compare with <paramref name="left" />.</param>
        /// <returns><c>true</c> if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, <c>false</c>.</returns>
        public static bool operator !=(SNB left, SNB right)
        {
            return (left._value != right._value);
        }
        #endregion

        #region Cast Operators
        /// <summary>Implicitly converts a <see cref="SNB" /> value to a <see cref="ushort" />** value.</summary>
        /// <param name="value">The <see cref="SNB" /> value to convert.</param>
        public static implicit operator ushort** (SNB value)
        {
            return (ushort**)(value._value);
        }

        /// <summary>Implicitly converts a <see cref="SNB" /> value to a <see cref="LPOLESTR" />* value.</summary>
        /// <param name="value">The <see cref="SNB" /> value to convert.</param>
        public static implicit operator LPOLESTR* (SNB value)
        {
            return value._value;
        }

        /// <summary>Implicitly converts a <see cref="SNB" /> value to a <see cref="OLECHAR" />** value.</summary>
        /// <param name="value">The <see cref="SNB" /> value to convert.</param>
        public static implicit operator OLECHAR** (SNB value)
        {
            return (OLECHAR**)(value._value);
        }

        /// <summary>Implicitly converts a <see cref="SNB" /> value to a <see cref="WCHAR" />** value.</summary>
        /// <param name="value">The <see cref="SNB" /> value to convert.</param>
        public static implicit operator WCHAR** (SNB value)
        {
            return (WCHAR**)(value._value);
        }

        /// <summary>Implicitly converts a <see cref="ushort" />** value to a <see cref="SNB" /> value.</summary>
        /// <param name="value">The <see cref="ushort" />** value to convert.</param>
        public static implicit operator SNB(ushort** value)
        {
            return new SNB((LPOLESTR*)(value));
        }

        /// <summary>Implicitly converts a <see cref="LPOLESTR" />* value to a <see cref="SNB" /> value.</summary>
        /// <param name="value">The <see cref="LPOLESTR" />* value to convert.</param>
        public static implicit operator SNB(LPOLESTR* value)
        {
            return new SNB(value);
        }

        /// <summary>Implicitly converts a <see cref="OLECHAR" />** value to a <see cref="SNB" /> value.</summary>
        /// <param name="value">The <see cref="OLECHAR" />** value to convert.</param>
        public static implicit operator SNB(OLECHAR** value)
        {
            return new SNB((LPOLESTR*)(value));
        }

        /// <summary>Implicitly converts a <see cref="WCHAR" />** value to a <see cref="SNB" /> value.</summary>
        /// <param name="value">The <see cref="WCHAR" />** value to convert.</param>
        public static implicit operator SNB(WCHAR** value)
        {
            return new SNB((LPOLESTR*)(value));
        }
        #endregion

        #region System.IEquatable<SNB> Methods
        /// <summary>Compares a <see cref="SNB" /> with the current instance to determine equality.</summary>
        /// <param name="other">The <see cref="SNB" /> to compare with the current instance.</param>
        /// <returns><c>true</c> if <paramref name="other" /> is equal to the current instance; otherwise, <c>false</c>.</returns>
        public bool Equals(SNB other)
        {
            var otherValue = (nuint)(other._value);
            return ((nuint)(_value)).Equals(otherValue);
        }
        #endregion

        #region System.IFormattable Methods
        /// <summary>Converts the current instance to an equivalent <see cref="string" /> value.</summary>
        /// <param name="format">The format to use or <c>null</c> to use the default format.</param>
        /// <param name="formatProvider">The provider to use when formatting the current instance or <c>null</c> to use the default provider.</param>
        /// <returns>An equivalent <see cref="string" /> value for the current instance.</returns>
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return ((nuint)(_value)).ToString(format, formatProvider);
        }
        #endregion

        #region System.Object Methods
        /// <summary>Compares a <see cref="object" /> with the current instance to determine equality.</summary>
        /// <param name="obj">The <see cref="object" /> to compare with the current instance.</param>
        /// <returns><c>true</c> if <paramref name="obj" /> is an instance of <see cref="SNB" /> and is equal to the current instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return (obj is SNB other)
                && Equals(other);
        }

        /// <summary>Gets a hash code for the current instance.</summary>
        /// <returns>A hash code for the current instance.</returns>
        public override int GetHashCode()
        {
            return ((nuint)(_value)).GetHashCode();
        }

        /// <summary>Converts the current instance to an equivalent <see cref="string" /> value.</summary>
        /// <returns>An equivalent <see cref="string" /> value for the current instance.</returns>
        public override string ToString()
        {
            return ((nuint)(_value)).ToString();
        }
        #endregion
    }
}
