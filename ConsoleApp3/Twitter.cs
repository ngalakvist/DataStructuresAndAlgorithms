using System.Collections.Generic;

namespace ConsoleApp3
{
  //https://leetcode.com/problems/design-twitter/
  /*
   * Design a simplified version of Twitter where users can post tweets, follow/unfollow another user, and is able to see the 10 most recent tweets in the user's news feed.

Implement the Twitter class:

Twitter() Initializes your twitter object.
void postTweet(int userId, int tweetId) Composes a new tweet with ID tweetId by the user userId. Each call to this function will be made with a unique tweetId.
List<Integer> getNewsFeed(int userId) Retrieves the 10 most recent tweet IDs in the user's news feed. Each item in the news feed must be posted by users who the user followed or by the user themself. Tweets must be ordered from most recent to least recent.
void follow(int followerId, int followeeId) The user with ID followerId started following the user with ID followeeId.
void unfollow(int followerId, int followeeId) The user with ID followerId started unfollowing the user with ID followeeId.
 

Example 1:

Input
["Twitter", "postTweet", "getNewsFeed", "follow", "postTweet", "getNewsFeed", "unfollow", "getNewsFeed"]
[[], [1, 5], [1], [1, 2], [2, 6], [1], [1, 2], [1]]
Output
[null, null, [5], null, null, [6, 5], null, [5]]

Explanation
Twitter twitter = new Twitter();
twitter.postTweet(1, 5); // User 1 posts a new tweet (id = 5).
twitter.getNewsFeed(1);  // User 1's news feed should return a list with 1 tweet id -> [5]. return [5]
twitter.follow(1, 2);    // User 1 follows user 2.
twitter.postTweet(2, 6); // User 2 posts a new tweet (id = 6).
twitter.getNewsFeed(1);  // User 1's news feed should return a list with 2 tweet ids -> [6, 5]. Tweet id 6 should precede tweet id 5 because it is posted after tweet id 5.
twitter.unfollow(1, 2);  // User 1 unfollows user 2.
twitter.getNewsFeed(1);  // User 1's news feed should return a list with 1 tweet id -> [5], since user 1 is no longer following user 2.
   */
  public class Twitter
  {
    private Dictionary<int, HashSet<int>> followMap;
    public Dictionary<int, HashSet<int>> FollowMap { get => followMap; set => followMap = value; }

    private Dictionary<int, List<int>> tweetMap;
    public Dictionary<int, List<int>> TweetMap { get => tweetMap; set => tweetMap = value; }

    public Twitter()
    {
      FollowMap = new Dictionary<int, HashSet<int>>();
      TweetMap = new Dictionary<int, List<int>>();
    }

    /// <summary>
    ///  Composes a new tweet with ID tweetId by the user userId. 
    ///  Each call to this function will be made with a unique tweetId.
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="tweetId"></param>
    public void PostTweet(int userId, int tweetId)
    {
      var list = tweetMap.GetValueOrDefault(userId);
      if (list == null)
      {
        list = new List<int>();
      }

      list.Add(tweetId);
      tweetMap.Add(userId, list);
    }

    /// <summary>
    /// Retrieves the 10 most recent tweet IDs in the user's news feed. 
    /// Each item in the news feed must be posted by users who the user followed or by the user themself. 
    /// Tweets must be ordered from most recent to least recent.
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    public List<int> GetNewsFeed(int userId)
    { //
      return new List<int>() { };
    }


    /// <summary>
    /// The user with ID followerId started following the user with ID followeeId.
    /// </summary>
    /// <param name="followerId"></param>
    /// <param name="followeeId"></param>
    public void Follow(int followerId, int followeeId)
    {
      var hashSet = followMap.GetValueOrDefault(followerId);
      if (hashSet == null)
      {
        hashSet = new HashSet<int>();
      }
      hashSet.Add(followeeId);
      followMap.Add(followerId, hashSet);
    }

    /// <summary>
    /// The user with ID followerId started unfollowing the user with ID followeeId.
    /// </summary>
    /// <param name="followerId"></param>
    /// <param name="followeeId"></param>
    public void Unfollow(int followerId, int followeeId)
    {
      var hashSet = followMap.GetValueOrDefault(followerId);
      hashSet.Remove(followeeId);
    }
  }
}
