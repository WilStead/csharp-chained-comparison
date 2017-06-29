using System;

namespace Chain
{
    /// <summary>
    /// Implements chained comparisons in C# (e.g. "x &lt; y &lt; z"). This struct is not meant to be
    /// instantiated directly in your code. Instances are generated automatically when you use
    /// chained comparisons.
    /// </summary>
    public struct ChainBool
    {
        /// <summary>
        /// The current <see cref="bool"/> value of the <see cref="ChainBool"/>.
        /// </summary>
        public bool Value { get; private set; }

        /// <summary>
        /// The value on the left-hand side of the operation.
        /// </summary>
        public IComparable Left { get; private set; }

        /// <summary>
        /// Instantiates a new instance of <see cref="ChainBool"/>. You are not meant to call this
        /// directly. Instances are generated automatically when you perform chained comparisons.
        /// </summary>
        /// <param name="boolValue">The <see cref="bool"/> value of this instance.</param>
        /// <param name="left">The value on the left-hand side of the operation.</param>
        public ChainBool(bool boolValue, IComparable left)
        {
            Value = boolValue;
            Left = left;
        }

        /// <summary>
        /// Implicit conversion between <see cref="ChainBool"/> and <see cref="bool"/>.
        /// </summary>
        public static implicit operator bool(ChainBool value) => value.Value;

        /// <summary>
        /// Less-than comparison between a <see cref="ChainBool"/> operand on the left-hand side, and
        /// a <see cref="ChainComparator"/> on the right-hand side.
        /// </summary>
        /// <param name="resultSoFar">
        /// A <see cref="ChainBool"/> representing the reseults of the chain comparison so far.
        /// </param>
        /// <param name="i">A <see cref="ChainComparator"/> representing the rest of the operation.</param>
        /// <returns>
        /// true if <paramref name="resultSoFar"/> has a value less than <paramref name="i"/>;
        /// otherwise, false.
        /// </returns>
        public static ChainBool operator <(ChainBool resultSoFar, ChainComparator i) =>
            new ChainBool(resultSoFar.Value && resultSoFar.Left.CompareTo(i.Value) < 0, i.Value);

        /// <summary>
        /// Less-than-or-equal comparison between a <see cref="ChainBool"/> operand on the left-hand
        /// side, and a <see cref="ChainComparator"/> on the right-hand side.
        /// </summary>
        /// <param name="resultSoFar">
        /// A <see cref="ChainBool"/> representing the reseults of the chain comparison so far.
        /// </param>
        /// <param name="i">A <see cref="ChainComparator"/> representing the rest of the operation.</param>
        /// <returns>
        /// true if <paramref name="resultSoFar"/> has a value less than or equal to <paramref
        /// name="i"/>; otherwise, false.
        /// </returns>
        public static ChainBool operator <=(ChainBool resultSoFar, ChainComparator i) =>
            new ChainBool(resultSoFar.Value && resultSoFar.Left.CompareTo(i.Value) <= 0, i.Value);

        /// <summary>
        /// Greater-than comparison between a <see cref="ChainBool"/> operand on the left-hand side,
        /// and a <see cref="ChainComparator"/> on the right-hand side.
        /// </summary>
        /// <param name="resultSoFar">
        /// A <see cref="ChainBool"/> representing the reseults of the chain comparison so far.
        /// </param>
        /// <param name="i">A <see cref="ChainComparator"/> representing the rest of the operation.</param>
        /// <returns>
        /// true if <paramref name="resultSoFar"/> has a value greater than <paramref name="i"/>;
        /// otherwise, false.
        /// </returns>
        public static ChainBool operator >(ChainBool resultSoFar, ChainComparator i) =>
            new ChainBool(resultSoFar.Value && resultSoFar.Left.CompareTo(i.Value) > 0, i.Value);

        /// <summary>
        /// Greater-than-or-equal comparison between a <see cref="ChainBool"/> operand on the
        /// left-hand side, and a <see cref="ChainComparator"/> on the right-hand side.
        /// </summary>
        /// <param name="resultSoFar">
        /// A <see cref="ChainBool"/> representing the reseults of the chain comparison so far.
        /// </param>
        /// <param name="i">A <see cref="ChainComparator"/> representing the rest of the operation.</param>
        /// <returns>
        /// true if <paramref name="resultSoFar"/> has a value greater than or equal to <paramref
        /// name="i"/>; otherwise, false.
        /// </returns>
        public static ChainBool operator >=(ChainBool resultSoFar, ChainComparator i) =>
            new ChainBool(resultSoFar.Value && resultSoFar.Left.CompareTo(i.Value) >= 0, i.Value);

        /// <summary>
        /// Returns a value indicating whether this instance is equal to a specified object.
        /// </summary>
        /// <param name="obj">A value to compare to this instance.</param>
        /// <returns>
        /// true if <paramref name="obj"/> is a <see cref="bool"/> and has the same value as this
        /// instance; otherwise, false.
        /// </returns>
        public override bool Equals(object obj) => Value.Equals(obj);

        /// <summary>
        /// Equality comparison between a <see cref="ChainBool"/> operand on the left-hand side, and
        /// a <see cref="ChainComparator"/> on the right-hand side.
        /// </summary>
        /// <param name="resultSoFar">
        /// A <see cref="ChainBool"/> representing the reseults of the chain comparison so far.
        /// </param>
        /// <param name="i">A <see cref="ChainComparator"/> representing the rest of the operation.</param>
        /// <returns>
        /// true if <paramref name="resultSoFar"/> is equal to <paramref name="i"/>; otherwise, false.
        /// </returns>
        public static ChainBool operator ==(ChainBool resultSoFar, ChainComparator i) =>
            new ChainBool(resultSoFar.Value && resultSoFar.Left.Equals(i.Value), i.Value);

        /// <summary>
        /// Inequality comparison between a <see cref="ChainBool"/> operand on the left-hand side,
        /// and a <see cref="ChainComparator"/> on the right-hand side.
        /// </summary>
        /// <param name="resultSoFar">
        /// A <see cref="ChainBool"/> representing the reseults of the chain comparison so far.
        /// </param>
        /// <param name="i">A <see cref="ChainComparator"/> representing the rest of the operation.</param>
        /// <returns>
        /// true if <paramref name="resultSoFar"/> is unequal to <paramref name="i"/>; otherwise, false.
        /// </returns>
        public static ChainBool operator !=(ChainBool resultSoFar, ChainComparator i) =>
            new ChainBool(resultSoFar.Value && !resultSoFar.Left.Equals(i.Value), i.Value);

        /// <summary>
        /// Negation unary operation of a <see cref="ChainBool"/> operand.
        /// </summary>
        /// <param name="resultSoFar">A <see cref="ChainBool"/> to be negated.</param>
        /// <returns>
        /// A <see cref="ChainBool"/> whose <see cref="Value"/> has the opposite true/false value of
        /// <paramref name="resultSoFar"/>.
        /// </returns>
        public static ChainBool operator !(ChainBool resultSoFar) =>
            new ChainBool(!resultSoFar.Value, resultSoFar.Left);

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current <see cref="ChainBool"/>.</returns>
        public override int GetHashCode() => Value.GetHashCode();

        /// <summary>
        /// Converts the value of this instance to its equivalent string representation, based on its
        /// <see cref="Value"/> (either "True" or "False").
        /// </summary>
        /// <returns>
        /// <see cref="bool.TrueString"/> if <see cref="Value"/> is true, or <see
        /// cref="bool.FalseString"/> if <see cref="Value"/> is false.
        /// </returns>
        public override string ToString() => Value.ToString();
    }
}
