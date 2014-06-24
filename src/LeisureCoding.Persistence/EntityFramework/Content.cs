using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using LeisureCoding.Domain.Interfaces;

namespace LeisureCoding.Persistence.EntityFramework
{
    public class Content:IContent
    {
        readonly LeisureCodingContext context = new LeisureCodingContext();
        public List<Domain.Models.Content> GetAll()
        {
            return context.Contents.ToList();
        }

        public Domain.Models.Content Get(int contentId)
        {
            return context.Contents.FirstOrDefault(c => c.ContentId == contentId);
        }

        public void Add(Domain.Models.Content contents)
        {
            context.Contents.Add(contents);
            context.SaveChanges();
        }

        public void Delete(int contentId)
        {
            context.Contents.Remove(context.Contents.FirstOrDefault(c => c.ContentId == contentId));
            context.SaveChanges();
        }

        public void Update(Domain.Models.Content content)
        {
            var contentToUpdate =context.Contents.FirstOrDefault(c => c.ContentId == content.ContentId);
            contentToUpdate.ContentName = content.ContentName;
            contentToUpdate.ContentId = content.ContentId;
            contentToUpdate.ContentSummary = content.ContentSummary;
            contentToUpdate.ContentText = content.ContentText;
            contentToUpdate.Line = content.Line;

            context.SaveChanges();
        }
    }
}