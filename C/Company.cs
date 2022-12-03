using System;
using System.Collections.Generic;

internal class Company
{
    private List<TeamLead> _teamLeads;
    public int TeamLeadsAmount { get; }
    public int[] ProgrammersAmount { get; }

    public Company(int teamLeadsAmount, int[] programmersAmount)
    {
        TeamLeadsAmount = teamLeadsAmount;
        ProgrammersAmount = programmersAmount;
        var x = new List<TeamLead>();
        for (int i = 0; i < TeamLeadsAmount; i++)
        {
            var y = new List<Programmer>();
            for (int j = 0; j < ProgrammersAmount[i]; j++)
            {
                y.Add(new Programmer(int.Parse($"{i + 1}{j + 1}")));
            }
            x.Add(new TeamLead(i + 1, y));
        }

        _teamLeads = x;
    }

    public List<TeamLead> TeamLeads => _teamLeads;

    public void PrintTeams()
    {
        foreach (var teamLead in TeamLeads)
        {
            Console.WriteLine(teamLead);
            Console.WriteLine("Written lines of code: {0}", teamLead.GetWrittenLinesOfCode());
        }

        Console.WriteLine();
    }
}