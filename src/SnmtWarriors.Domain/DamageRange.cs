namespace SnmtWarriors.Domain
{
    public class DamageRange : IDamageRange
    {
        public DamageRange(int min, int max)
        {
            Min = min;
            Max = max;
        }
        
        public int Min { get; }
        
        public int Max { get; }
    }
}