// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>This interface performs all the same functions as the existing ID2D1CommandSink1 interface. It also enables access to ink rendering and gradient mesh rendering.</summary>
    [Guid("3BAB440E-417E-47DF-A2E2-BC0BE6A00916")]
    public /* blittable */ unsafe struct ID2D1CommandSink2
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1CommandSink2* This,
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1CommandSink2* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1CommandSink2* This
        );
        #endregion

        #region ID2D1CommandSink Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _BeginDraw(
            [In] ID2D1CommandSink2* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _EndDraw(
            [In] ID2D1CommandSink2* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _SetAntialiasMode(
            [In] ID2D1CommandSink2* This,
            [In] D2D1_ANTIALIAS_MODE antialiasMode
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _SetTags(
            [In] ID2D1CommandSink2* This,
            [In, ComAliasName("D2D1_TAG")] ulong tag1,
            [In, ComAliasName("D2D1_TAG")] ulong tag2
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _SetTextAntialiasMode(
            [In] ID2D1CommandSink2* This,
            [In] D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _SetTextRenderingParams(
            [In] ID2D1CommandSink2* This,
            [In] IDWriteRenderingParams* textRenderingParams = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _SetTransform(
            [In] ID2D1CommandSink2* This,
            [In, ComAliasName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _SetPrimitiveBlend(
            [In] ID2D1CommandSink2* This,
            [In] D2D1_PRIMITIVE_BLEND primitiveBlend
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _SetUnitMode(
            [In] ID2D1CommandSink2* This,
            [In] D2D1_UNIT_MODE unitMode
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _Clear(
            [In] ID2D1CommandSink2* This,
            [In, ComAliasName("D2D1_COLOR_F")] DXGI_RGBA* color = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _DrawGlyphRun(
            [In] ID2D1CommandSink2* This,
            [In, ComAliasName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin,
            [In] DWRITE_GLYPH_RUN* glyphRun,
            [In, Optional] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription,
            [In] ID2D1Brush* foregroundBrush,
            [In] DWRITE_MEASURING_MODE measuringMode
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _DrawLine(
            [In] ID2D1CommandSink2* This,
            [In, ComAliasName("D2D1_POINT_2F")] D2D_POINT_2F point0,
            [In, ComAliasName("D2D1_POINT_2F")] D2D_POINT_2F point1,
            [In] ID2D1Brush* brush,
            [In, ComAliasName("FLOAT")] float strokeWidth,
            [In] ID2D1StrokeStyle* strokeStyle = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _DrawGeometry(
            [In] ID2D1CommandSink2* This,
            [In] ID2D1Geometry* geometry,
            [In] ID2D1Brush* brush,
            [In, ComAliasName("FLOAT")] float strokeWidth,
            [In] ID2D1StrokeStyle* strokeStyle = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _DrawRectangle(
            [In] ID2D1CommandSink2* This,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* rect,
            [In] ID2D1Brush* brush,
            [In, ComAliasName("FLOAT")] float strokeWidth,
            [In] ID2D1StrokeStyle* strokeStyle = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _DrawBitmap(
            [In] ID2D1CommandSink2* This,
            [In] ID2D1Bitmap* bitmap,
            [In, Optional, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle,
            [In, ComAliasName("FLOAT")] float opacity,
            [In] D2D1_INTERPOLATION_MODE interpolationMode,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null,
            [In, ComAliasName("D2D1_MATRIX_4X4_F")] D2D_MATRIX_4X4_F* perspectiveTransform = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _DrawImage(
            [In] ID2D1CommandSink2* This,
            [In] ID2D1Image* image,
            [In, Optional, ComAliasName("D2D1_POINT_2F")] D2D_POINT_2F* targetOffset,
            [In, Optional, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* imageRectangle,
            [In] D2D1_INTERPOLATION_MODE interpolationMode,
            [In] D2D1_COMPOSITE_MODE compositeMode
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _DrawGdiMetafile(
            [In] ID2D1CommandSink2* This,
            [In] ID2D1GdiMetafile* gdiMetafile,
            [In, ComAliasName("D2D1_POINT_2F")] D2D_POINT_2F* targetOffset = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _FillMesh(
            [In] ID2D1CommandSink2* This,
            [In] ID2D1Mesh* mesh,
            [In] ID2D1Brush* brush
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _FillOpacityMask(
            [In] ID2D1CommandSink2* This,
            [In] ID2D1Bitmap* opacityMask,
            [In] ID2D1Brush* brush,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle = null,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _FillGeometry(
            [In] ID2D1CommandSink2* This,
            [In] ID2D1Geometry* geometry,
            [In] ID2D1Brush* brush,
            [In] ID2D1Brush* opacityBrush = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _FillRectangle(
            [In] ID2D1CommandSink2* This,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* rect,
            [In] ID2D1Brush* brush
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _PushAxisAlignedClip(
            [In] ID2D1CommandSink2* This,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* clipRect,
            [In] D2D1_ANTIALIAS_MODE antialiasMode
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _PushLayer(
            [In] ID2D1CommandSink2* This,
            [In] D2D1_LAYER_PARAMETERS1* layerParameters1,
            [In] ID2D1Layer* layer = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _PopAxisAlignedClip(
            [In] ID2D1CommandSink2* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _PopLayer(
            [In] ID2D1CommandSink2* This
        );
        #endregion

        #region ID2D1CommandSink1 Delegates
        /// <summary>This method is called if primitiveBlend value was added after Windows 8. SetPrimitiveBlend method is used for Win8 values (_SOURCE_OVER and _COPY).</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _SetPrimitiveBlend1(
            [In] ID2D1CommandSink2* This,
            [In] D2D1_PRIMITIVE_BLEND primitiveBlend
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _DrawInk(
            [In] ID2D1CommandSink2* This,
            [In] ID2D1Ink* ink,
            [In] ID2D1Brush* brush,
            [In] ID2D1InkStyle* inkStyle = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _DrawGradientMesh(
            [In] ID2D1CommandSink2* This,
            [In] ID2D1GradientMesh* gradientMesh
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _DrawGdiMetafile1(
            [In] ID2D1CommandSink2* This,
            [In] ID2D1GdiMetafile* gdiMetafile,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle = null,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null
        );
        #endregion

        #region IUnknown Methods
        [return: ComAliasName("HRESULT")]
        public int QueryInterface(
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: ComAliasName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: ComAliasName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region ID2D1CommandSink Methods
        [return: ComAliasName("HRESULT")]
        public int BeginDraw()
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_BeginDraw>(lpVtbl->BeginDraw)(
                    This
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int EndDraw()
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_EndDraw>(lpVtbl->EndDraw)(
                    This
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int SetAntialiasMode(
            [In] D2D1_ANTIALIAS_MODE antialiasMode
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_SetAntialiasMode>(lpVtbl->SetAntialiasMode)(
                    This,
                    antialiasMode
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int SetTags(
            [In, ComAliasName("D2D1_TAG")] ulong tag1,
            [In, ComAliasName("D2D1_TAG")] ulong tag2
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_SetTags>(lpVtbl->SetTags)(
                    This,
                    tag1,
                    tag2
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int SetTextAntialiasMode(
            [In] D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_SetTextAntialiasMode>(lpVtbl->SetTextAntialiasMode)(
                    This,
                    textAntialiasMode
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int SetTextRenderingParams(
            [In] IDWriteRenderingParams* textRenderingParams = null
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_SetTextRenderingParams>(lpVtbl->SetTextRenderingParams)(
                    This,
                    textRenderingParams
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int SetTransform(
            [In, ComAliasName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_SetTransform>(lpVtbl->SetTransform)(
                    This,
                    transform
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int SetPrimitiveBlend(
            [In] D2D1_PRIMITIVE_BLEND primitiveBlend
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_SetPrimitiveBlend>(lpVtbl->SetPrimitiveBlend)(
                    This,
                    primitiveBlend
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int SetUnitMode(
            [In] D2D1_UNIT_MODE unitMode
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_SetUnitMode>(lpVtbl->SetUnitMode)(
                    This,
                    unitMode
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int Clear(
            [In, ComAliasName("D2D1_COLOR_F")] DXGI_RGBA* color = null
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_Clear>(lpVtbl->Clear)(
                    This,
                    color
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int DrawGlyphRun(
            [In, ComAliasName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin,
            [In] DWRITE_GLYPH_RUN* glyphRun,
            [In, Optional] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription,
            [In] ID2D1Brush* foregroundBrush,
            [In] DWRITE_MEASURING_MODE measuringMode
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_DrawGlyphRun>(lpVtbl->DrawGlyphRun)(
                    This,
                    baselineOrigin,
                    glyphRun,
                    glyphRunDescription,
                    foregroundBrush,
                    measuringMode
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int DrawLine(
            [In, ComAliasName("D2D1_POINT_2F")] D2D_POINT_2F point0,
            [In, ComAliasName("D2D1_POINT_2F")] D2D_POINT_2F point1,
            [In] ID2D1Brush* brush,
            [In, ComAliasName("FLOAT")] float strokeWidth,
            [In] ID2D1StrokeStyle* strokeStyle = null
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_DrawLine>(lpVtbl->DrawLine)(
                    This,
                    point0,
                    point1,
                    brush,
                    strokeWidth,
                    strokeStyle
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int DrawGeometry(
            [In] ID2D1Geometry* geometry,
            [In] ID2D1Brush* brush,
            [In, ComAliasName("FLOAT")] float strokeWidth,
            [In] ID2D1StrokeStyle* strokeStyle = null
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_DrawGeometry>(lpVtbl->DrawGeometry)(
                    This,
                    geometry,
                    brush,
                    strokeWidth,
                    strokeStyle
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int DrawRectangle(
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* rect,
            [In] ID2D1Brush* brush,
            [In, ComAliasName("FLOAT")] float strokeWidth,
            [In] ID2D1StrokeStyle* strokeStyle = null
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_DrawRectangle>(lpVtbl->DrawRectangle)(
                    This,
                    rect,
                    brush,
                    strokeWidth,
                    strokeStyle
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int DrawBitmap(
            [In] ID2D1Bitmap* bitmap,
            [In, Optional, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle,
            [In, ComAliasName("FLOAT")] float opacity,
            [In] D2D1_INTERPOLATION_MODE interpolationMode,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null,
            [In, ComAliasName("D2D1_MATRIX_4X4_F")] D2D_MATRIX_4X4_F* perspectiveTransform = null
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_DrawBitmap>(lpVtbl->DrawBitmap)(
                    This,
                    bitmap,
                    destinationRectangle,
                    opacity,
                    interpolationMode,
                    sourceRectangle,
                    perspectiveTransform
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int DrawImage(
            [In] ID2D1Image* image,
            [In, Optional, ComAliasName("D2D1_POINT_2F")] D2D_POINT_2F* targetOffset,
            [In, Optional, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* imageRectangle,
            [In] D2D1_INTERPOLATION_MODE interpolationMode,
            [In] D2D1_COMPOSITE_MODE compositeMode
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_DrawImage>(lpVtbl->DrawImage)(
                    This,
                    image,
                    targetOffset,
                    imageRectangle,
                    interpolationMode,
                    compositeMode
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int DrawGdiMetafile(
            [In] ID2D1GdiMetafile* gdiMetafile,
            [In, ComAliasName("D2D1_POINT_2F")] D2D_POINT_2F* targetOffset = null
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_DrawGdiMetafile>(lpVtbl->DrawGdiMetafile)(
                    This,
                    gdiMetafile,
                    targetOffset
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int FillMesh(
            [In] ID2D1Mesh* mesh,
            [In] ID2D1Brush* brush
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_FillMesh>(lpVtbl->FillMesh)(
                    This,
                    mesh,
                    brush
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int FillOpacityMask(
            [In] ID2D1Bitmap* opacityMask,
            [In] ID2D1Brush* brush,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle = null,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_FillOpacityMask>(lpVtbl->FillOpacityMask)(
                    This,
                    opacityMask,
                    brush,
                    destinationRectangle,
                    sourceRectangle
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int FillGeometry(
            [In] ID2D1Geometry* geometry,
            [In] ID2D1Brush* brush,
            [In] ID2D1Brush* opacityBrush = null
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_FillGeometry>(lpVtbl->FillGeometry)(
                    This,
                    geometry,
                    brush,
                    opacityBrush
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int FillRectangle(
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* rect,
            [In] ID2D1Brush* brush
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_FillRectangle>(lpVtbl->FillRectangle)(
                    This,
                    rect,
                    brush
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int PushAxisAlignedClip(
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* clipRect,
            [In] D2D1_ANTIALIAS_MODE antialiasMode
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_PushAxisAlignedClip>(lpVtbl->PushAxisAlignedClip)(
                    This,
                    clipRect,
                    antialiasMode
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int PushLayer(
            [In] D2D1_LAYER_PARAMETERS1* layerParameters1,
            [In] ID2D1Layer* layer = null
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_PushLayer>(lpVtbl->PushLayer)(
                    This,
                    layerParameters1,
                    layer
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int PopAxisAlignedClip()
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_PopAxisAlignedClip>(lpVtbl->PopAxisAlignedClip)(
                    This
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int PopLayer()
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_PopLayer>(lpVtbl->PopLayer)(
                    This
                );
            }
        }
        #endregion

        #region ID2D1CommandSink1 Methods
        [return: ComAliasName("HRESULT")]
        public int SetPrimitiveBlend1(
            [In] D2D1_PRIMITIVE_BLEND primitiveBlend
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_SetPrimitiveBlend1>(lpVtbl->SetPrimitiveBlend1)(
                    This,
                    primitiveBlend
                );
            }
        }
        #endregion

        #region Methods
        [return: ComAliasName("HRESULT")]
        public int DrawInk(
            [In] ID2D1Ink* ink,
            [In] ID2D1Brush* brush,
            [In] ID2D1InkStyle* inkStyle = null
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_DrawInk>(lpVtbl->DrawInk)(
                    This,
                    ink,
                    brush,
                    inkStyle
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int DrawGradientMesh(
            [In] ID2D1GradientMesh* gradientMesh
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_DrawGradientMesh>(lpVtbl->DrawGradientMesh)(
                    This,
                    gradientMesh
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int DrawGdiMetafile1(
            [In] ID2D1GdiMetafile* gdiMetafile,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle = null,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null
        )
        {
            fixed (ID2D1CommandSink2* This = &this)
            {
                return MarshalFunction<_DrawGdiMetafile1>(lpVtbl->DrawGdiMetafile1)(
                    This,
                    gdiMetafile,
                    destinationRectangle,
                    sourceRectangle
                );
            }
        }
        #endregion

        #region Structs
        public /* blittable */ struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region ID2D1CommandSink Fields
            public IntPtr BeginDraw;

            public IntPtr EndDraw;

            public IntPtr SetAntialiasMode;

            public IntPtr SetTags;

            public IntPtr SetTextAntialiasMode;

            public IntPtr SetTextRenderingParams;

            public IntPtr SetTransform;

            public IntPtr SetPrimitiveBlend;

            public IntPtr SetUnitMode;

            public IntPtr Clear;

            public IntPtr DrawGlyphRun;

            public IntPtr DrawLine;

            public IntPtr DrawGeometry;

            public IntPtr DrawRectangle;

            public IntPtr DrawBitmap;

            public IntPtr DrawImage;

            public IntPtr DrawGdiMetafile;

            public IntPtr FillMesh;

            public IntPtr FillOpacityMask;

            public IntPtr FillGeometry;

            public IntPtr FillRectangle;

            public IntPtr PushAxisAlignedClip;

            public IntPtr PushLayer;

            public IntPtr PopAxisAlignedClip;

            public IntPtr PopLayer;
            #endregion

            #region ID2D1CommandSink1 Fields
            public IntPtr SetPrimitiveBlend1;
            #endregion

            #region Fields
            public IntPtr DrawInk;

            public IntPtr DrawGradientMesh;

            public IntPtr DrawGdiMetafile1;
            #endregion
        }
        #endregion
    }
}
