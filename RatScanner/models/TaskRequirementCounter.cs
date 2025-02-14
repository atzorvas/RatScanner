using RatScanner.TarkovDev.GraphQL;

namespace RatScanner.Models

{
    public class TaskRequirementCounter
    {
        public int Total { get; set; }
        public int Kappa { get; set; }
        public int Lightkeeper { get; set; }

        public TaskRequirementCounter(total = 0, kappa = 0, lightkeeper = 0) {
            Total = total;
            Kappa = kappa;
            Lightkeeper = lightkeeper;
        }
d
        public void update(int incrementBy, Task task, Progress progress) {
            Total += incrementBy;
            if (task.KappaRequired == true) Kappa += incrementBy;
            if (task.LightkeeperRequired == true) Lightkeeper += incrementBy;
        }
    }
}