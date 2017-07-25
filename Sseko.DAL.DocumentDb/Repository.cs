using Sseko.DAL.DocumentDb.Base;
using Sseko.DAL.DocumentDb.Enums;

namespace Sseko.DAL.DocumentDb
{
    public class Repository<T> : RepositoryBase<T> where T : DocumentBase
    {
        public Repository(DataContext context, DocumentType documentType) : base(context, documentType)
        {
        }
    }
}