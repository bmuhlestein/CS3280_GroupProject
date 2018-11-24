using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Mod_Del_Invoice_Project.Main
{
    class clsMainSQL
    {
        /// <summary>
        /// Method for SQL importing the equipment into the combo box
        /// </summary>
        /// <returns></returns>
        public string SelectItemsToBeAddedToInvoice()
        {
            string sSQL = "SELECT * FROM Equipment";
            return sSQL;
        }

        /// <summary>
        /// Method for pulling in the cost of the item that is selected from the dropdown
        /// </summary>
        /// <param name="sEquipmentID"></param>
        /// <returns></returns>
        public string SelectedItemCost(double dEquipmentID)
        {
            string sEID = dEquipmentID.ToString();
            string sSQL = "SELECT Equipment.Cost FROM Equipment WHERE Equipment.EquipmentID = " + sEID;
            return sSQL;
        }

        /// <summary>
        /// Method for deleting an invoice given a specific invoice number
        /// </summary>
        /// <param name="sInvoiceNumber"></param>
        /// <returns></returns>
        public string deleteInvocie(string sInvoiceNumber)
        {
            return "";
        }

        /// <summary>
        /// Method for updating an item to a specific invoice number
        /// </summary>
        /// <param name="sInvoiceNumber"></param>
        /// <returns></returns>
        public string updateInvoiceItems(string sInvoiceNumber)
        {
            return "";
        }
    }
}
