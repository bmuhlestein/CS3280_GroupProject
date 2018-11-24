using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Add_Mod_Del_Invoice_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        /// <summary>
        /// links to main logic class
        /// </summary>
        Main.clsMainLogic mainlogic;
        /// <summary>
        /// creates a list for displaying the equipment
        /// </summary>
        List<Main.clsMusicEquipment> list;
        /// <summary>
        /// Binds the list of equipment
        /// </summary>
        BindingList<Main.clsMusicEquipment> bindingList;
        /// <summary>
        /// String for get and set invoice number from search window
        /// </summary>
        private string sSearchedInvoiceNumber;
        /// <summary>
        /// boolean for determining if searched for invoice
        /// </summary>
        private bool bSearchedForInvoice = false;

        /// <summary>
        /// constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            mainlogic = new Main.clsMainLogic();
        }

        /// <summary>
        /// Public property to set sSearchedInvoiceNumber and get sSearchedInvoiceNumber
        /// </summary>
        public string getSearchedInvoiceNumber
        {
            set
            {
                sSearchedInvoiceNumber = value;
            }
            get
            {
                return sSearchedInvoiceNumber;
            }
        }

        /// <summary>
        /// Method for when "search for invoice" is clicked from the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchforinvoice_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Search.wndSearch wndsearch = new Search.wndSearch();
                this.Hide();
                wndsearch.ShowDialog();
                // get the invoice number from search window;
                this.Show();
                bSearchedForInvoice = true;

                if (bSearchedForInvoice == true)
                {
                    rbtnModifyInvoice.IsEnabled = true;
                    rbtnDeleteInvoice.IsEnabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method called when the "New Invoice" radio button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnNewInvoice_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                if (bSearchedForInvoice == false)
                {
                    invoiceDatePicker.IsEnabled = true;
                    cbSelectItem.IsEnabled = true;
                    txtDefaultCost.IsEnabled = true;
                    btnAddItem.IsEnabled = true;

                    list = mainlogic.getItems();
                    bindingList = new BindingList<Main.clsMusicEquipment>(list);
                    cbSelectItem.ItemsSource = bindingList;
                    cbSelectItem.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method called when the "Add item" button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dgInvoiceItems.IsEnabled = true;
                btnDeleteItem.IsEnabled = true;
                btnSaveInvoice.IsEnabled = true;

                // add item to data grid
                // reset selected item combobox
                // reset selected item cost
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Methods called when an item from the dropdown is changed/selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSelectItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                // place holder for testing
                double sID = 000002;
                // Get item ID based on the item selected
                string cost = mainlogic.getItemCost(sID);
                string sCost = cost.ToString();
                txtDefaultCost.Text = sCost;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Methods called when the "Delete Item" button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method called when the "Save Invoice" button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveInvoice_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method called when "Modify Invoice" radio button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnModifyInvoice_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                // Get invoice number from the search window

                // Pull invoice information in and 
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Method called when "Delete Invoice" radio button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnDeleteInvoice_Checked(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        private void btnAddItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
