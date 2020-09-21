﻿// This file is part of Among Us Director project.
// 
// Copyright 2020 Emzi0767
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Runtime.InteropServices;

namespace Emzi0767.AmongUsDirector
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct PeNtHeader
    {
        // PE..  50 45 00 00
        [FieldOffset(0x00)]
        public int Signature;

        [FieldOffset(0x04)]
        public PeNtFileHeader FileHeader;

        [FieldOffset(0x18 /* 0x04 + 0x14 - latter is sizeof(PeNtFileHeader) */)]
        public PeNtOptionalHeader OptionalHeader;
    } // size: 0x0210 = 0x04 + 0x14 + 0xE0
}
