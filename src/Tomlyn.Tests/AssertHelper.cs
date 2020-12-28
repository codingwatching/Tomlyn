// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license. 
// See license.txt file in the project root for full license information.

using System;
using NUnit.Framework;

namespace Tomlyn.Tests
{
    public static class AssertHelper
    {
        public static void AreEqualNormalizeNewLine(string expected, string actual, string message = null)
        {
            expected = NormalizeEndOfLine(expected);
            actual = NormalizeEndOfLine(actual);
            if (expected != actual)
            {
                Console.Write($"Actual:\n{actual}");
                Console.Write($"\nExpected:\n{expected}");
            }
            Assert.AreEqual(expected, actual, message);
        }

        public static string NormalizeEndOfLine(string text)
        {
            return text.Replace("\r\n", "\n");
        }
    }
}