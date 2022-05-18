using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Project: WikiList Application
/// 
/// Fully functional wiki application for categories and definitions
/// for Data Structures for CITE Managed Services junior programmers.
/// 
/// © Bruce Fisher P197681
/// Date: 28/04/2022
/// Version: v1.8
/// 
/// Created:
/// •   Information Class ✔
/// •   List WikiList of Information Class ✔
/// •   Form GUI Layout Design ✔
/// •   Method for Status Strip Error Messaging ✔
/// •   Create string Array for ComboBox Category ✔
/// •   Method to populate ComboBox Category upon Form Load ✔
/// •   Method for Structure RadioButtons that returns string value from selection ✔
/// •   Method for Structure RadioButtons that using int to set RadioButtons selection ✔
/// •   Extra Method for Structure RadioButtons to clear both selections ✔
/// •   Method to Sort and Display to ListView the WikiList List of Instances of Information Name and Category ✔
/// •   Method for New Name Entry to check for Duplicate Name in Wiki ✔
///
/// Reference for Radio Buttons used Panel instead of Grouped Box as looks nicer on form adheres to MSDN Standard.
/// How to: Group Windows Forms RadioButton Controls to Function as a Set
/// To group RadioButton controls as a set to function independently of other sets
/// •   Drag a GroupBox or Panel control from the Windows Forms tab on the Toolbox onto the form.
/// •   Draw RadioButton controls on the GroupBox or Panel control.
/// https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-group-windows-forms-radiobutton-controls-to-function-as-a-set?view=netframeworkdesktop-4.8#:~:text=You%20group%20radio%20buttons%20by,inside%20panels%20or%20group%20boxes.
/// </summary>

namespace WikiApplication
{
    public partial class WikiApplicationForm : Form
    {
        #region Global Variables
        // Application Version Number
        string versionNo = "v1.8";

        // Target for link label linkLabelDeimosWebsite
        string target = "https://deimoscodingprojects.com/";

        // List to store WikiList Information Class
        List<Information> WikiList = new List<Information>();

        // Category String Array
        string[] categories = new string[6] {"Array","List", "Tree", "Graphs", "Abstract", "Hash" };

        // Used to switch DisplayToLabelMsg text colour
        const string statusBarErrorMsg = "Red"; // Error message
        const string statusBarUserMsg = "White"; // User message
        #endregion

        #region Initialise Form Components ✔
        /// <summary>
        /// Initialises Form Components
        /// </summary>
        public WikiApplicationForm()
        {
            InitializeComponent();
        }
        #endregion

        #region WikiApplicationForm_Load
        /// <summary>
        /// Unpon form Load Process the following
        /// </summary>
        /// <param name="sender">Object which initiated the event</param>
        /// <param name="e">Event data</param>
        private void WikiApplicationForm_Load(object sender, EventArgs e)
        {
            // WikiList Logo Title
            labelWikiTitleLogo.Text = "Wiki Application " + versionNo;

            // prefill Category ComboBox
            loadCategoryComboBox();

            // Clear the User Status Strip User Messaging
            toolStripStatusLabelUserMessinging.Text = "";

            // ################################################## TEST DATA FOR LISTVIEW ####################################################################################
            WikiList.Add(new Information("Heap", "Tree", "Non-Linear", "Aheap of information for definition"));
            WikiList.Add(new Information("Array", "Array", "Linear", "Aheap of information for definition"));
            WikiList.Add(new Information("List", "List", "Linear", "Aheap of information for definition"));
            WikiList.Add(new Information("Self-Balance Tree", "Tree", "Non-Linear", "Aheap of information for definition"));

            displayWikiInformation();
        }
        #endregion

        #region Utilities
        #region Link Label Deimos Website Click ✔
        /// <summary>
        /// Deimos Coding Projects website link pressed
        /// 
        /// Website: https://deimoscodingprojects.com/
        /// YouTube Channel: https://www.youtube.com/channel/UCSss3BTapsr-cQgmV0NgtTg
        /// </summary>
        /// <param name="sender">Object which initiated the event</param>
        /// <param name="e">Event data</param>
        private void linkLabelDeimosWebsite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(target);
        }
        #endregion

        #region loadCategoryComboBox ✔
        /// <summary>
        /// Fill Category ComboBox with items from Array categories
        /// </summary>
        private void loadCategoryComboBox()
        {
            foreach (string item in categories)
            {
                comboBoxCategory.Items.Add(item);
            }
        }
        #endregion

