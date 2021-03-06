﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace LinqToDB.Common.Internal.Cache
{
	internal class CacheEntryStack
	{
		private readonly CacheEntryStack? _previous;
		private readonly CacheEntry? _entry;

		private CacheEntryStack()
		{
		}

		private CacheEntryStack(CacheEntryStack previous, CacheEntry entry)
		{
			if (previous == null)
			{
				throw new ArgumentNullException(nameof(previous));
			}

			_previous = previous;
			_entry = entry;
		}

		public static CacheEntryStack Empty { get; } = new CacheEntryStack();

		public CacheEntryStack Push(CacheEntry c)
		{
			return new CacheEntryStack(this, c);
		}

		public CacheEntry? Peek()
		{
			return _entry;
		}
	}
}
