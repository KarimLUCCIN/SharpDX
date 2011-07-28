﻿// Copyright (c) 2010-2011 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

namespace SharpDX.XACT3
{
    /// <summary>
    /// Generic notification event.
    /// </summary>
    public abstract class EngineEvent : EventArgs
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public NotificationType Type { get; set; }

        /// <summary>	
        /// Timestamp of notification, in milliseconds.
        /// </summary>	
        /// <unmanaged>int timeStamp</unmanaged>	
        public int TimeStamp;

        /// <summary>	
        /// No documentation.	
        /// </summary>	
        /// <unmanaged>void* pvContext</unmanaged>	
        public Object Context;
    }

    /// <summary>
    /// Cue events parameters.
    /// </summary>
    public class CueEvent : EngineEvent
    {
        public int CueIndex { get; set; }

        public Cue Cue { get; set; }

        public SoundBank SoundBank { get; set; }
    }
}
