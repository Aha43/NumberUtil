using System;

namespace NumberUtil
{
    /// <summary>
    /// Constants (do not duplicate constants found in Math).
    /// </summary>
    public static class Constants
    {
        public static double SquareRootOf2 { get; } = Math.Sqrt(2);
        public static double SquareRootOf5 { get; } = Math.Sqrt(5);
        public static double GoldenRatio { get; } = (1 + SquareRootOf5) * 0.5;

    }
}
