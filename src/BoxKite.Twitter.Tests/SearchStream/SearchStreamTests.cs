﻿// (c) 2012-2014 Nick Hodge mailto:hodgenick@gmail.com & Brendan Forster
// License: MS-PL

using System;
using System.ComponentModel.Design;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using BoxKite.Twitter.Models;
using FluentAssertions;
using Microsoft.Reactive.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BoxKite.Twitter.Tests
{
    [TestClass]
    public class SearchStreamTests : ReactiveTest
    {
        private readonly TestableUserSession session = new TestableUserSession();
  
        [TestMethod]
        public async Task SearchStream1_incoming_Tweets()
        {
            session.Returns(await Json.FromFile("data\\searchstream\\searchstream1initial.txt"));
            var searchstream1 = session.StartSearchStream();

            searchstream1.FoundTweets.Subscribe(t =>
                                             {
                                                 Assert.IsNotNull(t);
                                                 t.Text.Should().NotBeNullOrEmpty();
                                                 Assert.IsInstanceOfType(t.User,typeof(User));
                                                 t.User.Should().NotBeNull();
                                                 t.User.ScreenName.Should().NotBeNullOrEmpty();
                                             }
            );

            searchstream1.Start();

            var IsActive = true;
            searchstream1.SearchStreamActive.Where(status => status.Equals(false)).Subscribe(t =>{IsActive = false;});

            while (IsActive)
            {
            }
        }

    }
}
