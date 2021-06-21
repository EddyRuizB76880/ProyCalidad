using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmprendeUCR_WebApplication.Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Syncfusion.Blazor.TreeGrid;

namespace EmprendeUCR_WebApplication.Data.Services
{
    public class CategoryService : PageModel
    {
        private readonly Contexts.SqlServerDbContext _context;
        SfTreeGrid<Category> TreeGrid;

        public CategoryService(Contexts.SqlServerDbContext context)
        {
            _context = context;
        }

        /**
        * @brief asyncronously returns a list of the current existing categories
        * @param
        * @return await _context.Category.ToListAsync(), returns the list of existing categories
        */
        public async Task<IList<Category>> GetAsync()
        {
            return await _context.Category.ToListAsync();
        }

        /**
        * @brief Validates if example title of a category isnt already in the categories database
        * @param String param name="title", the title that will be searched in the current list of categories
        * @return bool; true if there isnt already an existing category with the title, else returns false
        */
        public bool ValidateTitle(String title)
        {
            if (_context.Category.Where(c => c.Title.Equals(title)).Count() == 0)
            {
                return true;
            }
            return false;
        }

        /**
        * @brief changes the parent of a category, updates and save the changes
        * @param Title of the actual category and TitleDad of the selected category
        * @return
        */
        public async Task ChangeParent(String Title, int? ParentId)
        {
            Category source = _context.Category.Find(Title);
            source.ParentId = ParentId;
            _context.Category.Update(source);
            await _context.SaveChangesAsync();
        }

        /**
        * @brief returns the Id of a category's parent
        * @param TitleDad as the name of the category's parent 
        * @return parentCategory.Id
        */
        public int getParentId(String TitleDad)
        {
            Category parentCategory = _context.Category.Where(c => c.Title.Equals(TitleDad)).First();
            return parentCategory.Id;
        }

        /**
        * @brief returns the Id of a category
        * @param Id of a category 
        * @return Category.Id, la llave de la categoría actual
        */
        public Category getCategory(int Id)
        {
            return _context.Category.Find(Id);
        }

         /**
        * @brief Verifies if the selected category is a child
        * @param Id of category
        * @return false if is not child, true if it is
        */
        public bool isChildNode(int Id)
        {
            bool isChild = false;
            if (_context.Category.Where(c => c.ParentId.Equals(Id)).Count() == 0)
            {
                isChild = true;
            }
            return isChild;
        }

        /**
        * @brief Drag and drop a category into another (parent changer)
        * @details RowDragEventArgs references the dragged row (category)
        * @param args selected, to main target
        * @return
        */
        public async void Rowdrop(Syncfusion.Blazor.Grids.RowDragEventArgs<Category> args, SfTreeGrid<Category> main)
        {
            this.TreeGrid = main;
            var position = args.Target.ID;
            if (position == "e-dropchild")
            {
                var CurrentViewData = this.TreeGrid.GetCurrentViewRecords();
                var TargetCategory = CurrentViewData.ElementAt((int)args.DropIndex);
                var SourceCategory = CurrentViewData.ElementAt((int)args.FromIndex);
                await ChangeParent(SourceCategory.Title, TargetCategory.ParentId);
            }
            else
            {
                args.Cancel = true;
            }
        }
    }
}

