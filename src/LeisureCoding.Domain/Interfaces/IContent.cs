using System.Collections.Generic;
using LeisureCoding.Domain.Models;

namespace LeisureCoding.Domain.Interfaces
{
    public interface IContent
    {
        List<Content> GetAll();
        Content Get(int contentId);
        void Add(Content contents);
        void Delete(int contentId);
        void Update(Content contents);
    }
}