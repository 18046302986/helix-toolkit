﻿/*
The MIT License (MIT)
Copyright (c) 2018 Helix Toolkit contributors
*/
using SharpDX.Direct3D11;
using System;

namespace HelixToolkit.UWP.CommonDX
{
    using Logger;
    using Render;
    /// <summary>
    /// 
    /// </summary>
    public class SwapChainCompositionRenderHost : DefaultRenderHost
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SwapChainRenderHost"/> class.
        /// </summary>
        /// <param name="surface">The window PTR.</param>
        public SwapChainCompositionRenderHost()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SwapChainRenderHost"/> class.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="createRenderer">The create renderer.</param>
        public SwapChainCompositionRenderHost(Func<Device, IRenderer> createRenderer) : base(createRenderer)
        {
        }
        /// <summary>
        /// Creates the render buffer.
        /// </summary>
        /// <returns></returns>
        protected override IDX11RenderBufferProxy CreateRenderBuffer()
        {
            Logger.Log(LogLevel.Information, "DX11SwapChainCompositionRenderBufferProxy", nameof(SwapChainRenderHost));
            return new DX11SwapChainCompositionRenderBufferProxy(EffectsManager);
        }
    }
}