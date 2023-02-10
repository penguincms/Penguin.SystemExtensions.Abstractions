using System.Collections.Generic;

namespace Penguin.SystemExtensions.Abstractions.Interfaces
{
    public interface IPropertyDictionary<TKey, TReturn>
    {
        int Count { get; }

        IEnumerable<TKey> Keys { get; }

        IEnumerable<TReturn> Values { get; }

        TReturn this[TKey key] { get; }

        bool ContainsKey(TKey key);

        IEnumerator<KeyValuePair<TKey, TReturn>> GetEnumerator();

        bool TryGetValue(TKey key, out TReturn value);
    }
}