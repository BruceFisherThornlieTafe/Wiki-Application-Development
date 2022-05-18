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
/// Date: 30/04/2022
/// Version: v2.1
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
/// •   Method for ADD button to add Information to WikiList Include Validation for Form ✔
/// •   Method for User to Select Information from ListView and Display in Form ✔
/// •   Method for DELETE button to delete Information from WikiList for ListView selection ✔
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
        string versionNo = "v2.1";

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

        #region Form Loads Setup - WikiApplicationForm_Load ✔
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

            // Clear all Error Red Panels
            clearAllErrorPanels();

            // Clear the User Status Strip User Messaging
            toolStripStatusLabelUserMessinging.Text = "";

            // Focus User Input on Name at start
            textBoxName.Select();
            textBoxName.Focus(); 
        }
        #endregion

        #region Form Buttons

        #region ADD Button ✔
        /// <summary>
        /// Add to WikiList Information from Form Input and ReDisplay ListView
        /// </summary>
        /// <param name="sender">Object which initiated the event</param>
        /// <param name="e">Event data</param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Check for Duplicate Information Name in WikiList with validName
            if (!validName(textBoxName.Text))
                inCorrectNameError();
            
            // Check validity of Form Input and check for Duplicate Information Name with validName then Add Information Form to WikiList as Instance
            if (validateFormInput() && validName(textBoxName.Text))
            {
                toolStripStatusLabelUserMessinging.Text = ""; // Clear the User Status Strip User Messaging
                // Use Information Constructor to Add Information Instance to WikiList
                WikiList.Add(new Information(textBoxName.Text, comboBoxCategory.Text, radioButtonStructureGetSelected(), textBoxDefinition.Text));
                DisplayToLabelMsg("Information with Name: \"" + textBoxName.Text + "\" Added to Wiki List", statusBarUserMsg);
                displayWikiInformation(); // Display WikiList to ListView
                clearFormData();
            }
        }
        #endregion

        #region DELETE Button
        /// <summary>
        /// Delete the Information for WikiList Selected from the ListView with user Confirmation
        /// </summary>
        /// <param name="sender">Object which initiated the event</param>
        /// <param name="e">Event data</param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check that the User has not modified after or entered new Information before current or previous ListView Selection
                Information compareWith = new Information(textBoxName.Text, comboBoxCategory.Text, radioButtonStructureGetSelected(), textBoxDefinition.Text);
                if (!informationMatches(WikiList.ElementAt(listViewWiki.SelectedIndices[0]), compareWith))
                    DisplayToLabelMsg("ERROR: Information no longer Matches current Selection from List", statusBarErrorMsg);
                else
                {
                    DialogResult DeleteValue = MessageBox.Show("Are you sure you want to Delete this Information?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (DeleteValue == DialogResult.Yes)
                    {
                        WikiList.RemoveAt(listViewWiki.SelectedIndices[0]);
                        DisplayToLabelMsg("Information with Name: \"" + textBoxName.Text + "\" Deleted from Wiki List", statusBarUserMsg);
                        displayWikiInformation();
                        clearFormData();
                    }
                    else
                        DisplayToLabelMsg("User Cancelled Deletion of Information", statusBarUserMsg);
                }
            }
            catch
            {
                DisplayToLabelMsg("ERROR: Select a Wiki Name from ListView", statusBarErrorMsg);
            }
        }
        #endregion

        #endregion

        #region Structure RadioButtons Utilities ✔

        #region radioButtonStructureGetSelected ✔
        /// <summary>
        /// Returns Text from selected Structure Radio Button
        /// If nothing is selected returns Empty String
        /// </summary>
        /// <returns>Text from Selected Struture RadioButton</returns>
        private string radioButtonStructureGetSelected()
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

        #region ListView Utilities

        #region Display WikiList in ListView - displayWikiInformation ✔
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

        #region Display Data from selected ListView in Form - listViewWiki_MouseClick ✔
        /// <summary>
        /// Load Form with Data from User Selected ListView Item
        /// </summary>
        /// <param name="sender">Object which initiated the event</param>
        /// <param name="e">Event data</param>
        private void listViewWiki_MouseClick(object sender, MouseEventArgs e)
        {
            int selectedItem = listViewWiki.SelectedIndices[0];

            // Load Form with Data from ListView Selection
            textBoxName.Text = WikiList[selectedItem].GetName();
            comboBoxCategory.Text = WikiList[selectedItem].GetCatergory();
            switch (WikiList[selectedItem].GetStructure())
            {
                case "Linear":
                    radioButtonStructureSetSelection(1);
                    break;
                case "Non-Linear":
                    radioButtonStructureSetSelection(2);
                    break;
            }
            textBoxDefinition.Text = WikiList[selectedItem].GetDefinition();

            DisplayToLabelMsg("Information with Name: " + textBoxName.Text + " Selected from the List View", statusBarUserMsg);
        }
        #endregion

        #endregion

        #region Clear Form Data - clearFormData
        /// <summary>
        /// Clears all From Input Data and refocuses on Name input
        /// </summary>
        private void clearFormData()
        {
            textBoxName.Clear(); // Clear TextBox Name
            errorProviderNameCorrect.Clear(); // Clear Error Provider Icon for Name
            comboBoxCategory.ResetText(); // Clear ComboBox Category Selection
            radioButtonStructureClearSelections(); // Clear RadioButtons Structure Selections
            textBoxDefinition.Clear(); // Clear TextBox Definition
            textBoxName.Focus(); // Focus User Input on Name
        }
        #endregion

        #region Form Setup Utilities ✔

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

        #region loadCategoryComboBox - Load Array into Category ComboBox ✔
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

        #region comboBoxCategory_KeyPress - prevent user input from keypress - Selection from ComboBox Only Possible ✔
        /// <summary>
        /// Prevent ComboBox from manual entry from user
        /// </summary>
        /// <param name="sender">Object which initiated the event</param>
        /// <param name="e">Event data</param>
        private void comboBoxCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // prevent keypress
        }
        #endregion

        #region listViewWiki_ColumnWidthChanging - prevent user from moving ListView Columns ✔
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

        #endregion

        #region Validation Utilities ✔

        #region Validation Utilities - For Wiki Name Input ✔

        #region validName - Prevent Duplicates ✔
        /// <summary>
        /// Checks for Duplicate Information Name in Information WikiList
        /// </summary>
        /// <param name="checkListName">Wiki Name to check for duplicates</param>
        /// <returns>Boolean Valid - True, InValid - False</returns>
        private Boolean validName(string checkListName)
        {
            Boolean noDuplicateFound = true;

            // Check each Information Instance in WikiList for duplicate name
            foreach (var wikiInformation in WikiList)
            {
                if (wikiInformation.GetName().Equals(checkListName))
                {
                    noDuplicateFound = false;
                    break;
                }
            }
            return noDuplicateFound;
        }
        #endregion

        #region textBoxName_Validating - User Error Messaging ✔
        /// <summary>
        /// Validate textBoxName Input Error Messaging
        /// </summary>
        /// <param name="sender">Object which initiated the event</param>
        /// <param name="e">Event data</param>
        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text)) // Clear Valid error messaging icon in case Name cleared by user after Valid input and user moves to another input
            {
                errorProviderNameCorrect.Clear();
            } 
            else if (!validName(textBoxName.Text)) // Name duplicated - else if - now not duplicated clear error messaging
            {
                e.Cancel = true; // Prevent other events
                inCorrectNameError(); // Message User to fix Duplicate Information Name
            }
            else
            {
                e.Cancel = false; // Allow other events
                errorProviderNameInCorrect.Clear();
                errorProviderNameCorrect.SetError(textBoxName, "Valid"); // icon hover user message
                toolStripStatusLabelUserMessinging.Text = ""; // Clear the User Status Strip User Messaging
            }
        }
        #endregion

        #region textBoxName_KeyPress - Clear Error Messaging ✔
        /// <summary>
        /// On KeyPress for textBoxName Clear all the Error Providers and toolStripStatusLabelUserMessinging
        /// </summary>
        /// <param name="sender">Object which initiated the event</param>
        /// <param name="e">Event data</param>
        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Clear all error providers on textBoxName
            errorProviderNameInCorrect.Clear();
            errorProviderNameInCorrect.Clear();
            toolStripStatusLabelUserMessinging.Text = ""; // Clear the User Status Strip User Messaging
        }
        #endregion

        #region Error Provider Message for Invalid Name - inCorrectError
        /// <summary>
        /// Display errorProvider message and icon
        /// </summary>
        private void inCorrectNameError()
        {
            textBoxName.Focus(); // Focus for user to correct input
            errorProviderNameCorrect.Clear();
            errorProviderNameInCorrect.SetError(textBoxName, "Name already Exists"); // icon hover error message
            DisplayToLabelMsg("Error: Information with Name \"" + textBoxName.Text + "\" already Exists!", statusBarErrorMsg);
        }
        #endregion

        #endregion

        #region Form Validation - validateFormInput ✔
        /// <summary>
        /// Valid All Form input - display error red panels and user messaging for invalid inputs
        /// </summary>
        /// <returns>Boolean Valid - True, InValid - False</returns>
        private Boolean validateFormInput()
        {
            Boolean formValid = true;
            string userErrorMsg = "";

            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                userErrorMsg = userErrorMsg + "- Name ";
                panelNameError.Visible = true;
                errorProviderNameCorrect.Clear();
                formValid = false;
            }

            if (string.IsNullOrWhiteSpace(comboBoxCategory.Text))
            {
                userErrorMsg = userErrorMsg + "- Category ";
                panelCategoryError.Visible = true;
                formValid = false;
            }

            if (!radioButtonLinear.Checked && !radioButtonNonLinear.Checked)
            {
                userErrorMsg = userErrorMsg + "- Struture ";
                panelStructureError.Visible = true;
                formValid = false;
            }

            if (string.IsNullOrWhiteSpace(textBoxDefinition.Text))
            {
                userErrorMsg = userErrorMsg + "- Definition";
                panelDefinitionError.Visible = true;
                formValid = false;
            }

            if (validName(textBoxName.Text))
                DisplayToLabelMsg("Error: Fill in Form Information for " + userErrorMsg, statusBarErrorMsg);

            return formValid;
        }
        #endregion

        #region Compare two Information Instances Attributes - informationMatches ✔
        /// <summary>
        /// Compares Attributes for SelectedIndices Information Instance with Current Form Information created compareWith Instance
        /// </summary>
        /// <param name="selectedInformation">Object which initiated the event</param>
        /// <param name="compareWith">Event data</param>
        /// <returns></returns>
        private Boolean informationMatches(Information selectedInformation, Information compareWith)
        {
            return string.Equals(selectedInformation.GetName(), compareWith.GetName())
                && string.Equals(selectedInformation.GetCatergory(), compareWith.GetCatergory())
                && string.Equals(selectedInformation.GetStructure(), compareWith.GetStructure())
                && string.Equals(selectedInformation.GetDefinition(), compareWith.GetDefinition());
        }
        #endregion

        #region Error Red Panels Utilities ✔

        #region Clear Error Panels Upon Mouse Click ✔
        /// <summary>
        /// Clears panelNameError, comboBoxCategory, panelCategoryError, panelDefinitionError
        /// </summary>
        /// <param name="sender">Object which initiated the event</param>
        /// <param name="e">Event data</param>
        private void panelNameError_MouseClick(object sender, MouseEventArgs e)
        {
            panelNameError.Visible = false;
            textBoxName.Focus();
        }
        private void comboBoxCategory_MouseClick(object sender, MouseEventArgs e)
        {
            if (validName(textBoxName.Text))
                panelCategoryError.Visible = false;
            else inCorrectNameError();
        }
        private void panelCategoryError_MouseClick(object sender, MouseEventArgs e)
        {
            if (validName(textBoxName.Text))
            {
                panelCategoryError.Visible = false;
                comboBoxCategory.Focus();
            }
            else inCorrectNameError();
        }
        private void radioButtonLinear_MouseClick(object sender, MouseEventArgs e)
        {
            if (validName(textBoxName.Text))
                panelStructureError.Visible = false;
            else inCorrectNameError();
        }
        private void radioButtonNonLinear_MouseClick(object sender, MouseEventArgs e)
        {
            if (validName(textBoxName.Text))
                panelStructureError.Visible = false;
            else inCorrectNameError();
        }
        private void panelDefinitionError_MouseClick(object sender, MouseEventArgs e)
        {
            if (validName(textBoxName.Text))
            {
                panelDefinitionError.Visible = false;
                textBoxDefinition.Focus();
            }
            else inCorrectNameError();
        }
        #endregion

        #region clearAllErrorPanels ✔
        /// <summary>
        /// Clear all of the error red panels
        /// </summary>
        private void clearAllErrorPanels()
        {
            panelNameError.BringToFront();
            panelNameError.Visible = false;

            panelCategoryError.BringToFront();
            panelCategoryError.Visible = false;
            
            panelStructureError.Visible = false;
            
            panelDefinitionError.BringToFront();
            panelDefinitionError.Visible = false;
        }
        #endregion
        
        #endregion

        #region DisplayToLabelMsg - ToolStripStatus User Messaging Utility ✔
        /// <summary>
        /// Displays string with given onto toolStripStatusLabelUserMessinging and flashes 
        /// statusStripUserMessaging to draw attention to user that message has been updated
        /// </summary>
        /// <param name="message">The string to Display in the Tool Label</param>
        /// <param name="colour">Colour to set showed message text</param>
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
