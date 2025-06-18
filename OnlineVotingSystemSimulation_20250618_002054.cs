using System;
using System.Collections.Generic;
using System.Linq;

public class Candidate
{
    public string Name { get; set; }
    public int Votes { get; set; }
}

public class OnlineVotingSystemSimulation
{
    private List<Candidate> candidates;

    public OnlineVotingSystemSimulation(string[] candidateNames)
    {
        candidates = new List<Candidate>();
        foreach (var name in candidateNames)
        {
            candidates.Add(new Candidate { Name = name, Votes = 0 });
        }
    }

    public void Vote(string candidateName)
    {
        var candidate = candidates.FirstOrDefault(c => c.Name == candidateName);
        if (candidate != null)
        {
            candidate.Votes++;
        }
    }

    public string GetWinner()
    {
        return candidates.OrderByDescending(c => c.Votes).FirstOrDefault()?.Name;
    }

    public static void Main()
    {
        var votingSystem = new OnlineVotingSystemSimulation(new string[] { "Alice", "Bob", "Charlie" });
        votingSystem.Vote("Alice");
        votingSystem.Vote("Alice");
        votingSystem.Vote("Bob");
        Console.WriteLine(votingSystem.GetWinner());
        votingSystem.Vote("Charlie");
        votingSystem.Vote("Charlie");
        votingSystem.Vote("Charlie");
        Console.WriteLine(votingSystem.GetWinner());
    }
}