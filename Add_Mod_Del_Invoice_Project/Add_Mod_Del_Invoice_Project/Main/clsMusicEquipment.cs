using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Mod_Del_Invoice_Project.Main
{
    class clsMusicEquipment
    {
        private string sEquipmentID;
        private string sEquipmentName;
        private string sEquipmentDescription;
        private string sCost;

        public string getEqipmentID
        {
            set
            {
                sEquipmentID = value;
            }
            get
            {
                return sEquipmentID;
            }
        }

        public string getEquipmentName
        {
            set
            {
                sEquipmentName = value;
            }
            get
            {
                return sEquipmentName;
            }
        }

        public string getEquipmentDescription
        {
            set
            {
                sEquipmentDescription = value;
            }
            get
            {
                return sEquipmentDescription;
            }
        }

        public string getEquipmentCost
        {
            set
            {
                sCost = value;
            }
            get
            {
                return sCost;
            }
        }

        public override string ToString()
        {
            return sEquipmentName;
        }
    }
}
