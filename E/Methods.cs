using System;
using System.Collections.Generic;
using System.Linq;

public static class Methods
{
    public static int FindBestBiathlonistValue(List<Sportsman> sportsmen) =>
        sportsmen.OfType<Biathlonist>().Max(biathlonist =>
            (int)(0.4 * Math.Max(((IShooter)biathlonist).Shoot(), ((ISkiRunner)biathlonist).Run()) +
                  0.6 * Math.Min(((IShooter)biathlonist).Shoot(), ((ISkiRunner)biathlonist).Run())));

    public static int FindBestShooterValue(List<Sportsman> sportsmen) =>
        sportsmen.Where(sportsman => sportsman is not SkiRunner).Max(biathlonist => ((IShooter)biathlonist).Shoot());

    public static int FindBestRunnerValue(List<Sportsman> sportsmen) =>
        sportsmen.Where(sportsman => sportsman is not Shooter).Max(biathlonist => ((ISkiRunner)biathlonist).Run());
}