using System;

namespace Chain
{
    /// <summary>
    /// Implements chained comparisons in C# (e.g. "x &lt; y &lt; z"). This struct is not meant to be
    /// instantiated directly in your code. Instances are generated automatically when you use
    /// chained comparisons.
    /// </summary>
    public struct ChainComparator
    {
        /// <summary>
        /// The current value of the <see cref="ChainComparator"/>.
        /// </summary>
        public IComparable Value { get; set; }

        /// <summary>
        /// Implicit conversion between <see cref="byte"/> and <see cref="ChainComparator"/>.
        /// </summary>
        public static implicit operator ChainComparator(byte value) => new ChainComparator { Value = value };

        /// <summary>
        /// Implicit conversion between <see cref="ChainComparator"/> and <see cref="byte"/>.
        /// </summary>
        public static implicit operator byte(ChainComparator value) => (byte)value.Value;

        /// <summary>
        /// Implicit conversion between <see cref="sbyte"/> and <see cref="ChainComparator"/>.
        /// </summary>
        public static implicit operator ChainComparator(sbyte value) => new ChainComparator { Value = value };

        /// <summary>
        /// Implicit conversion between <see cref="ChainComparator"/> and <see cref="sbyte"/>.
        /// </summary>
        public static implicit operator sbyte(ChainComparator value) => (sbyte)value.Value;

        /// <summary>
        /// Implicit conversion between <see cref="short"/> and <see cref="ChainComparator"/>.
        /// </summary>
        public static implicit operator ChainComparator(short value) => new ChainComparator { Value = value };

        /// <summary>
        /// Implicit conversion between <see cref="ChainComparator"/> and <see cref="short"/>.
        /// </summary>
        public static implicit operator short(ChainComparator value) => (short)value.Value;

        /// <summary>
        /// Implicit conversion between <see cref="ushort"/> and <see cref="ChainComparator"/>.
        /// </summary>
        public static implicit operator ChainComparator(ushort value) => new ChainComparator { Value = value };

        /// <summary>
        /// Implicit conversion between <see cref="ChainComparator"/> and <see cref="ushort"/>.
        /// </summary>
        public static implicit operator ushort(ChainComparator value) => (ushort)value.Value;

        /// <summary>
        /// Implicit conversion between <see cref="int"/> and <see cref="ChainComparator"/>.
        /// </summary>
        public static implicit operator ChainComparator(int value) => new ChainComparator { Value = value };

        /// <summary>
        /// Implicit conversion between <see cref="ChainComparator"/> and <see cref="int"/>.
        /// </summary>
        public static implicit operator int(ChainComparator value) => (int)value.Value;

        /// <summary>
        /// Implicit conversion between <see cref="uint"/> and <see cref="ChainComparator"/>.
        /// </summary>
        public static implicit operator ChainComparator(uint value) => new ChainComparator { Value = value };

        /// <summary>
        /// Implicit conversion between <see cref="ChainComparator"/> and <see cref="uint"/>.
        /// </summary>
        public static implicit operator uint(ChainComparator value) => (uint)value.Value;

        /// <summary>
        /// Implicit conversion between <see cref="long"/> and <see cref="ChainComparator"/>.
        /// </summary>
        public static implicit operator ChainComparator(long value) => new ChainComparator { Value = value };

        /// <summary>
        /// Implicit conversion between <see cref="ChainComparator"/> and <see cref="long"/>.
        /// </summary>
        public static implicit operator long(ChainComparator value) => (long)value.Value;

        /// <summary>
        /// Implicit conversion between <see cref="ulong"/> and <see cref="ChainComparator"/>.
        /// </summary>
        public static implicit operator ChainComparator(ulong value) => new ChainComparator { Value = value };

        /// <summary>
        /// Implicit conversion between <see cref="ChainComparator"/> and <see cref="ulong"/>.
        /// </summary>
        public static implicit operator ulong(ChainComparator value) => (ulong)value.Value;

        /// <summary>
        /// Implicit conversion between <see cref="float"/> and <see cref="ChainComparator"/>.
        /// </summary>
        public static implicit operator ChainComparator(float value) => new ChainComparator { Value = value };

        /// <summary>
        /// Implicit conversion between <see cref="ChainComparator"/> and <see cref="float"/>.
        /// </summary>
        public static implicit operator float(ChainComparator value) => (float)value.Value;

        /// <summary>
        /// Implicit conversion between <see cref="double"/> and <see cref="ChainComparator"/>.
        /// </summary>
        public static implicit operator ChainComparator(double value) => new ChainComparator { Value = value };

        /// <summary>
        /// Implicit conversion between <see cref="ChainComparator"/> and <see cref="double"/>.
        /// </summary>
        public static implicit operator double(ChainComparator value) => (double)value.Value;

        /// <summary>
        /// Implicit conversion between <see cref="decimal"/> and <see cref="ChainComparator"/>.
        /// </summary>
        public static implicit operator ChainComparator(decimal value) => new ChainComparator { Value = value };

        /// <summary>
        /// Implicit conversion between <see cref="ChainComparator"/> and <see cref="decimal"/>.
        /// </summary>
        public static implicit operator decimal(ChainComparator value) => (decimal)value.Value;

        /// <summary>
        /// Implicit conversion between <see cref="char"/> and <see cref="ChainComparator"/>.
        /// </summary>
        public static implicit operator ChainComparator(char value) => new ChainComparator { Value = value };

