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
        public String Title = null;
        public bool RemoveDialogVisible;
        public bool RemoveToolbarItemDisabled;
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
            await RemoveCategory(SelectedId);
            await TreeGrid.DeleteRecord(Title, SelectedCategory);
        }
        public async Task RemoveCategory(int Id)
        {
            Category CategoryToRemove = await _context.Category.FindAsync(Id);
            _context.Category.Remove(CategoryToRemove);
            await _context.SaveChangesAsync();
        }
    }
}
