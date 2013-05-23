#BoxKite.Twitter
![logo](https://raw.github.com/nickhodge/BoxKite.Twitter/master/artwork/Boxkite-Logo-github.png "Logo")

Portable Twitter Client Library using Reactive Extensions library and Async/Await for the .NET 4.5 platform (and above)

##Details

Supports and Incorporates:
* Userstreams
* Twitter 1.1 REST API
* Test suite (both Mocked UnitTests and "LiveFire" Tests (online) with broad coverage of Library

##Goals:
* 100% Twitter API 1.1 coverage suitable for a client application
* 100% Test Suite coverage both Mocked and LiveFire
* Supporting .NET 4.5, Windows 8 and Windows Phone 8 development
* Distribute as a NuGet package
* Async/Await where appropriate (single response)
* Reactive extensions (.Subscribe) for Streamed data where appropriate.
* Create a simple "TwitterConnection" object that maintains & manages the connection to Twitter. From this, subscribe to streams; object manages stuff

##To Build:
* VS2012 with latest NuGet supporting PCLs (Portable Class Libraries)
* You will also need to separately download & build [PCLContrib](http://pclcontrib.codeplex.com/) as this is not in NuGet

##API Coverage, With Tests & Intellisense Comments
[From Twitter REST API v1.1](https://dev.twitter.com/docs/api/1.1)

- [x] Timelines
- [x] Tweets 
- [x] [status/update_with_media](https://dev.twitter.com/docs/api/1.1/post/statuses/update_with_media)
- [x] Search
- [x] Saved Searches
- [x] User Streaming: [GET userstreams](https://dev.twitter.com/docs/streaming-apis/streams/user) 
- [x] Search via Streaming [POST status/filter](https://dev.twitter.com/docs/api/1.1/post/statuses/filter)
- [x] Direct Messages
- [x] Friends and Followers
- [x] Users
- [x] Suggested Users
- [x] Favorites
- [x] Lists 
- [x] Places and Geo
- [x] Trends
- [x] Spam Reporting
- [x] oauth
- [x] API rate limits

##Tests:
* 112 test methods with average of 4 assertion tests each
* Both Twitter API 1.1 and Userstream Unit Tests
* 45 "Live Fire Tests". Included as a separate project, it is engaged via the Console; uses a real Twitter Account to exercise the API. Configurable Test series, individual tests that can be run.
* Test source is JSON from [dev.twitter.com](https://dev.twitter.com/) and where innaccurate on the site, taken from live data or corrected to match live data.
* Error response type testing (eg: 429 rate_limits) & generic decode tests included

## Components Used

* Without [Newtonsoft Json.NET](http://json.net) this library would not exist (MIT License)
* Microsoft's Open sourced .NET [Reactive Extensions](https://rx.codeplex.com/) (Apache License 2.0)
* Portable version of the HTTP Client Libraries from the Microsoft ASP.NET WebAPI team [HTTP Client Libraries](http://nuget.org/packages/Microsoft.Net.Http/2.1.3-beta)  (sourced from NuGet, currently Not Support DotNet License)
* You will also need to separately download & build [PCLContrib](http://pclcontrib.codeplex.com/) (MS-PL)
* Great little collection of extension methods that make writing UnitTests easier [FluentAssertions](http://fluentassertions.codeplex.com/) (MS-PL) 

##Broad To Dos:
- [ ] "Life Fire" testing of Lists needs work, as does parameter checking. UnitTests pass ok
- [ ] Sematics of D/M and others in status updates
- [ ] [Attribute:street_address](https://dev.twitter.com/docs/api/1.1/get/geo/search) in PlacesGeo Attributes for Places (these seem to be street address details)
- [ ] WIKI documentation
- [ ] architecture of a TwitterConnection object
- [ ] management of API limits within the TwitterConnection
- [ ] abstract as .Subscribe observable lists whilst do the cursor/pagination underneath of the objects from the service
- [ ] DDD Tweets, Users, Following, Followers, Lists, Favourites within the TwitterConnection

##Out of Scope:
- [Contributors/Contributees](https://dev.twitter.com/docs/platform-objects/tweets#obj-contributors) As yet, not in wild 
"This field will only be populated if the user has contributors enabled on his or her account � this is a beta feature that is not yet generally available to all." 
- GET Help/* endpoints
- SiteStreams because I am no masochist nor do I have access to it.
- oauth2 tokens for Application-based APIs
- [oembed seems for web sites specific inclusion rather than this API?](https://dev.twitter.com/docs/api/1.1/get/statuses/oembed)
- [User Profile banner stuff](https://dev.twitter.com/docs/api/1.1/post/account/update_profile_banner) because what even are they? 

##Copyright, License Information

[BoxKite.Twitter](https://github.com/shiftkey/BoxKite.Twitter) was started by Brendan Forster ([https://github.com/shiftkey/](https://github.com/shiftkey/)) as a part of a larger Twitter project now on permanent Hiatus.

BoxKite.Twitter is Licensed under: 
[MS-PL] (http://opensource.org/licenses/MS-PL)

Copyright: 
[Nick Hodge](https://github.com/nickhodge/) and [Brendan Forster](https://github.com/shiftkey/) 2012-2013

## Why BoxKite?

![boxkite](https://raw.github.com/nickhodge/BoxKite.Twitter/master/src/BoxKite.Twitter/Assets/logo-wide.png "Logo")

Everyone likes flying kites, right? The original inventor of the [box kite](http://en.wikipedia.org/wiki/Box_kite) was [Lawrence Hargrave](http://en.wikipedia.org/wiki/Lawrence_Hargrave). In 1893. And he was an Australian. Sadly missing from our newer plastic yet colourful currency, Lawrence was one of those guys who helped manned flight become a reality.

And keeping with the Twitter bird theme, flying and airborne I created a fork of the MahTweets twitter client in late 2011 and named it [MahTweets Lawrence Hargrave](https://github.com/nickhodge/MahTweets.LawrenceHargrave).

In mid 2012, Brendan needed a code name for a new Twitter "thing" he was working on. Keeping in this flighty theme, I named his app "BoxKite". For posterity's sake, I have absconded with Brendan's code, and my contributed codename (and a nifty icon) and have dubbed this project BoxKite.