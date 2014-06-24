using System.Collections.Generic;
using LeisureCoding.Domain.Interfaces;
using LeisureCoding.Domain.Models;
using LeisureCoding.Interfaces;

namespace LeisureCoding.Queries
{
    public class ContentManager:IContentService
    {

        private readonly IContent content;

        public ContentManager(IContent content)
        {
            this.content = content;
        }

        public List<Content> GetAll()
        {
            return content.GetAll();
        }

        public Content Get(int contentId)
        {
            return content.Get(contentId);
        }

        public void Delete(int contentId)
        {
            content.Delete(contentId);
        }

        public void Update(Content contentUpdate)
        {
            content.Update(contentUpdate);
        }

        public void Add(Content contentAdd)
        {
            content.Add(contentAdd);
        }
    }
}