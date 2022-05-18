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
/// Project: Wiki Application
/// 
/// Fully functional wiki application for categories and definitions
/// for Data Structures for CITE Managed Services junior programmers.
/// 
/// © Bruce Fisher P197681
/// Date: 28/04/2022
/// Version: v1.4
/// 
/// Created:
/// •   Information Class 
/// •   List Wiki of Information Class
/// •   Form GUI Layout Design
/// •   Method for Status Strip Error Messaging
/// •   Create string Array from File and load into ComboBox Category
///
/// Refernce for Radio Buttons used Panel instead of Grouped Box as looks nicer on form adheres to MSDN Standard.
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
        string versionNo = "v1.4";

        // Target for link label linkLabelDeimosWebsite
        string target = "https://deimoscodingprojects.com/";

        // List to store Wiki Information Class
        List<Information> Wiki = new List<Information>();

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

        #region Validation Error Provider Events
        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
        
        }

        private void comboBoxCategory_Validating(object sender, CancelEventArgs e)
        {

        }

        private void panelStructure_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBoxDefinition_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBoxSearchName_Validating(object sender, CancelEventArgs e)
        {

        }
        #endregion

        #region DisplayToLabelMsg ✔

        // ### Proposed PC: All user interactions must have full error trapping and feedback messaging ###

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

            // Flash statusStripUserMessaging by changing statusStripUserMessaging visable on/ off
            // to bring attention to error message
            statusStripUserMessaging.Visible = false;
            System.Threading.Thread.Sleep(100); // wait time between visability of statusStripUserMessaging
            statusStripUserMessaging.Visible = true;
        }
        #endregion       
    }
}
