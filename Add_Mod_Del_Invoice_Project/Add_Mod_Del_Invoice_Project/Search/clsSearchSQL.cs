using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Mod_Del_Invoice_Project.Search
{
    class clsSearchSQL
    {
        //private clsDataAccess db = new clsDataAccess();
        

        /*
         * The assignment says that all three boxes need to be drop down boxes, so do I only 
         * need one SQL search since they all will be chosen? Or do they not need to be chosen?
         */

            //not all three need to be filled out
            

        /// <summary>
        /// Search for the invoice by invoiceID
        /// </summary>
        /// <param name="sInvoiceID"></param>
        /// <returns></returns>
        public string SelectInvoiceByID (string sInvoiceID)
        {
            string sSQL = "SELECT * FROM Invoices WHERE InvoiceNum = " + sInvoiceID;

            return sSQL;
        }

        /// <summary>
        /// Search for the invoice by date
        /// </summary>
        /// <param name="sDate"></param>
        /// <returns></returns>
        public string SelectInvoiceByDate (string sDate)
        {
            string sSQL = "SELECT * FROM Invoices WHERE InvoiceDate = " + sDate;

            return sSQL;
        }


        /// <summary>
        /// search for invoice by the equipmentID
        /// </summary>
        /// <param name="sEquipmentID"></param>
        /// <returns></returns>
        public string SelectInvoiceByItem (string sEquipmentID)
        {
            string sSQL = "SELECT * FROM Invoices WHERE EquipmentID = " + sEquipmentID;

            return sSQL; 
        }
    }
}
