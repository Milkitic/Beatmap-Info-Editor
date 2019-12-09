﻿using System;
using System.Collections.Generic;

namespace OSharp.Beatmap
{
    public static class StringUtil
    {
        public static string[] SpanSplit(this string str, string split)
        {
            var list = new List<string>();
            var span = str.AsSpan();
            var splitSpan = split.AsSpan();

            while (true)
            {
                var n = span.IndexOf(splitSpan);
                if (n > -1)
                {
                    list.Add(span.Slice(0, n).ToString());
                    span = span.Slice(n + span.Length);
                }
                else break;
            }

            //Marshal.AllocHGlobal(Int32.MaxValue);
            return list.ToArray();
        }

        public static int SpanIndexOf(this string str, string subStr)
        {
            var span = str.AsSpan();
            var subSpan = subStr.AsSpan();

            var n = span.IndexOf(subSpan);
            return n;
        }
    }
}