﻿using System.Collections.Generic;

#if NET20 || NET30 || NET35

namespace Theraot.Core.System.Collections.Generic
{
    public interface ISet<T> : ICollection<T>
    {
        new bool Add(T item);

        void ExceptWith(IEnumerable<T> other);

        void IntersectWith(IEnumerable<T> other);

        bool IsProperSubsetOf(IEnumerable<T> other);

        bool IsProperSupersetOf(IEnumerable<T> other);

        bool IsSubsetOf(IEnumerable<T> other);

        bool IsSupersetOf(IEnumerable<T> other);

        bool Overlaps(IEnumerable<T> other);

        bool SetEquals(IEnumerable<T> other);

        void SymmetricExceptWith(IEnumerable<T> other);

        void UnionWith(IEnumerable<T> other);
    }
}

#endif