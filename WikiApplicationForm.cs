using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

/// <summary>
/// Project: WikiList Application
/// 
/// Fully functional wiki application for categories and definitions
/// for Data Structures for CITE Managed Services junior programmers.
/// 
/// © Bruce Fisher P197681 - Deimos Coding Projects
/// Date: 12/05/2022
/// Version: v2.6
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
        #region Global Variables ✔
        // Application Version Number
        const string versionNo = "v2.6";

        // Target for link label linkLabelDeimosWebsite
        const string target = "https://deimoscodingprojects.com/";

        // List to store WikiList Information Class
        List<Information> WikiList = new List<Information>();

        // TextInfo based on the "en-US" culture see MSDN link https://docs.microsoft.com/en-us/dotnet/api/system.globalization.textinfo.totitlecase?view=net-6.0
        // Found best to use as well ToLower() in case User entered Full CAPITILIZED text - as ToTitleCase will leave as is
        TextInfo textinfo = new CultureInfo("en-US", false).TextInfo;

        //ComboBox Max Array Length
        const int comboBoxArrayLength = 6;

        // Category String Array - DEFAULT - in case file for ComboBox not found
        string[] categories = new string[comboBoxArrayLength] { "Array", "List", "Tree", "Graphs", "Abstract", "Hash" };

        // Category File Name to use
        const string comboBoxCatergoriesFileName = "comboBoxCatergories.txt";

        // Used to prevent Name Displaying duplicate errorProvider messaging when editing Information
        Boolean editingNotDuplicate = false; // Disable duplicate error messaging

        // Used to create default File Name to Open and Save
        const string useFileName = "definitions.bin";

        // SubFolder "files" for file to be saved in - if does not exist at Executable Path it is created at WikiPrototypeForm_Load
        // Allows application to run anywhere as a stand alone executable
        string filesFolderPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Files\";

        // Default files folder used within current Application Executable Path - Allows application to run on anywhere
        string defaultFileFolder = Path.GetDirectoryName(Application.ExecutablePath) + @"\Files\";

        // Default files folder name
        const string defaultFileFolderName = "Files";

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
            // Attempt to create "Files" folder for all files to be saved to
            createFilesFolder();

            // WikiList Logo Title
            labelWikiTitleLogo.Text = "Wiki Application " + versionNo;

            // Read Category File Name into Array catergories
            openComboBoxTextFile(defaultFileFolder + comboBoxCatergoriesFileName);

            // prefill Category ComboBox from Array categories
            loadCategoryComboBox();

            // Clear all Error Red Panels
            clearAllErrorPanels();

            // Clear the User Status Strip User Messaging
            toolStripStatusLabelUserMessaging.Text = "";

            // Focus User Input on Name at start
            textBoxName.Select();
            textBoxName.Focus();
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

        #region Create Folder defaultFileFolderName - createFilesFolder ✔
        private void createFilesFolder()
        {
            // If "Files" folder does not exist at Executable Path then try to create
            try
            {
                if (!Directory.Exists(filesFolderPath))
                {
                    Directory.CreateDirectory(filesFolderPath);
                    MessageBox.Show("Have Created Sub Folder \"" + defaultFileFolderName + "\" as did not Exist", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Cannot Create Folder \"" + defaultFileFolderName + "\"!", "SYSTEM ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #endregion

        #region Form Buttons ✔
        #region ADD Button ✔
        /// <summary>
        /// Add to WikiList Information from Form Input and ReDisplay ListView
        /// </summary>
        /// <param name="sender">Object which initiated the event</param>
        /// <param name="e">Event data</param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string oldTextBoxNameContents = textinfo.ToTitleCase(textBoxName.Text.ToLower());

            // Check for Duplicate Information Name in WikiList with validName
            if (!validName(textinfo.ToTitleCase(textBoxName.Text.ToLower())))
                inCorrectNameError();

            // Check validity of Form Input and check for Duplicate Information Name with validName then Add Information Form to WikiList as Object
            if (validateFormInput() && validName(textinfo.ToTitleCase(textBoxName.Text.ToLower())))
            {
                toolStripStatusLabelUserMessaging.Text = ""; // Clear the User Status Strip User Messaging
                // Use Information Constructor to Add Information Object to WikiList
                WikiList.Add(new Information(textinfo.ToTitleCase(textBoxName.Text.ToLower()), comboBoxCategory.Text, radioButtonStructureGetSelected(), textBoxDefinition.Text));
                clearFormData(); // Clean Up Form
                DisplayToLabelMsg("Information with Name: \"" + oldTextBoxNameContents + "\" Added to Wiki List.", statusBarUserMsg);
                displayWikiInformation(); // Display WikiList to ListView
            }
        }
        #endregion

        #region EDIT Button ✔
        /// <summary>
        /// Edit the selected Wiki Information selected from ListView into WikiList
        /// </summary>
        /// <param name="sender">Object which initiated the event</param>
        /// <param name="e">Event data</param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            clearAllErrorPanels(); // clean up Add error
            try
            {
                string oldTextBoxNameContents = textinfo.ToTitleCase(textBoxName.Text.ToLower());
                WikiList[listViewWiki.SelectedIndices[0]] = new Information(textinfo.ToTitleCase(textBoxName.Text.ToLower()), comboBoxCategory.Text, radioButtonStructureGetSelected(), textBoxDefinition.Text);
                clearFormData(); // clean up form
                DisplayToLabelMsg("Information with Name: \"" + oldTextBoxNameContents + "\" Edited in Wiki List.", statusBarUserMsg);
                displayWikiInformation(); // Display WikiList to ListView  
            }
            catch
            {
                DisplayToLabelMsg("ERROR: Select a Wiki Name from ListView!", statusBarErrorMsg);
            }
        }
        #endregion

        #region DELETE Button ✔
        /// <summary>
        /// Delete the Information for WikiList Selected from the ListView with user Confirmation
        /// </summary>
        /// <param name="sender">Object which initiated the event</param>
        /// <param name="e">Event data</param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            clearAllErrorPanels(); // clean up Add error
            try
            {
                string oldTextBoxNameContents = textinfo.ToTitleCase(textBoxName.Text.ToLower());
                // Check that the User has not modified after or entered new Information before current or previous ListView Selection
                Information compareWith = new Information(textinfo.ToTitleCase(textBoxName.Text.ToLower()), comboBoxCategory.Text, radioButtonStructureGetSelected(), textBoxDefinition.Text);
                if (!informationMatches(WikiList.ElementAt(listViewWiki.SelectedIndices[0]), compareWith))
                    DisplayToLabelMsg("ERROR: Information no longer Matches current Selection from List!", statusBarErrorMsg);
                else
                {
                    DialogResult DeleteValue = MessageBox.Show("Are you sure you want to Delete this Information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (DeleteValue == DialogResult.Yes)
                    {
                        WikiList.RemoveAt(listViewWiki.SelectedIndices[0]);
                        clearFormData(); // clean up form
                        DisplayToLabelMsg("Information with Name: \"" + oldTextBoxNameContents + "\" Deleted from Wiki List.", statusBarUserMsg);
                        displayWikiInformation(); // Display WikiList to ListView
                    }
                    else DisplayToLabelMsg("User Cancelled Deletion of Information.", statusBarUserMsg);
                }
            }
            catch
            {
                DisplayToLabelMsg("ERROR: Select a Wiki Name from ListView!", statusBarErrorMsg);
            }
        }
        #endregion

        #region SEARCH Button ✔
        /// <summary>
        /// Search WikiList for Name given from textBoxSearchName
        /// List does not need to be sorted as done with each change to WikiList when displayed in ListView
        /// </summary>
        /// <param name="sender">Object which initiated the event</param>
        /// <param name="e">Event data</param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            clearAllErrorPanels(); // clean up Add error
            if (WikiList.Count != 0)
            {
                if (!string.IsNullOrWhiteSpace(textBoxSearchName.Text))
                {
                    Information nameCompare = new Information(); // Instance of Information to pass to BinarySearch
                    // Search Text Box Text input converted to lower to allow CAPITALIZED input - then Title Case
                    nameCompare.SetName(textinfo.ToTitleCase(textBoxSearchName.Text.ToLower())); // Compare with <Information>textBoxSearchName
                    int foundIndex = WikiList.BinarySearch(nameCompare); // Search WikiList for textBoxSearchName
                    if (foundIndex > -1) // BinarySearch Returns bitwise complement ~-1 meaning could be less than -1 to support inserting items
                    {
                        clearErrorProviders(); // Clear all Error Providers
                        // Load Form with Data from BinarySearch foundIndex
                        textBoxName.Text = WikiList[foundIndex].GetName();
                        comboBoxCategory.Text = WikiList[foundIndex].GetCatergory();
                        switch (WikiList[foundIndex].GetStructure())
                        {
                            case "Linear":
                                radioButtonStructureSetSelection(1);
                                break;
                            case "Non-Linear":
                                radioButtonStructureSetSelection(2);
                                break;
                        }
                        textBoxDefinition.Text = WikiList[foundIndex].GetDefinition();

                        if (listViewWiki.SelectedIndices[0] != -1)
                            listViewWiki.Items[listViewWiki.SelectedIndices[0]].Selected = false;

                      /*  try
                        {
                            // Clear Possible Previous Selected Item - prevents two from being selected
                            listViewWiki.Items[listViewWiki.SelectedIndices[0]].Selected = false;
                        }
                        catch
                        {
                            // do nothing - prevent crash when nothing was selected
                        }*/

                        // Set ListView Item to Found Item
                        listViewWiki.Items[foundIndex].Selected = true; // Set selection on List View to found Search Name
                        listViewWiki.Focus(); // Focus on List View to Highlight in Blue the Selection

                        DisplayToLabelMsg("Information with Name: \"" + textinfo.ToTitleCase(textBoxSearchName.Text.ToLower()) + "\" Found!", statusBarUserMsg);
                    }
                    else DisplayToLabelMsg("Information with Name: \"" + textinfo.ToTitleCase(textBoxSearchName.Text.ToLower()) + "\" NOT Found!", statusBarUserMsg);
                }
                else DisplayToLabelMsg("ERROR: Enter Name to Search!", statusBarErrorMsg);
            }
            else DisplayToLabelMsg("ERROR: Nothing in the Wiki List to Search!", statusBarErrorMsg);
            textBoxSearchName.Clear();
        }
        #endregion

        #region SAVE Button ✔
        /// <summary>
        /// Save WikiList to User Selected FileName
        /// </summary>
        /// <param name="sender">Object which initiated the event</param>
        /// <param name="e">Event data</param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveBinaryDialog = new SaveFileDialog();
            saveBinaryDialog.InitialDirectory = defaultFileFolder;

            saveBinaryDialog.Filter = "bin files (*.bin)|*.bin";
            string userSelectedFileName = "";

            if (WikiList.Count != 0)
            {
                DialogResult sr = saveBinaryDialog.ShowDialog();
                if (sr == DialogResult.OK)
                {
                    clearFormData(); // Clean Up Form
                    userSelectedFileName = saveBinaryDialog.FileName;
                    if (saveBinaryFile(userSelectedFileName))
                        DisplayToLabelMsg("Binary File \"" + Path.GetFileName(userSelectedFileName) + "\" Saved.", statusBarUserMsg);
                    else
                        MessageBox.Show("Cannot Write data to file " + Path.GetFileName(userSelectedFileName) + "!", "SYSTEM ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (sr == DialogResult.Cancel)
                {
                    DisplayToLabelMsg("USER CANCELLED: Did NOT Save Records to a File.", statusBarUserMsg);
                }
            }
            else DisplayToLabelMsg("ERROR: Nothing in List View WikiList to Save!", statusBarErrorMsg);
        }
        #endregion

        #region OPEN Button ✔
        /// <summary>
        /// Open User Selected FileName into WikiList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Event data</param>
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openBinaryDialog = new OpenFileDialog();
            openBinaryDialog.InitialDirectory = defaultFileFolder;
            openBinaryDialog.FileName = useFileName; // default File Name

            openBinaryDialog.Filter = "bin files (*.bin)|*.bin";
            string userSelectedFileName = "";

            DialogResult sr = openBinaryDialog.ShowDialog();
            if (sr == DialogResult.OK)
            {
                userSelectedFileName = openBinaryDialog.FileName; // Use file from User Selected/Entered Filename

                if (openBinaryFile(userSelectedFileName))
                {
                    displayWikiInformation(); // Display WikiList to ListView
                    clearFormData(); // Clean Up Form
                    DisplayToLabelMsg("Binary File \"" + Path.GetFileName(userSelectedFileName) + "\" Opened.", statusBarUserMsg);
                }
                else
                {
                    MessageBox.Show("Invalid File Format \"" + Path.GetFileName(userSelectedFileName) + "\"!", "SYSTEM ERROR",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DisplayToLabelMsg("ERROR: File \"" + Path.GetFileName(userSelectedFileName) + "\" Not Opened!", statusBarErrorMsg);
                }
            }
            if (sr == DialogResult.Cancel)
            {
                DisplayToLabelMsg("USER CANCELLED: Did NOT Read Records from a File.", statusBarUserMsg);
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
                    MessageBox.Show("Wrong Selection \"" + selection + "\" for Radio Buttons in Code!", "SYSTEM ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #region ListView Utilities ✔
        #region Display WikiList in ListView - displayWikiInformation ✔
        /// <summary>
        /// Sorts the WikiList using built in Sort and then Displays to ListView
        /// </summary>
        private void displayWikiInformation()
        {
            WikiList.Sort(); // Sort WikiList List of Instances of Infomation using CompareTo <Information>Name
            listViewWiki.Items.Clear(); // Clear ListView Items from listViewWiki

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
            int selectedItem = listViewWiki.SelectedIndices[0]; // Item selected from ListView

            editingNotDuplicate = false; // Disable duplicate error messaging
            clearErrorProviders(); // Clear all Error Providers

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

            DisplayToLabelMsg("Information with Name: \"" + textBoxName.Text + "\" Selected from the List View.", statusBarUserMsg);
        }
        #endregion
        #endregion

        #region Clear Form upon Double Click textBoxName - textBoxName_MouseDoubleClick ✔
        /// <summary>
        /// Clear Form with Double Click on textBoxName
        /// </summary>
        /// <param name="sender">Object which initiated the event</param>
        /// <param name="e">Event data</param>
        private void textBoxName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            clearFormData(); // Clean Up Form
        }
        #endregion

        #region Clear Form Data - clearFormData ✔
        /// <summary>
        /// Clears all From Input Data and refocuses on Name input
        /// </summary>
        private void clearFormData()
        {
            textBoxName.Clear(); // Clear TextBox Name
            comboBoxCategory.ResetText(); // Clear ComboBox Category Selection
            radioButtonStructureClearSelections(); // Clear RadioButtons Structure Selections
            textBoxDefinition.Clear(); // Clear TextBox Definition
            textBoxName.Focus(); // Focus User Input on Name
            clearErrorProviders(); // clear all Error Messaging
        }
        #endregion

        #region File IO ✔
        #region Save Binary File - saveBinaryFile ✔
        /// <summary>
        /// <summary>
        /// Save to Binary File passed fileName
        /// </summary>
        /// <param name="fileName">File Name to Save to</param>
        /// <returns>Boolean Saved - True, Not Saved - False</returns>
        private Boolean saveBinaryFile(string fileName)
        {
            Boolean fileSaved = true;
            try
            {
                using (var stream = File.Open(fileName, FileMode.Create))
                {
                    using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                    {
                        // Write all Objects Stored in List WikiList
                        foreach (var wikiInformation in WikiList)
                        {
                            // Write each Object Attribute to file
                            writer.Write(wikiInformation.GetName());
                            writer.Write(wikiInformation.GetCatergory());
                            writer.Write(wikiInformation.GetStructure());
                            writer.Write(wikiInformation.GetDefinition());
                        }
                    }
                }
            }
            catch (IOException)
            {
                fileSaved = false;
            }

            return fileSaved;
        }
        #endregion

        #region Open Binary File - openBinaryFile ✔
        /// <summary>
        /// Open to Binary File passed fileName
        /// </summary>
        /// <param name="fileName">File Name to Open</param>
        /// <returns>Boolean Opened - True, Not Opened - False</returns>
        private Boolean openBinaryFile(string fileName)
        {
            Boolean fileOpened = true;
            try
            {
                if (File.Exists(fileName))
                {
                    using (var stream = File.Open(fileName, FileMode.Open))
                    {
                        using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                        {
                            WikiList.Clear(); // Clear WikiList
                            while (stream.Position < stream.Length)
                            {
                                Information readWiki = new Information(); // temp Instance of Information Read from file
                                // Read all Attributes from file into temp Information Instance
                                readWiki.SetName(reader.ReadString());
                                readWiki.SetCategory(reader.ReadString());
                                readWiki.SetStructure(reader.ReadString());
                                readWiki.SetDefinition(reader.ReadString());
                                WikiList.Add(readWiki); // Store each record Object into List WikiList
                            }
                        }
                    }
                    displayWikiInformation(); // Display WikiList to ListView
                    clearFormData(); // Clean Up Form
                }
            }
            catch (IOException)
            {
                fileOpened = false;
            }

            return fileOpened;
        }
        #endregion

        #region Open ComboBox Text File - openComboBoxTextFile ✔
        /// <summary>
        /// Reads Text File Name passed into ComboBox catergories Array
        /// </summary>
        /// <param name="fileName">File Name to Open</param>
        private void openComboBoxTextFile(String fileName)
        {
            int categoriesIndex = 0; // used for String Array categories index
            // check if the filename exists
            if (File.Exists(fileName))
            {
                // create the reader object
                StreamReader TextReader = new StreamReader(fileName);
                // continue to loop and read until the EOF is detected
                while (!TextReader.EndOfStream)
                {
                    try
                    {
                        // read each record line for Categories ComboBox
                        categories[categoriesIndex] = TextReader.ReadLine();
                        categoriesIndex++; // increment to nex index for array
                        // Exit Text Read in case File contains more attributes than the length of Array categories
                        if (categoriesIndex < comboBoxArrayLength)
                            break;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalid File Format \"" + Path.GetFileName(fileName) + "\"!", "SYSTEM ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Close the StreamReader
                TextReader.Close();
            }
            else
            {
                MessageBox.Show("ComboBox File \"" + Path.GetFileName(fileName) + "\" does not exist - Using Default Definitions for Categories", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            return !WikiList.Exists(duplicate => duplicate.GetName() == checkListName);
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
            else if (!validName(textinfo.ToTitleCase(textBoxName.Text.ToLower())) && !editingNotDuplicate) // Name duplicated - else if - now not duplicated clear error messaging
            {
                e.Cancel = true; // Prevent other events
                inCorrectNameError(); // Message User to fix Duplicate Information Name
            }
            else
            {
                e.Cancel = false; // Allow other events
                errorProviderNameInCorrect.Clear();
                errorProviderNameCorrect.SetError(textBoxName, "Valid"); // icon hover user message
                toolStripStatusLabelUserMessaging.Text = ""; // Clear the User Status Strip User Messaging
            }
        }
        #endregion

        #region textBoxName_KeyPress - Clear Error Messaging ✔
        /// <summary>
        /// On KeyPress for textBoxName Clear all the Error Providers and toolStripStatusLabelUserMessanging
        /// </summary>
        /// <param name="sender">Object which initiated the event</param>
        /// <param name="e">Event data</param>
        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            clearErrorProviders(); // Clear all Error Providers
            editingNotDuplicate = true; // Display duplicate error messaging
        }
        #endregion

        #region Error Provider Message for Invalid Name - inCorrectNameError ✔
        /// <summary>
        /// Display errorProvider message and icon
        /// </summary>
        private void inCorrectNameError()
        {
            textBoxName.Focus(); // Focus for user to correct input
            errorProviderNameCorrect.Clear();
            errorProviderNameInCorrect.SetError(textBoxName, "Name already Exists"); // icon hover error message
            DisplayToLabelMsg("Error: Information with Name \"" + textinfo.ToTitleCase(textBoxName.Text.ToLower()) + "\" already Exists!", statusBarErrorMsg);
        }

        #region Clear Error Provider Messages - clearErrorProviders
        /// <summary>
        /// Clear all Error Providers and User Messaging
        /// </summary>
        private void clearErrorProviders()
        {
            // Clear all error providers on textBoxName
            errorProviderNameInCorrect.Clear();
            errorProviderNameCorrect.Clear();
            toolStripStatusLabelUserMessaging.Text = ""; // Clear the User Status Strip User Messaging
        }
        #endregion
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

            if (validName(textinfo.ToTitleCase(textBoxName.Text.ToLower())))
                DisplayToLabelMsg("Error: Fill in Form Information for " + userErrorMsg, statusBarErrorMsg + ".");

            return formValid;
        }
        #endregion

        #region Compare two Information Instances Attributes - informationMatches ✔
        /// <summary>
        /// Compares Attributes for SelectedIndices Information Instance with Current Form Information created compareWith Instance
        /// </summary>
        /// <param name="selectedInformation">Object which initiated the event</param>
        /// <param name="compareWith">Event data</param>
        /// <returns>Attributes Changed - True, Attributes Unchanged - False</returns>
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
            if (validName(textinfo.ToTitleCase(textBoxName.Text.ToLower())) || !editingNotDuplicate)
                panelCategoryError.Visible = false;
            else inCorrectNameError();
        }
        private void panelCategoryError_MouseClick(object sender, MouseEventArgs e)
        {
            if (validName(textinfo.ToTitleCase(textBoxName.Text.ToLower())) || !editingNotDuplicate)
            {
                panelCategoryError.Visible = false;
                comboBoxCategory.Focus();
            }
            else inCorrectNameError();
        }
        private void radioButtonLinear_MouseClick(object sender, MouseEventArgs e)
        {
            if (validName(textinfo.ToTitleCase(textBoxName.Text.ToLower())) || !editingNotDuplicate)
                panelStructureError.Visible = false;
            else inCorrectNameError();
        }
        private void radioButtonNonLinear_MouseClick(object sender, MouseEventArgs e)
        {
            if (validName(textinfo.ToTitleCase(textBoxName.Text.ToLower())) || !editingNotDuplicate)
                panelStructureError.Visible = false;
            else inCorrectNameError();
        }
        private void panelDefinitionError_MouseClick(object sender, MouseEventArgs e)
        {
            if (validName(textinfo.ToTitleCase(textBoxName.Text.ToLower())) || !editingNotDuplicate)
            {
                panelDefinitionError.Visible = false;
                textBoxDefinition.Focus();
            }
            else inCorrectNameError();
        }
        #endregion

        #region clearAllErrorPanels ✔
        /// <summary>
        /// Clear all of the error red panels and bring to front at start
        /// Set to back in Form design Properties to make it easier to edit Form Properties for Text Boxes
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
        /// Displays string with given onto toolStripStatusLabelUserMessaging and flashes 
        /// statusStripUserMessaging to draw attention to user that message has been updated
        /// </summary>
        /// <param name="message">The string to Display in the Tool Label</param>
        /// <param name="colour">Colour to set showed message text</param>
        private void DisplayToLabelMsg(string message, string colour)
        {
            switch (colour)
            {
                case "Red":
                    toolStripStatusLabelUserMessaging.ForeColor = Color.Red;
                    break;
                case "White":
                    toolStripStatusLabelUserMessaging.ForeColor = Color.White;
                    break;
            }
            toolStripStatusLabelUserMessaging.Text = message;

            // Flash statusStripUserMessaging by changing statusStripUserMessaging visable on/off
            // to bring attention to error message
            statusStripUserMessaging.Visible = false;
            System.Threading.Thread.Sleep(100); // wait time between visability of statusStripUserMessaging
            statusStripUserMessaging.Visible = true;
        }


        #endregion
        #endregion

        #region Save WikiList to File Upon Form Closing - WikiApplicationForm_FormClosing ✔
        /// <summary>
        /// Upon form closing Save WikiList to default filename
        /// </summary>
        /// <param name="sender">Object which initiated the event</param>
        /// <param name="e">Event data</param>
        private void WikiApplicationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure that you would like to close the application?", "Application Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            // If the No button pressed  
            if (DialogResult == DialogResult.No)
            {
                e.Cancel = true; // cancel the closure of the form 
            } 
            else if (WikiList.Count != 0)
                saveBinaryFile(defaultFileFolder + useFileName); // Save WikiList to default binary file name
        }
        #endregion
    }
}
