namespace DesignPatterns.Behavioral.Bridge
{
    public abstract class DegreeOfFreedom
    {
        public DegreeOfFreedom Next { get; set; }

        public string handle()
        {
            var m = Calculate();
            if (Next is not null)
            {
                return m + Next.handle();
            }
            return m;
        }

        public abstract string Calculate();
    }
}