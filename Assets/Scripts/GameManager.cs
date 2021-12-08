using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool minigameActive = false;

    private void Awake() => DontDestroyOnLoad(gameObject);

    // ***********
    // Leaderboard
    // ***********

    private List<LeaderboardEntry> LeaderboardEntries;

    public void AddLeaderboardEntry(string PlayerName, uint Score) => LeaderboardEntries.Add(new LeaderboardEntry(PlayerName, Score));

    public string[][] GetLeaderboardEntries()
    {
        LeaderboardEntries.Sort(delegate (LeaderboardEntry Le1, LeaderboardEntry Le2)
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

    private void FixedUpdate()
    {
        // *************
        // Click objects
        // *************

        // RAYCAST WORKS BUT DOESN'T CHECK LAYER YET!
        if (minigameActive || !Input.GetMouseButtonDown(0) || !Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit)) // layer 9 is clickableObject
            return;

        // ADD CHECK FOR DISTANCE
        if (true)
            hit.transform.gameObject.GetComponent<clickableObjectParent>().ObjectClicked();
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