        /// <summary>
        /// Implicit conversion between <see cref="ChainComparator"/> and <see cref="char"/>.
        /// </summary>
        public static implicit operator char(ChainComparator value) => (char)value.Value;

        /// <summary>
        /// Implicit conversion between <see cref="string"/> and <see cref="ChainComparator"/>.
        /// </summary>
        public static implicit operator ChainComparator(string value) => new ChainComparator { Value = value };

        /// <summary>
        /// Implicit conversion between <see cref="ChainComparator"/> and <see cref="string"/>.
        /// </summary>
        public static implicit operator string(ChainComparator value) => (string)value.Value;

        /// <summary>
        /// Less-than comparison between <see cref="ChainComparator"/> values.
        /// </summary>
        /// <param name="left">
        /// A <see cref="ChainComparator"/> representing the left-hand side of the comparison.
        /// </param>
        /// <param name="right">
        /// A <see cref="ChainComparator"/> representing the right-hand side of the comparison.
        /// </param>
        /// <returns>
        /// true if <paramref name="left"/> has a value less than <paramref name="right"/>;
        /// otherwise, false.
        /// </returns>
        public static ChainBool operator <(ChainComparator left, ChainComparator right) =>
            new ChainBool(left.Value.CompareTo(right.Value) < 0, right.Value);

        /// <summary>
        /// Less-than-or-equal comparison between <see cref="ChainComparator"/> values.
        /// </summary>
        /// <param name="left">
        /// A <see cref="ChainComparator"/> representing the left-hand side of the comparison.
        /// </param>
        /// <param name="right">
        /// A <see cref="ChainComparator"/> representing the right-hand side of the comparison.
        /// </param>
        /// <returns>
        /// true if <paramref name="left"/> has a value less than or equal to <paramref
        /// name="right"/>; otherwise, false.
        /// </returns>
        public static ChainBool operator <=(ChainComparator left, ChainComparator right) =>
            new ChainBool(left.Value.CompareTo(right.Value) <= 0, right.Value);

        /// <summary>
        /// Greater-than comparison between <see cref="ChainComparator"/> values.
        /// </summary>
        /// <param name="left">
        /// A <see cref="ChainComparator"/> representing the left-hand side of the comparison.
        /// </param>
        /// <param name="right">
        /// A <see cref="ChainComparator"/> representing the right-hand side of the comparison.
        /// </param>
        /// <returns>
        /// true if <paramref name="left"/> has a value greater than <paramref name="right"/>;
        /// otherwise, false.
        /// </returns>
        public static ChainBool operator >(ChainComparator left, ChainComparator right) =>
            new ChainBool(left.Value.CompareTo(right.Value) > 0, right.Value);

        /// <summary>
        /// Greater-than-or-equal comparison between <see cref="ChainComparator"/> values.
        /// </summary>
        /// <param name="left">
        /// A <see cref="ChainComparator"/> representing the left-hand side of the comparison.
        /// </param>
        /// <param name="right">
        /// A <see cref="ChainComparator"/> representing the right-hand side of the comparison.
        /// </param>
        /// <returns>
        /// true if <paramref name="left"/> has a value greater than or equal to <paramref
        /// name="right"/>; otherwise, false.
        /// </returns>
        public static ChainBool operator >=(ChainComparator left, ChainComparator right) =>
            new ChainBool(left.Value.CompareTo(right.Value) >= 0, right.Value);

        /// <summary>
        /// Returns a value indicating whether this instance is equal to a specified object.
        /// </summary>
        /// <param name="obj">A value to compare to this instance.</param>
        /// <returns>
        /// true if <paramref name="obj"/> is equal to the current <see cref="ChainComparator"/>
        /// instance; otherwise, false.
        /// </returns>
        public override bool Equals(object obj) => Value.Equals(obj);

        /// <summary>
        /// Equality comparison between <see cref="ChainComparator"/> values.
        /// </summary>
        /// <param name="left">
        /// A <see cref="ChainComparator"/> representing the left-hand side of the comparison.
        /// </param>
        /// <param name="right">
        /// A <see cref="ChainComparator"/> representing the right-hand side of the comparison.
        /// </param>
        /// <returns>
        /// true if <paramref name="left"/> is equal to <paramref name="right"/>; otherwise, false.
        /// </returns>
        public static ChainBool operator ==(ChainComparator left, ChainComparator right) =>
            new ChainBool(left.Value.Equals(right.Value), right.Value);

        /// <summary>
        /// Inequality comparison between <see cref="ChainComparator"/> values.
        /// </summary>
        /// <param name="left">
        /// A <see cref="ChainComparator"/> representing the left-hand side of the comparison.
        /// </param>
        /// <param name="right">
        /// A <see cref="ChainComparator"/> representing the right-hand side of the comparison.
        /// </param>
        /// <returns>
        /// true if <paramref name="left"/> is unequal to <paramref name="right"/>; otherwise, false.
        /// </returns>
        public static ChainBool operator !=(ChainComparator left, ChainComparator right) =>
            new ChainBool(!left.Value.Equals(right.Value), right.Value);

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current <see cref="ChainComparator"/>.</returns>
        public override int GetHashCode() => Value.GetHashCode();

        /// <summary>
        /// Returns a string that represents the current <see cref="ChainComparator"/> instance's
        /// <see cref="Value"/>.
        /// </summary>
        /// <returns>
        /// A string that represents the current <see cref="ChainComparator"/> instance's <see cref="Value"/>.
        /// </returns>
        public override string ToString() => Value.ToString();
    }
}
