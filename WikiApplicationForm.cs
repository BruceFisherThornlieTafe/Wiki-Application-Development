using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// © Bruce Fisher P197681
/// Date: 25/04/2022
/// Version: v1.1
/// 
/// Created:
/// •   Information Class 
/// •   List Wiki of Information Class
///
/// Project: Wiki Application
///
/// Fully functional wiki application for categories and definitions
/// for Data Structures for CITE Managed Services junior programmers.
/// </summary>

namespace WikiApplication
{
    public partial class WikiApplicationForm : Form
    {
        #region Global Variables

        // List to store Wiki Information Class
        List<Information> Wiki = new List<Information>();

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
    }
}
