using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Add_Mod_Del_Invoice_Project.Main
{

    /*
     * 
     * The main window should allow the user to create new invoices, edit existing invoices, or delete existing invoices.  [DONE]
     * 
     * There should be just one window for all functionality of the main window.  So, the main window will NOT open other windows to add/edit/delete invoices.  [DONE]
     * 
     * It will also have a menu (at the top, use a menu control) that will have two functionalities.  The first will allow the user to update a def table that contains the items.  The next will be to open a search screen used to search for invoices.  [DONE]
     * 
     * If a new invoice is created the user may enter data pertaining to that invoice.  Since an auto-generated number is used in the database for the invoice number, when a user creates a new invoice, just display “TBD” for the Invoice Number.  An invoice date will also be assigned by the user.  Next different items will be entered by the user.  
     * 
     * The items will be selected from a drop-down box and the cost for that item will be put into a read only textbox.  This will be the default cost of an item. 
     * 
     * Once the item is selected, the user can add the item.  As many items as needed should be able to be added.  All items entered should be displayed for viewing in a list (something like a DataGrid).  Items may be deleted from the list.  A running total of the cost of all items should be displayed as items are entered or deleted.  
     * 
     * Once all the items are entered the user can save the invoice.  Once the Invoice is saved, query the max invoice number from the database, to display for the invoice number (for our project, this will work, since the last inserted invoice, will be the max).  This will lock the data in the invoice for viewing only.  
     * 
     * From here the user may choose to Edit the Invoice or Delete the Invoice.
     * 
     */

    class clsMainLogic
    {
        clsDataAccess db = new clsDataAccess();
        clsMainSQL mainSQL = new clsMainSQL();
        clsMusicEquipment Equipment;

        public List<clsMusicEquipment> getItems()
        {
            List<clsMusicEquipment> musicEquipment = new List<clsMusicEquipment>();
            try
            {
                DataSet ds = new DataSet();

                int iRet = 0;

                ds = db.ExecuteSQLStatement(mainSQL.SelectItemsToBeAddedToInvoice(), ref iRet);

                for (int i = 0; i < iRet; i++)
                {
                    Equipment = new Main.clsMusicEquipment();
                    Equipment.getEqipmentID = ds.Tables[0].Rows[i][0].ToString();
                    Equipment.getEquipmentName = ds.Tables[0].Rows[i][1].ToString();
                    Equipment.getEquipmentDescription = ds.Tables[0].Rows[i][2].ToString();
                    Equipment.getEquipmentCost = ds.Tables[0].Rows[i][3].ToString();

                    musicEquipment.Add(Equipment);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
            return musicEquipment.Cast<clsMusicEquipment>().ToList();
        }

        public string getItemCost(string sEquipmentID)
        {
            //string sEID = "000002";
            try
            {
                DataSet ds = new DataSet();
                
                int iRet = 0;

                // THIS HAS A PROBLEM!!!!!!!!!!!!!!!!
                ds = db.ExecuteSQLStatement(mainSQL.SelectedItemCost(sEquipmentID), ref iRet);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string value = ds.Tables[0].Rows.ToString();
                    //double dValue;
                    //double.TryParse(value, out dValue);
                    return value;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
            return "";
        }
    }
}
