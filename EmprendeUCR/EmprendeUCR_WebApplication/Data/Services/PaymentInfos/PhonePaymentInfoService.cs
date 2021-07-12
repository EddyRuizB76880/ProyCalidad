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
    public class PhonePaymentInfoService : PageModel
    {
        public PhonePaymentInfoService(Contexts.SqlServerDbContext context)
        {
            _context = context;
            ResetAddPhonePaymentInfoData();
            ResetRemovePhonePaymentInfoData();
        }

        /*
         * 
         * Private Variables
         * 
         * 
         */
        private readonly Contexts.SqlServerDbContext _context;
        private SfTreeGrid<PhonePaymentInfo> TreeGrid;
        private PhonePaymentInfo SelectedPhonePaymentInfo;
        private bool PhoneNumberNotValid;

        // PARA DELETE PhonePaymentInfo
        private int SelectedID = -1;
        private PhonePaymentInfo SelectedPhonePaymentInfoDelete;


        /*
         * 
         * Public Variables
         * 
         */
        public bool AddPhonePaymentInfoDialogVisible;
        public int phoneNumber;
        public string namePaymentMethod;                    //SETEADO SIEMPRE EN "SINPEMovil"
        public int paymentInfoID;                           //Puede ser que no lo usemos y se cambie por un trigger o que se mande a hacer una tupla nueva al PaymentInfo
        public bool AddPhonePaymentInfoDisabled;


        // PARA DELETE PhonePaymentInfo
        public int phoneNumberDelete;
        public bool RemovePhonePaymentInfoDialogVisible;
        public bool RemoveToolbarItemDisabled;

        /**
         * @brief
         * @details
         * @param
         * @return
         */
        public void OpenAddPhonePaymentInfoDialog(PhonePaymentInfo phonePaymentInfo)
        {
            this.AddPhonePaymentInfoDialogVisible = true;
        }


        public void CloseAddPhonePaymentInfoDialog()
        {
            this.AddPhonePaymentInfoDialogVisible = false;
            ResetAddPhonePaymentInfoData();
        }


        public void ValidatePhoneNumber(Microsoft.AspNetCore.Components.ChangeEventArgs args)
        {
            PhoneNumberNotValid = true;
            //CREO QUE HAY QUE HACER TRY CATCH
            phoneNumber = (int)args.Value;
            if (phoneNumber >= 0 && phoneNumber <= 99999999 && _context.PhonePaymentInfo.Find(phoneNumber) == null)
            {
                PhoneNumberNotValid = false;
            }
            AddPhonePaymentInfoDisabled = PhoneNumberNotValid;              //SE PODRIA OMITIR ESTO
        }


        public async void AddPhonePaymentInfo(SfTreeGrid<PhonePaymentInfo> main)
        {
            this.TreeGrid = main;
            this.AddPhonePaymentInfoDialogVisible = false;

            PaymentInfo paymentInfo = new PaymentInfo();
            PhonePaymentInfo phonePaymentInfo = new PhonePaymentInfo();

            phonePaymentInfo.PhoneNumber = phoneNumber;
            phonePaymentInfo.NamePaymentMethod = namePaymentMethod;

            //VER SI FUNCIONA
            await InsertPaymentInfoAsync(paymentInfo);
            paymentInfo = _context.PaymentInfo.LastOrDefault();
            phonePaymentInfo.PaymentInfoID = paymentInfo.ID;

            await InsertPhonePaymentInfoAsync(phonePaymentInfo);
            await this.TreeGrid.AddRecord(phonePaymentInfo, 0, RowPosition.Top);
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

            ResetAddPhonePaymentInfoData();
        }


        public void ResetAddPhonePaymentInfoData()
        {
            PhoneNumberNotValid = true;
            AddPhonePaymentInfoDialogVisible = false;
            phoneNumber = -1;
            namePaymentMethod = "SINPEMovil";
            paymentInfoID = -1;
            AddPhonePaymentInfoDisabled = true;
        }

        //ESTE METODO LO USAN TODOS LOS PAYMENT INFOS
        public async Task<bool> InsertPaymentInfoAsync(PaymentInfo paymentInfo)
        {
            await _context.PaymentInfo.AddAsync(paymentInfo);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> InsertPhonePaymentInfoAsync(PhonePaymentInfo phonePaymentInfo)
        {
            await _context.PhonePaymentInfo.AddAsync(phonePaymentInfo);
            await _context.SaveChangesAsync();
            return true;
        }


        /*
         
                            METODOS DEL DELETE PHONE PAYMENT INFO
         
         */

        public void OpenRemovePhonePaymentInfoDialog(PhonePaymentInfo phonePaymentInfo)
        {
            this.SelectedPhonePaymentInfoDelete = phonePaymentInfo;
            this.RemovePhonePaymentInfoDialogVisible = true;
            this.SelectedID = SelectedPhonePaymentInfoDelete.PaymentInfoID;
            this.phoneNumberDelete = SelectedPhonePaymentInfoDelete.PhoneNumber;
        }


        public void CloseRemovePhonePaymentInfoDialog()
        {
            this.RemovePhonePaymentInfoDialogVisible = false;
            ResetRemovePhonePaymentInfoData();
        }


        private void ResetRemovePhonePaymentInfoData()
        {
            RemoveToolbarItemDisabled = true;
            phoneNumberDelete = -1;
            SelectedID = -1;
        }


        public async void RemovePhonePaymentInfo(SfTreeGrid<PhonePaymentInfo> main)
        {
            this.TreeGrid = main;
            string number = "";
            this.RemovePhonePaymentInfoDialogVisible = false;
            var SelectedIndex = await TreeGrid.GetRowIndexByPrimaryKey(SelectedPhonePaymentInfoDelete.PaymentInfoID);
            await TreeGrid.DeleteRecord("Numero", SelectedPhonePaymentInfoDelete);              //REVISAR SI ES "Numero"
            await RemovePhonePaymentInfo(SelectedID);
            number += phoneNumberDelete;
            await TreeGrid.DeleteRecord(number, SelectedPhonePaymentInfo);
        }


        public async Task RemovePhonePaymentInfo(int ID)
        {
            PhonePaymentInfo PhonePaymentInfoToRemove = await _context.PhonePaymentInfo.FindAsync(ID);
            _context.PhonePaymentInfo.Remove(PhonePaymentInfoToRemove);
            await _context.SaveChangesAsync();
        }
    }
}
