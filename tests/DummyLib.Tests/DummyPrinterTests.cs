// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace Chaos.DummyLib;

using FluentAssertions;
using NUnit.Framework;

public class DummyPrinterTests
{
    [Test]
    public void Print_WithDummy_ShouldPrintDummyText()
    {
        var textWriterMock = new TextWriterMock();
        var text = "Test text!";
        var dummy = new Dummy(text);
        var dummyPrinter = new DummyPrinter(textWriterMock);

        textWriterMock.LastWriteLine.Should().BeNull();
        dummyPrinter.Print(dummy);

        textWriterMock.LastWriteLine.Should().Be(text);
    }

    [Test]
    public void Print_WithThreeDummies_ShouldPrintThreeDummies()
    {
        var textWriterMock = new TextWriterMock();
        var text = "Test text!";
        var dummy = new Dummy(text);
        var dummyPrinter = new DummyPrinter(textWriterMock);

        dummyPrinter.Print(dummy, dummy, dummy);

        textWriterMock.WriteLineCount.Should().Be(3);
    }
}