        #region radioButtonsStructure ✔
        #region radioButtonStructureSelected ✔
        /// <summary>
        /// Returns Text from selected Structure Radio Button
        /// If nothing is selected returns Empty String
        /// </summary>
        /// <returns>Text from Selected Struture RadioButton</returns>
        private string radioButtonStructureSelected()
        {
            string radioButtonText = ""; // for Text from selected RadioButton
            if (radioButtonLinear.Checked)
            {
                radioButtonText = radioButtonLinear.Text;
            }
            
            if (radioButtonNonLinear.Checked)
            {
                radioButtonText = radioButtonNonLinear.Text;
            }

            return radioButtonText;
        }
        #endregion

        #region radioButtonStructureSetSelection ✔
        /// <summary>
        /// Sets Structure RadioButton from passed integer
        /// As RadioButtons as grouped in a Panel the alternate RadioButton will automatically be deselected
        /// </summary>
        /// <param name="selection">RadioButton "selection" 1 = Linear, 2 = NonLinear</param>
        private void radioButtonStructureSetSelection(int selection)
        {
            switch (selection)
            {
                case 1:
                    radioButtonLinear.Checked = true;
                    break;
                case 2:
                    radioButtonNonLinear.Checked = true;
                    break;
                default:
                    DisplayToLabelMsg("System Error: Wrong Selection for Radio Buttons in Code!", statusBarErrorMsg);
                    break;
            }
        }
        #endregion

        #region radioButtonStructureClearSelections ✔
        /// <summary>
        /// Clears both RadioButtons within Panel Structure
        /// </summary>
        private void radioButtonStructureClearSelections()
        {
            radioButtonLinear.Checked = false;
            radioButtonNonLinear.Checked = false;
        }
        #endregion
        #endregion

        #region validName ✔
        /// <summary>
        /// Checks for Duplicate Wiki Name and returns Boolean
        /// </summary>
        /// <param name="checkListName">Wiki Name to check for duplicates</param>
        /// <returns></returns>
        private Boolean validName(string checkListName)
        {
            // Use Lambda Expression to check for duplicates
            if (WikiList.Exists(duplicate => duplicate.Equals(checkListName)))
            {
                DisplayToLabelMsg("Error: Name \"" + checkListName + "\" already Exists in Wiki", statusBarErrorMsg);
                return false;
            }
            else
                return true;
        }
        #endregion

        #region displayWikiInformation ✔
        private void displayWikiInformation()
        {
            // Sort WikiList List of Instances of Infomation
            WikiList.Sort();

            // Clear ListView Items from listViewWiki
            listViewWiki.Items.Clear(); 

            foreach (var wikiInformation in WikiList)
            {
                // create a list view item for each row
                // display in first column for Name
                ListViewItem listViewItem = new ListViewItem(wikiInformation.GetName());

                // add the next list view item for row
                // display in second column for Category
                listViewItem.SubItems.Add(wikiInformation.GetCatergory());

                // add the list view row of items to listViewWiki
                listViewWiki.Items.Add(listViewItem);
            }
        }
        #endregion

        #region listViewWiki_ColumnWidthChanging ✔
        /// <summary>
        /// Prevent Columns Widths from being changed by End User with Event
        /// </summary>
        /// <param name="sender">Object which initiated the event</param>
        /// <param name="e">Event data</param>
        private void listViewWiki_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            // Keep the curent width not changed
            e.NewWidth = ((ListView)sender).Columns[e.ColumnIndex].Width;
            // Cancel the event
            e.Cancel = true;
        }
        #endregion

        #region DisplayToLabelMsg ✔
        /// <summary>
        /// Displays string with given onto toolStripStatusLabelUserMessinging and flashes 
        /// statusStripUserMessaging to draw attention to user that message has been updated
        /// </summary>
        /// <param name="message">
        /// The string to Display in the Tool Label
        /// </param>
        /// <param name="colour">
        /// Colour to set showed message text
        /// </param>
        private void DisplayToLabelMsg(string message, string colour)
        {
            switch (colour)
            {
                case "Red":
                    toolStripStatusLabelUserMessinging.ForeColor = Color.Red;
                    break;
                case "White":
                    toolStripStatusLabelUserMessinging.ForeColor = Color.White;
                    break;
            }
            toolStripStatusLabelUserMessinging.Text = message;

            // Flash statusStripUserMessaging by changing statusStripUserMessaging visable on/off
            // to bring attention to error message
            statusStripUserMessaging.Visible = false;
            System.Threading.Thread.Sleep(100); // wait time between visability of statusStripUserMessaging
            statusStripUserMessaging.Visible = true;
        }
        #endregion

        #endregion
    }
}
