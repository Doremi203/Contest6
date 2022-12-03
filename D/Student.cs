using System;

internal struct Student : IComparable<Student>
{
    private static int _k;
    public int Id { get; }
    public int Height { get; }
    public int Math { get; }
    public int English { get; }
    public int Pe { get; }

    public Student(int id, int height, int math, int english, int PE)
    {
        Id = id;
        Height = height;
        Math = math;
        English = english;
        Pe = PE;
    }

    internal static Student Parse(string v)
    {
        var mas = Array.ConvertAll(v.Split(), Convert.ToInt32);
        _k++;
        return new Student(mas[0], mas[1], mas[2], mas[3], mas[4]);
    }

    public int CompareTo(Student other)
    {
        _k--;
        if (_k >= 0)
        {
            if (Math > other.Math)
            {
                return 1;
            }

            if (Math != other.Math) return 0;
            return English > other.English ? 1 : 0;
        }

        if (Pe > other.Pe)
        {
            return 1;
        }

        if (Pe != other.Pe) return 0;
        return Height > other.Height ? 1 : 0;
    }

    public override string ToString() => $"{Id}";
}