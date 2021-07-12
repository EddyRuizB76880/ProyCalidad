using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmprendeUCR_WebApplication.Data.Entities;
using Syncfusion.Blazor.TreeGrid;

namespace EmprendeUCR_WebApplication.Data.Services.Categories
{
    public class DeleteCategoryService : PageModel
    {
        private readonly Contexts.SqlServerDbContext _context;
        SfTreeGrid<Category> TreeGrid;
        public DeleteCategoryService(Contexts.SqlServerDbContext context)
        {
            _context = context;
            ResetRemoveCategoryData();
        }

        /*
         * 
         * Private Variables
         * 
         */
        private int SelectedId = -1;
        private Category SelectedCategory;

        /*
         * 
         * Public Variables
         * 
         */
        public string Title = null;
        public bool RemoveDialogVisible;
        public bool RemoveToolbarItemDisabled;
        /*
         * 
         * Testing
         * 
         */
        public double SelectedIndex;
        public void OpenRemoveCategoryDialog(Category category)
        {
            this.SelectedCategory = category;
            this.RemoveDialogVisible = true;
            this.SelectedId = SelectedCategory.Id;
            this.Title = SelectedCategory.Title;
        }
        public void CloseRemoveCategoryDialog()
        {
            this.RemoveDialogVisible = false;
            ResetRemoveCategoryData();
        }

        private void ResetRemoveCategoryData()
        {
            RemoveToolbarItemDisabled = true;
            Title = null;
            SelectedId = -1;
        }

        public async void RemoveCategory(SfTreeGrid<Category> main)
        {
            this.TreeGrid = main;
            this.RemoveDialogVisible = false;
            var SelectedIndex = await TreeGrid.GetRowIndexByPrimaryKey(SelectedCategory.Id);
            await TreeGrid.DeleteRecord("Nombre",SelectedCategory);
            RemoveCategory(SelectedId);
        }
        public void RemoveCategory(int Id)
        {
           RemoveCategoryRecursive(Id);
        }
        public void RemoveCategoryRecursive(int Id)
        {
            IList<Category> listChilds =_context.Category.Where(c => c.ParentId.Equals(Id)).ToList();
            foreach(Category category in listChilds)
            {
                 RemoveCategoryRecursive(category.Id);
            }
            
            Category CategoryToRemove =  _context.Category.Find(Id);
            _context.Category.Remove(CategoryToRemove);
            _context.SaveChanges();
            TreeGrid.DeleteRecord(Title, SelectedCategory);
        }
    }
}
