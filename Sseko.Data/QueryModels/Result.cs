namespace Sseko.Data.QueryModels
{
    public class Result<T> : QueryBase
    {
        public T Output { get; set; }
    }
}
