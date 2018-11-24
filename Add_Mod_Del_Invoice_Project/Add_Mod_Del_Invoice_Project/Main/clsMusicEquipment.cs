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

        /// <summary>
        /// public property for getting equipment ID
        /// </summary>
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

        /// <summary>
        /// public property for getting equipment Name
        /// </summary>
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

        /// <summary>
        /// publi property for getting equipment description
        /// </summary>
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

        /// <summary>
        /// public propety for getting equipment cost
        /// </summary>
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

        /// <summary>
        /// method for overridding the tostring method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return sEquipmentName;
        }
    }
}
