namespace Conduit.Domain.Entities
{
    public class Favorite : BaseEntity
    {
        public virtual string UserId { get; set; }

        public ConduitUser User { get; set; }

        public virtual int ArticleId { get; set; }

        public Article Article { get; set; }
    }
}