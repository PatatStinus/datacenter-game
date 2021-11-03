using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager_leaderboard : MonoBehaviour
{
    private List<LeaderboardEntry> LeaderboardEntries;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddLeaderboardEntry(string PlayerName, uint Score)
    {
        LeaderboardEntries.Add(new LeaderboardEntry(PlayerName, Score));
    }

    public string[][] GetLeaderboardEntries()
    {
        LeaderboardEntries.Sort(delegate(LeaderboardEntry Le1, LeaderboardEntry Le2) 
        {
            return Le1.Score.CompareTo(Le2.Score);
        });

        LeaderboardEntry[] SortedEntries = LeaderboardEntries.ToArray();
        string[][] SortedEntriesString = new string[LeaderboardEntries.Count][];

        for (int i = 0; i < LeaderboardEntries.Count; i++)
        {
            SortedEntriesString[i][0] = SortedEntries[i].PlayerName;
            SortedEntriesString[i][1] = SortedEntries[i].Score.ToString();
        }

        return SortedEntriesString;
    }
}

public class LeaderboardEntry
{
    public string PlayerName;
    public uint Score;

    public LeaderboardEntry(string PlayerNameIn, uint ScoreIn)
    {
        PlayerName = PlayerNameIn;
        Score = ScoreIn;
    }
}