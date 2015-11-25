﻿using System;

namespace Patterns.Containers.Union
{
    /// <summary>
    /// Base class for all unions
    /// </summary>
    public abstract class Union : IEquatable<Union>
    {
        internal abstract object Value { get; }

        /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
        /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(Union other)
        {
            if (other == null) return false;
            return Value.Equals(other.Value);
        }

        /// <summary>Determines whether the specified object is equal to the current object.</summary>
        /// <returns>true if the specified object  is equal to the current object; otherwise, false.</returns>
        /// <param name="obj">The object to compare with the current object. </param>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            return Equals(obj as Union);
        }

        /// <summary>Serves as the default hash function. </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        /// <summary>
        /// Checks equality of `Union` instances
        /// </summary>
        public static bool operator ==(Union left, Union right)
        {
            return !ReferenceEquals(left, null) && left.Equals(right);
        }

        /// <summary>
        /// Checks inequality of `Union` instances
        /// </summary>
        public static bool operator !=(Union left, Union right)
        {
            return !(left == right);
        }
    }
}
