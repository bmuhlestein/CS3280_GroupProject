using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Mod_Del_Invoice_Project.Main
{
    class clsMainSQL
    {
        public string SelectItemsToBeAddedToInvoice()
        {
            string sSQL = "SELECT * FROM Equipment";
            return sSQL;
        }

        public string SelectedItemCost(string sEquipmentID)
        {
            string sEID = sEquipmentID.ToString();
            string sSQL = "SELECT Equipment.Cost FROM Equipment WHERE Equipment.EquipmentID = " + sEID;
            return sSQL;
        }
    }
}
