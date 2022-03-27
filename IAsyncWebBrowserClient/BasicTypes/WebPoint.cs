// Copyright (c) Oleg Zudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Zu.WebBrowser.BasicTypes
{
    public class WebPoint
    {
        public WebPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; } 
        public int Y { get; set; }

        public WebPoint Offset(int x, int y) => new WebPoint (X + x, Y + y);

        public override string ToString()
        {
            return $"WebPoint: {X}, {Y}";
        }

        public override bool Equals(Object obj)
        {
            return obj is WebPoint && this == (WebPoint)obj;
        }
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
        public bool Equals(WebPoint other) => Equals(this, other);
        bool Equals(WebPoint a, WebPoint b)
        {
            if (ReferenceEquals(a, b))
                return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;
            return a.X == b.X && a.Y == b.Y;
        }
        public static bool operator ==(WebPoint a, WebPoint b) => a.Equals(b);
        public static bool operator !=(WebPoint a, WebPoint b) => !a.Equals(b);
    }
}
