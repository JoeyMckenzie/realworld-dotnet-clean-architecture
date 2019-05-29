namespace Conduit.Domain.Entities
{
    using System.Collections.Generic;

    public class Article : BaseEntity
    {
        public int Id { get; set; }

        public Article()
        {
            TagList = new HashSet<string>();
        }

        public string Slug { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Body { get; set; }

        public ISet<string> TagList { get; }

        public bool FavoritesCount { get; set; }
    }
}