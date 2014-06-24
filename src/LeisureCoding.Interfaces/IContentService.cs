using System.Collections.Generic;
using LeisureCoding.Domain.Models;

namespace LeisureCoding.Interfaces
{
    public interface IContentService
    {
        List<Content> GetAll();
        Content Get(int contentId);
        void Add(Content contentAdd);
        void Delete(int contentId);
        void Update(Content contentUpdate); 
    }
}