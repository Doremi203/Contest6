using System;
using System.Collections.Generic;
using System.Linq;

internal class TeamLead : Programmer
{
    private readonly List<Programmer> _programmers;

    public TeamLead(int id, List<Programmer> programmers) : base(id)
    {
        _programmers = programmers;
    }

    public void HuntProgrammers(List<TeamLead> teamLeads)
    {
        var spizhen = new List<Programmer>();
        teamLeads.Where(lead => lead.Id != Id).ToList().ForEach(lead =>
        {
            lead._programmers.ForEach(programmer =>
            {
                if (programmer.WrittenCode % (Id + 1) != 0) return;
                spizhen.Add(programmer);
            });
            lead._programmers.RemoveAll(programmer => spizhen.Contains(programmer));
        });
        _programmers.AddRange(spizhen);
        
    }

    public override string ToString()
    {
        return $"Team lead #{Id}\nAmount of programmers in team: {_programmers.Count}";
    }

    public int GetWrittenLinesOfCode()
    {
        var sum = 0;
        _programmers.ForEach(programmer => sum += programmer.WrittenCode);
        sum += WrittenCode;
        return sum;
    }
}