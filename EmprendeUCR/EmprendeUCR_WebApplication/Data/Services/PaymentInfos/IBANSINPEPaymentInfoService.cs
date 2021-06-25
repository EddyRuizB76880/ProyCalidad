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
    public class IBANSINPEPaymentInfoService : PageModel
    {
        public IBANSINPEPaymentInfoService(Contexts.SqlServerDbContext context)
        {
            _context = context;
            ResetAddIBANSINPEPaymentInfoData();
            ResetRemoveIBANSINPEPaymentInfoData();
        }

        /*
         * 
         * Private Variables
         * 
         * 
         */
        private readonly Contexts.SqlServerDbContext _context;
        private SfTreeGrid<IBANSINPEPaymentInfo> TreeGrid;
        private IBANSINPEPaymentInfo SelectedIBANSINPEPaymentInfo;
        private bool AccountNumberNotValid;

        // PARA DELETE IBANSINPEPaymentInfo
        private int SelectedID = -1;
        private IBANSINPEPaymentInfo SelectedIBANSINPEPaymentInfoDelete;


        /*
         * 
         * Public Variables
         * 
         */
        public bool AddIBANSINPEPaymentInfoDialogVisible;
        public string accountNumber;
        public string namePaymentMethod;                    //SETEADO SIEMPRE EN "SINPEMovil"
        public int paymentInfoID;                           //Puede ser que no lo usemos y se cambie por un trigger o que se mande a hacer una tupla nueva al PaymentInfo
        public bool AddIBANSINPEPaymentInfoDisabled;


        // PARA DELETE IBANSINPEPaymentInfo
        public string accountNumberDelete;
        public bool RemoveIBANSINPEPaymentInfoDialogVisible;
        public bool RemoveToolbarItemDisabled;

        /**
         * @brief
         * @details
         * @param
         * @return
         */
        public void OpenAddIBANSINPEPaymentInfoDialog(IBANSINPEPaymentInfo ibanSINPEPaymentInfo)
        {
            this.AddIBANSINPEPaymentInfoDialogVisible = true;
        }


        public void CloseAddIBANSINPEPaymentInfoDialog()
        {
            this.AddIBANSINPEPaymentInfoDialogVisible = false;
            ResetAddIBANSINPEPaymentInfoData();
        }


        public void ValidateIBANSINPENumber(Microsoft.AspNetCore.Components.ChangeEventArgs args)
        {
            AccountNumberNotValid = true;
            //CREO QUE HAY QUE HACER TRY CATCH
            accountNumber = (String)args.Value;
            if (accountNumber.Length() == 22 && _context.IBANSINPEPaymentInfo.Find(accountNumber) == null)
            {
                AccountNumberNotValid = false;
            }
            AddIBANSINPEPaymentInfoDisabled = AccountNumberNotValid;              //SE PODRIA OMITIR ESTO
        }


        public async void AddIBANSINPEPaymentInfo(SfTreeGrid<IBANSINPEPaymentInfo> main)
        {
            this.TreeGrid = main;
            this.AddIBANSINPEPaymentInfoDialogVisible = false;

            PaymentInfo paymentInfo = new PaymentInfo();
            IBANSINPEPaymentInfo ibanSINPEPaymentInfo = new IBANSINPEPaymentInfo();

            ibanSINPEPaymentInfo.AccountNumber = accountNumber;
            ibanSINPEPaymentInfo.NamePaymentMethod = namePaymentMethod;

            //VER SI FUNCIONA
            await InsertPaymentInfoAsync(paymentInfo);
            paymentInfo = _context.PaymentInfo.LastOrDefault();
            ibanSINPEPaymentInfo.PaymentInfoID = paymentInfo.ID;

            await InsertIBANSINPEPaymentInfoAsync(ibanSINPEPaymentInfo);
            await this.TreeGrid.AddRecord(ibanSINPEPaymentInfo, 0, RowPosition.Top);
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

            ResetAddIBANSINPEPaymentInfoData();
        }


        public void ResetAddIBANSINPEPaymentInfoData()
        {
            AccountNumberNotValid = true;
            AddIBANSINPEPaymentInfoDialogVisible = false;
            accountNumber = null;
            namePaymentMethod = "SINPE";
            paymentInfoID = -1;
            AddIBANSINPEPaymentInfoDisabled = true;
        }

        //ESTE METODO LO USAN TODOS LOS PAYMENT INFOS
        public async Task<bool> InsertPaymentInfoAsync(PaymentInfo paymentInfo)
        {
            await _context.PaymentInfo.AddAsync(paymentInfo);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> InsertIBANSINPEPaymentInfoAsync(IBANSINPEPaymentInfo ibanSINPEPaymentInfo)
        {
            await _context.IBANSINPEPaymentInfo.AddAsync(ibanSINPEPaymentInfo);
            await _context.SaveChangesAsync();
            return true;
        }


        /*
         
                            METODOS DEL DELETE PHONE PAYMENT INFO
         
         */

        public void OpenRemoveIBANSINPEPaymentInfoDialog(IBANSINPEPaymentInfo ibanSINPEPaymentInfo)
        {
            this.SelectedIBANSINPEPaymentInfoDelete = ibanSINPEPaymentInfo;
            this.RemoveIBANSINPEPaymentInfoDialogVisible = true;
            this.SelectedID = SelectedIBANSINPEPaymentInfoDelete.PaymentInfoID;
            this.accountNumberDelete = SelectedIBANSINPEPaymentInfoDelete.AccountNumber;
        }


        public void CloseRemoveIBANSINPEPaymentInfoDialog()
        {
            this.RemoveIBANSINPEPaymentInfoDialogVisible = false;
            ResetRemoveIBANSINPEPaymentInfoData();
        }


        private void ResetRemoveIBANSINPEPaymentInfoData()
        {
            RemoveToolbarItemDisabled = true;
            accountNumberDelete = null;
            SelectedID = -1;
        }


        public async void RemoveIBANSINPEPaymentInfo(SfTreeGrid<IBANSINPEPaymentInfo> main)
        {
            this.TreeGrid = main;
            this.RemoveIBANSINPEPaymentInfoDialogVisible = false;
            Console.WriteLine(accountNumberDelete);
            Console.WriteLine(SelectedIBANSINPEPaymentInfoDelete.PaymentInfoID);
            var SelectedIndex = await TreeGrid.GetRowIndexByPrimaryKey(SelectedIBANSINPEPaymentInfoDelete.PaymentInfoID);
            await TreeGrid.DeleteRecord("Numero", SelectedIBANSINPEPaymentInfoDelete);              //REVISAR SI ES "Numero"
            await RemoveIBANSINPEPaymentInfo(SelectedID);
            await TreeGrid.DeleteRecord(accountNumberDelete, SelectedIBANSINPEPaymentInfo);
        }


        public async Task RemoveIBANSINPEPaymentInfo(int ID)
        {
            IBANSINPEPaymentInfo IBANSINPEPaymentInfoToRemove = await _context.IBANSINPEPaymentInfo.FindAsync(ID);
            _context.IBANSINPEPaymentInfo.Remove(IBANSINPEPaymentInfoToRemove);
            await _context.SaveChangesAsync();
        }
    }
}
