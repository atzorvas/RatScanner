namespace RatScanner.Models;
public class TaskRequirementsCounter
{
    public int Kappa { get; set; }
    public int Lightkeeper { get; set; }
    public int Total { get; set; }

    public TaskRequirementsCounter(int total, int kappa = 0, int lightkeeper = 0)
    {
        Kappa = kappa;
        Lightkeeper = lightkeeper;
        Total = total;
    }
}
