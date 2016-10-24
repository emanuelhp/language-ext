﻿using LanguageExt.TypeClasses;

namespace LanguageExt.Instances
{
    /// <summary>
    /// Equality and ordering
    /// </summary>
    public struct OrdBool : Ord<bool>
    {
        public static readonly OrdBool Inst = default(OrdBool);

        /// <summary>
        /// Equality test
        /// </summary>
        /// <param name="x">The left hand side of the equality operation</param>
        /// <param name="y">The right hand side of the equality operation</param>
        /// <returns>True if x and y are equal</returns>
        public bool Equals(bool x, bool y) =>
            x == y;

        /// <summary>
        /// Compare two values
        /// </summary>
        /// <param name="x">Left hand side of the compare operation</param>
        /// <param name="y">Right hand side of the compare operation</param>
        /// <returns>
        /// if x greater than y : 1
        /// 
        /// if x less than y    : -1
        /// 
        /// if x equals y       : 0
        /// </returns>
        public int Compare(bool x, bool y) =>
            x.CompareTo(y);
    }
}