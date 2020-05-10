using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private IDictionary<int, SortedSet<string>> _roster;

    public GradeSchool()
    {
        _roster = new Dictionary<int, SortedSet<string>>();
    }

    public void Add(string student, int grade)
    {
        if (!_roster.TryAdd(grade, new SortedSet<string>() {student}))
        {
            _roster[grade].Add(student);
        }
    }

    public IEnumerable<string> Roster() => _roster.OrderBy(x => x.Key).SelectMany(x => x.Value);

    public IEnumerable<string> Grade(int grade)
    {
        if (_roster.ContainsKey(grade))
        {
            return _roster[grade];
        }

        return new List<String>();
    }
}