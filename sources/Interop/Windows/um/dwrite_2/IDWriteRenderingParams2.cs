// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using TerraFX.Utilities;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>The interface that represents text rendering settings for glyph rasterization and filtering.</summary>
    [Guid("F9D711C3-9777-40AE-87E8-3E5AF9BF0948")]
    [Unmanaged]
    public unsafe struct IDWriteRenderingParams2
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteRenderingParams2* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteRenderingParams2* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteRenderingParams2* This
        );
        #endregion

        #region IDWriteRenderingParams Delegates
        /// <summary>Gets the gamma value used for gamma correction. Valid values must be greater than zero and cannot exceed 256.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("FLOAT")]
        public /* static */ delegate float _GetGamma(
            [In] IDWriteRenderingParams2* This
        );

        /// <summary>Gets the amount of contrast enhancement. Valid values are greater than or equal to zero.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("FLOAT")]
        public /* static */ delegate float _GetEnhancedContrast(
            [In] IDWriteRenderingParams2* This
        );

        /// <summary>Gets the ClearType level. Valid values range from 0.0f (no ClearType) to 1.0f (full ClearType).</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate float _GetClearTypeLevel(
            [In] IDWriteRenderingParams2* This
        );

        /// <summary>Gets the pixel geometry.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_PIXEL_GEOMETRY _GetPixelGeometry(
            [In] IDWriteRenderingParams2* This
        );

        /// <summary>Gets the rendering mode.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_RENDERING_MODE _GetRenderingMode(
            [In] IDWriteRenderingParams2* This
        );
        #endregion

        #region IDWriteRenderingParams1 Delegates
        /// <summary>Gets the amount of contrast enhancement to use for grayscale antialiasing. Valid values are greater than or equal to zero.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("FLOAT")]
        public /* static */ delegate float _GetGrayscaleEnhancedContrast(
            [In] IDWriteRenderingParams2* This
        );
        #endregion

        #region Delegates
        /// <summary>Gets the grid fitting mode.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_GRID_FIT_MODE _GetGridFitMode(
            [In] IDWriteRenderingParams2* This
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteRenderingParams2* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteRenderingParams2* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteRenderingParams2* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region IDWriteRenderingParams Methods
        [return: NativeTypeName("FLOAT")]
        public float GetGamma()
        {
            fixed (IDWriteRenderingParams2* This = &this)
            {
                return MarshalFunction<_GetGamma>(lpVtbl->GetGamma)(
                    This
                );
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetEnhancedContrast()
        {
            fixed (IDWriteRenderingParams2* This = &this)
            {
                return MarshalFunction<_GetEnhancedContrast>(lpVtbl->GetEnhancedContrast)(
                    This
                );
            }
        }

        public float GetClearTypeLevel()
        {
            fixed (IDWriteRenderingParams2* This = &this)
            {
                return MarshalFunction<_GetClearTypeLevel>(lpVtbl->GetClearTypeLevel)(
                    This
                );
            }
        }

        public DWRITE_PIXEL_GEOMETRY GetPixelGeometry()
        {
            fixed (IDWriteRenderingParams2* This = &this)
            {
                return MarshalFunction<_GetPixelGeometry>(lpVtbl->GetPixelGeometry)(
                    This
                );
            }
        }

        public DWRITE_RENDERING_MODE GetRenderingMode()
        {
            fixed (IDWriteRenderingParams2* This = &this)
            {
                return MarshalFunction<_GetRenderingMode>(lpVtbl->GetRenderingMode)(
                    This
                );
            }
        }
        #endregion

        #region IDWriteRenderingParams1 Methods
        [return: NativeTypeName("FLOAT")]
        public float GetGrayscaleEnhancedContrast()
        {
            fixed (IDWriteRenderingParams2* This = &this)
            {
                return MarshalFunction<_GetGrayscaleEnhancedContrast>(lpVtbl->GetGrayscaleEnhancedContrast)(
                    This
                );
            }
        }
        #endregion

        #region Methods
        public DWRITE_GRID_FIT_MODE GetGridFitMode()
        {
            fixed (IDWriteRenderingParams2* This = &this)
            {
                return MarshalFunction<_GetGridFitMode>(lpVtbl->GetGridFitMode)(
                    This
                );
            }
        }
        #endregion

        #region Structs
        [Unmanaged]
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region IDWriteRenderingParams Fields
            public IntPtr GetGamma;

            public IntPtr GetEnhancedContrast;

            public IntPtr GetClearTypeLevel;

            public IntPtr GetPixelGeometry;

            public IntPtr GetRenderingMode;
            #endregion

            #region IDWriteRenderingParams1 Fields
            public IntPtr GetGrayscaleEnhancedContrast;
            #endregion

            #region Fields
            public IntPtr GetGridFitMode;
            #endregion
        }
        #endregion
    }
}
