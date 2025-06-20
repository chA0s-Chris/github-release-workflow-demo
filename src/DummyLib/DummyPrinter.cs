// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace Chaos.DummyLib;

public class DummyPrinter
{
    private readonly TextWriter _textWriter;

    public DummyPrinter(TextWriter? textWriter = null)
    {
        _textWriter = textWriter ?? Console.Out;
    }

    public void Print(Dummy dummy)
    {
        ArgumentNullException.ThrowIfNull(dummy);
        _textWriter.WriteLine(dummy.Text);
    }

    public void Print(params Dummy[] dummies)
    {
        ArgumentNullException.ThrowIfNull(dummies);
        foreach (var dummy in dummies)
        {
            Print(dummy);
        }
    }
}
