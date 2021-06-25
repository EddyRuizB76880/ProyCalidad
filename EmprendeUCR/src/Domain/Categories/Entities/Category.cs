using EmprendeUCR.Domain.Core.Entities;
using EmprendeUCR.Domain.Core.ValueObjects;

namespace EmprendeUCR.Domain.Categories.Entities
{
    public class Category
    {
        public int Id { get; }
        public int ParentId { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public Category(string title, string description, int parentid)
        {
            ParentId = parentid;
            Title = title;
            Description = description;
        }
        // for EFCore
        protected Category()
        {
            Description = null;
            ParentId = 0;
            Title = null;
        }

        public void ChangeTitle(string title)
        {
            Title = title;
        }
        public void ChangeDescription(string description)
        {
            Description = description;
        }
        public void ChangeParentId(int parentid)
        {
            ParentId = parentid;
        }
    }
}