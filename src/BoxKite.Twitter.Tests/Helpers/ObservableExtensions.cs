﻿// (c) 2012-2016 Nick Hodge mailto:nhodge@mungr.com & Brendan Forster
// License: MS-PL

using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using Microsoft.Reactive.Testing;

namespace BoxKite.Twitter.Tests
{
    public static class ObservableExtensions
    {
        public static IEnumerable<Recorded<Notification<T>>> GetMessagesOfType<T>(this ITestableObserver<T> observer, NotificationKind kind)
        {
            return observer.Messages.Where(m => m.Value.Kind == NotificationKind.OnNext);
        }
    }
}
