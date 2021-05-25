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
    public class EditCategoryService : PageModel
    {
        private readonly Contexts.SqlServerDbContext _context;
        CategoryService CategoryService;
        SfTreeGrid<Category> TreeGrid;
        public EditCategoryService(Contexts.SqlServerDbContext context)
        {
            CategoryService = new(context);
            _context = context;
            ResetEditCategoryData();
        }

         /*
         * Private Variables
         */
        private bool EditTitleDadNotValid;
        private bool EditTitleNotValid;
        private double EditCategoryIndex;
        private int SelectedId;
        private Category SelectedCategory;

         /*
         * Public Variables
         */
        public bool EditCategoryDisabled;
        public bool EditDialogVisible;
        public bool EditToolbarItemDisabled;
        public string EditDescription;
        public string EditTitle;
        public string EditTitleDad;

        /**
        * @brief Open a Popup with the form to edit a category name
        * @details the dialog was made with a SfDialog with HTML
        * @param Category as selected category
        * @return
        */
        public void OpenEditCategoryDialog(Category category)
        {
            SelectedCategory = category;
            EditTitle = SelectedCategory.Title;
            //EditTitleDad = SelectedCategory.TitleDad;
            EditDescription = SelectedCategory.Description;
            this.EditDialogVisible = true;
        }

        /**
        * @brief closes the Popup with the form to edit a category name
        * @details the dialog was made with a SfDialog with HTML
        * @param 
        * @return
        */
        public void CloseEditCategoryDialog()
        {
            this.EditDialogVisible = false;
            ResetEditCategoryData();
        }

        /**
        * @brief Calls the service "EditCategoryName" with the method that enables the editing of a category name, edit category name only if the category values are valid
        * @details calls the service EditCategoryName(old_title, new_title); to do the edition
        * @param main as the actual category
        * @return
        */
        public async void EditCategory(SfTreeGrid<Category> main)
        {
            this.TreeGrid = main;
            this.EditDialogVisible = false;
            await EditCategoryName(SelectedCategory.Title, EditTitle);
            //await this.TreeGrid.SetCellValue(SelectedCategory.Id, Title, SelectedCategory.Title);
        }

        /**
        * @brief Verifies the existance or non existance of a category title
        * @details calls the service ValidateTitle(EditTitle); to do the verification
        * @param args supplies information about a change event, so that the new title can be validated as a non existence name 
        * @return
        */
        public void ValidateEditTitle(Microsoft.AspNetCore.Components.ChangeEventArgs args)
        {
            EditTitleNotValid = true;
            EditTitle = (String)args.Value;
            if (EditTitle.Length > 0)
            {
                if (CategoryService.ValidateTitle(EditTitle) == true)
                {
                    EditTitleNotValid = false;
                }
            }
            EditCategoryDisabled = EditTitleNotValid || EditTitleDadNotValid;
        }

        /**
        * @brief if a user wants to edit the name(Title) of a parent category, this function verifies that there is no other category with that name
        * @details calls the service ValidateTitle(new_title) to do the verification
        * @param args supplies information about a change event that is being raised, so that the new title can be validated as a non existence name 
        * @return
        */
        public void ValidateEditTitleDad(Microsoft.AspNetCore.Components.ChangeEventArgs args)
        {
            EditTitleDadNotValid = false;
            EditTitleDad = (String)args.Value;
            if (EditTitleDad.Length > 0)
            {
                if (CategoryService.ValidateTitle(EditTitleDad) == true)
                {
                    EditTitleDadNotValid = true;
                }
            }
            EditCategoryDisabled = EditTitleNotValid || EditTitleDadNotValid;
        }

        /**
        * @brief resets the variables used for edititing categories
        * @details all the variables that were set bellow are used for editing categories
        * @param 
        * @return
        */
        private void ResetEditCategoryData()
        {
            EditTitleDadNotValid = false;
            EditTitleNotValid = true;
            EditDescription = null;
            EditTitle = null;
            EditTitleDad = null;
            EditCategoryDisabled = true;
            EditDialogVisible = false ;
            EditToolbarItemDisabled = true;
    }
        /**
        * @brief changes the name of a category, updates and save the changes
        * @param oldTitle as the name of the actual category and newTitle that was choose for the selected category
        * @return
        */
        private async Task EditCategoryName(String oldTitle, string newTitle)
        {
            Category parentCategory = _context.Category.Where(c => c.Title.Equals(oldTitle)).First();
            parentCategory.Title = newTitle;
            _context.Update(parentCategory);
            await _context.SaveChangesAsync();
        }
    }
}
