﻿// (c) 2012-2016 Nick Hodge mailto:nhodge@mungr.com & Brendan Forster
// License: MS-PL

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BoxKite.Twitter;

namespace BoxKite.Twitter.Console
{
    public class FavouritesLiveFireTests
    {
        public async Task<bool> DoFavouritesTest(IUserSession session, List<int> testSeq)
        {
            var successStatus = true;
            try
            {
                // 1
                if (testSeq.Contains(1))
                {
                    ConsoleOutput.PrintMessage("5.1 Favourites\\GetFavourites", ConsoleColor.Gray);
                    var favourites1 = await session.GetFavourites(count:50);

                    if (favourites1.OK)
                    {
                        foreach (var t in favourites1)
                        {
                            ConsoleOutput.PrintMessage(
                                String.Format("From: {0} // Message: {1}", t.User.ScreenName, t.Text));
                        }
                    }
                    else
                        successStatus = false;
                }

                // 2
                if (testSeq.Contains(2))
                {
                    ConsoleOutput.PrintMessage("4.2 Favourites\\CreateFavourite", ConsoleColor.Gray);

                    var tweettofav = await session.GetTweet(336452534531137537);
                    var favourites2 = await session.CreateFavourite(tweettofav);

                    if (favourites2.OK)
                    {
                        ConsoleOutput.PrintMessage(
                                String.Format("From: {0} // Favourited Status: {1}", favourites2.User.ScreenName, favourites2.Favourited));
                    }
                    else
                        successStatus = false;
                }

                // 3
                if (testSeq.Contains(3))
                {
                    ConsoleOutput.PrintMessage("4.3 Favourites\\DeleteFavourite", ConsoleColor.Gray);

                    var tweettofav = await session.GetTweet(336452534531137537);
                    var favourites3 = await session.DeleteFavourite(tweettofav);

                    if (favourites3.OK)
                    {
                        ConsoleOutput.PrintMessage(
                                String.Format("From: {0} // Favourited Status: {1}", favourites3.User.ScreenName, favourites3.Favourited));
                    }
                    else
                        successStatus = false;
                }

            }
            catch (Exception e)
            {
                ConsoleOutput.PrintError(e.ToString());
                return false;
            }
            return successStatus;
        }
    }
}