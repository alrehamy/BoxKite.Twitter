// (c) 2012-2014 Nick Hodge mailto:hodgenick@gmail.com & Brendan Forster
// License: MS-PL

using System;
using System.Net.Http;
using System.Reactive.Subjects;
using System.Threading;
using System.Threading.Tasks;
using BoxKite.Twitter.Models;

namespace BoxKite.Twitter
{
    public interface ISearchStream : IDisposable
    {
        IObservable<Tweet> FoundTweets { get; }
        Subject<StreamSearchRequest> SearchRequests { get; }
        TwitterParametersCollection SearchParameters { get; set; }
        Func<Task<HttpResponseMessage>> CreateOpenConnection { get; set; }
        CancellationTokenSource CancelSearchStream { get; set; }
        IObservable<bool> SearchStreamActive { get; }
        void Start();
        void Stop();
    }
}