namespace SnowMaker
{
    internal class ScopeState
    {
        public readonly object IdGenerationLock = new object();
        public long LastId;
        public long HighestIdAvailableInBatch;
    }
}