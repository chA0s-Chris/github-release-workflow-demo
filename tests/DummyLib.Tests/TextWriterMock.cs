// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace Chaos.DummyLib;

using System.Text;

public class TextWriterMock : TextWriter
{
    public override Encoding Encoding => Encoding.Default;

    public String? LastWriteLine { get; private set; }

    public Int32 WriteLineCount { get; private set; }

    public override void WriteLine(String? value)
    {
        LastWriteLine = value;
        WriteLineCount++;
        base.WriteLine(value);
    }
}
