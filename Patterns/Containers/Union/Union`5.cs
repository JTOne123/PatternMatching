﻿namespace Patterns.Containers.Union
{
    /// <summary>
    /// Represents union of five types
    /// </summary>
    /// <typeparam name="T1">First type</typeparam>
    /// <typeparam name="T2">Second type</typeparam>
    /// <typeparam name="T3">Third type</typeparam>
    /// <typeparam name="T4">Fourth type</typeparam>
    /// <typeparam name="T5">Fifth type</typeparam>
    public abstract class Union<T1, T2, T3, T4, T5> : Union<T1, T2, T3, T4>
    {
        /// <summary>
        /// Represents case of union
        /// </summary>
        public sealed class Case5 : Union<T1, T2, T3, T4, T5>, UnionCase<T5>
        {
            internal override object Value { get; }

            /// <summary>
            /// Initializes an instance of case
            /// </summary>
            public Case5(T5 value)
            {
                Value = value;
            }

            /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            /// <param name="other">An object to compare with this object.</param>
            public bool Equals(UnionCase<T5> other)
            {
                return Value.Equals((other as Union).Value);
            }

            /// <summary>Determines whether the specified object is equal to the current object.</summary>
            /// <returns>true if the specified object  is equal to the current object; otherwise, false.</returns>
            /// <param name="obj">The object to compare with the current object. </param>
            public override bool Equals(object obj)
            {
                return Equals(obj as UnionCase<T5>) ? true : Equals(this, obj);
            }

            /// <summary>Serves as the default hash function. </summary>
            /// <returns>A hash code for the current object.</returns>
            public override int GetHashCode()
            {
                return Value.GetHashCode();
            }
        }

        /// <summary>
        /// Converts T5 instance into Union instance
        /// </summary>
        public static implicit operator Union<T1, T2, T3, T4, T5>(T5 value)
        {
            return new Case5(value);
        }
    }
}
