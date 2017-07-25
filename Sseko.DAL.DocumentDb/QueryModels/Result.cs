namespace Sseko.DAL.DocumentDb.QueryModels
{
    public class Result<T> : QueryBase
    {
        public T Output { get; set; }
    }
}