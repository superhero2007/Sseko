using Sseko.Core.Base;
using Sseko.Core.Enums;
using Sseko.DAL.DocumentDb.Base;

namespace Sseko.DAL.DocumentDb
{
    public class Repository<T> : RepositoryBase<T> where T : DocumentBase
    {
        public Repository(DataContext context, DocumentType documentType) : base(context, documentType)
        {
        }
    }
}