using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmprendeUCR_WebApplication.Data.Entities;
using Syncfusion.Blazor.TreeGrid;

namespace EmprendeUCR_WebApplication.Data.Services.PaymentInfos
{
    public class IBANCardPaymentInfoService : PageModel
    {
        public IBANCardPaymentInfoService(Contexts.SqlServerDbContext context)
        {
            _context = context;
            ResetAddIBANCardPaymentInfoData();
            ResetRemoveIBANCardPaymentInfoData();
        }

        /*
         * 
         * Private Variables
         * 
         * 
         */
        private readonly Contexts.SqlServerDbContext _context;
        private SfTreeGrid<IBANCardPaymentInfo> TreeGrid;
        private IBANCardPaymentInfo SelectedIBANCardPaymentInfo;
        private bool AccountNumberNotValid;

        // PARA DELETE IBANSINPEPaymentInfo
        private int SelectedID = -1;
        private IBANCardPaymentInfo SelectedIBANCardPaymentInfoDelete;


        /*
         * 
         * Public Variables
         * 
         */
        public bool AddIBANCardPaymentInfoDialogVisible;
        public string accountNumber;
        public string namePaymentMethod;                    //SETEADO SIEMPRE EN "SINPEMovil"
        public int paymentInfoID;                           //Puede ser que no lo usemos y se cambie por un trigger o que se mande a hacer una tupla nueva al PaymentInfo
        public bool AddIBANCardPaymentInfoDisabled;


        // PARA DELETE IBANSINPEPaymentInfo
        public string accountNumberDelete;
        public bool RemoveIBANCardPaymentInfoDialogVisible;
        public bool RemoveToolbarItemDisabled;

        /**
         * @brief
         * @details
         * @param
         * @return
         */
        public void OpenAddIBANCardPaymentInfoDialog(IBANCardPaymentInfo ibanCardPaymentInfo)
        {
            this.AddIBANCardPaymentInfoDialogVisible = true;
        }


        public void CloseAddIBANCardPaymentInfoDialog()
        {
            this.AddIBANCardPaymentInfoDialogVisible = false;
            ResetAddIBANCardPaymentInfoData();
        }


        public void ValidateIBANCardNumber(Microsoft.AspNetCore.Components.ChangeEventArgs args)
        {
            AccountNumberNotValid = true;
            //CREO QUE HAY QUE HACER TRY CATCH
            accountNumber = (String)args.Value;
            if (accountNumber.Length() == 22 && _context.IBANCardPaymentInfo.Find(accountNumber) == null)
            {
                AccountNumberNotValid = false;
            }
            AddIBANCardPaymentInfoDisabled = AccountNumberNotValid;              //SE PODRIA OMITIR ESTO
        }


        public async void AddIBANCardPaymentInfo(SfTreeGrid<IBANCardPaymentInfo> main)
        {
            this.TreeGrid = main;
            this.AddIBANCardPaymentInfoDialogVisible = false;

            PaymentInfo paymentInfo = new PaymentInfo();
            IBANCardPaymentInfo ibanCardPaymentInfo = new IBANCardPaymentInfo();

            ibanCardPaymentInfo.AccountNumber = accountNumber;
            ibanCardPaymentInfo.NamePaymentMethod = namePaymentMethod;

            //VER SI FUNCIONA
            await InsertPaymentInfoAsync(paymentInfo);
            paymentInfo = _context.PaymentInfo.LastOrDefault();
            ibanCardPaymentInfo.PaymentInfoID = paymentInfo.ID;

            await InsertIBANCardPaymentInfoAsync(ibanCardPaymentInfo);
            await this.TreeGrid.AddRecord(ibanCardPaymentInfo, 0, RowPosition.Top);
            //CREO QUE ESE SERIA EL EQUIVALENTE A LO COMENTADO

            /* var TitleDadIndex = TreeGrid.GetRowIndexByPrimaryKey(Category.ParentId).Result;
            if (TitleDadIndex < 0)
            {
                await this.TreeGrid.AddRecord(Category, 0, RowPosition.Top);
            }
            else
            {
                await this.TreeGrid.AddRecord(Category, TitleDadIndex, RowPosition.Child);
            }
           */

            ResetAddIBANCardPaymentInfoData();
        }


        public void ResetAddIBANCardPaymentInfoData()
        {
            AccountNumberNotValid = true;
            AddIBANCardPaymentInfoDialogVisible = false;
            accountNumber = null;
            namePaymentMethod = null;
            paymentInfoID = -1;
            AddIBANCardPaymentInfoDisabled = true;
        }

        //ESTE METODO LO USAN TODOS LOS PAYMENT INFOS
        public async Task<bool> InsertPaymentInfoAsync(PaymentInfo paymentInfo)
        {
            await _context.PaymentInfo.AddAsync(paymentInfo);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> InsertIBANCardPaymentInfoAsync(IBANCardPaymentInfo ibanCardPaymentInfo)
        {
            await _context.IBANCardPaymentInfo.AddAsync(ibanCardPaymentInfo);
            await _context.SaveChangesAsync();
            return true;
        }


        /*
         
                            METODOS DEL DELETE PHONE PAYMENT INFO
         
         */

        public void OpenRemoveIBANCardPaymentInfoDialog(IBANCardPaymentInfo ibanCardPaymentInfo)
        {
            this.SelectedIBANCardPaymentInfoDelete = ibanCardPaymentInfo;
            this.RemoveIBANCardPaymentInfoDialogVisible = true;
            this.SelectedID = SelectedIBANCardPaymentInfoDelete.PaymentInfoID;
            this.accountNumberDelete = SelectedIBANCardPaymentInfoDelete.AccountNumber;
        }


        public void CloseRemoveIBANCardPaymentInfoDialog()
        {
            this.RemoveIBANCardPaymentInfoDialogVisible = false;
            ResetRemoveIBANCardPaymentInfoData();
        }


        private void ResetRemoveIBANCardPaymentInfoData()
        {
            RemoveToolbarItemDisabled = true;
            accountNumberDelete = null;
            SelectedID = -1;
        }


        public async void RemoveIBANCardPaymentInfo(SfTreeGrid<IBANCardPaymentInfo> main)
        {
            this.TreeGrid = main;
            this.RemoveIBANCardPaymentInfoDialogVisible = false;
            Console.WriteLine(accountNumberDelete);
            Console.WriteLine(SelectedIBANCardPaymentInfoDelete.PaymentInfoID);
            var SelectedIndex = await TreeGrid.GetRowIndexByPrimaryKey(SelectedIBANCardPaymentInfoDelete.PaymentInfoID);
            await TreeGrid.DeleteRecord("Numero", SelectedIBANCardPaymentInfoDelete);              //REVISAR SI ES "Numero"
            await RemoveIBANCardPaymentInfo(SelectedID);
            await TreeGrid.DeleteRecord(accountNumberDelete, SelectedIBANCardPaymentInfo);
        }


        public async Task RemoveIBANCardPaymentInfo(int ID)
        {
            IBANCardPaymentInfo IBANCardPaymentInfoToRemove = await _context.IBANCardPaymentInfo.FindAsync(ID);
            _context.IBANCardPaymentInfo.Remove(IBANCardPaymentInfoToRemove);
            await _context.SaveChangesAsync();
        }
    }
}
