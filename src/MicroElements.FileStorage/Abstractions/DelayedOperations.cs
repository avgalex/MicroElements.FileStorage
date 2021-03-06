// Copyright (c) MicroElements. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Linq;
using ConcurrentCollections;

namespace MicroElements.FileStorage.Abstractions
{
    public abstract class DelayedOperations
    {
        protected ConcurrentHashSet<string> KeysForDelete { get; } = new ConcurrentHashSet<string>();

        protected internal IEnumerable<string> GetDeletedKeys()
        {
            return KeysForDelete.AsEnumerable();
        }

        protected internal void DeleteKey(string key)
        {
            KeysForDelete.TryRemove(key);
        }
    }
}
