namespace WikiApplication
{
    partial class WikiApplicationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WikiApplicationForm));
            this.statusStripUserMessaging = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUserMessaging = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.listViewWiki = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelName = new System.Windows.Forms.Label();
            this.linkLabelDeimosWebsite = new System.Windows.Forms.LinkLabel();
            this.labelWikiTitleLogo = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDefinition = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.panelWikiInput = new System.Windows.Forms.Panel();
            this.panelStructure = new System.Windows.Forms.Panel();
            this.radioButtonLinear = new System.Windows.Forms.RadioButton();
            this.radioButtonNonLinear = new System.Windows.Forms.RadioButton();
            this.panelStructureError = new System.Windows.Forms.Panel();
            this.labelStructure = new System.Windows.Forms.Label();
            this.labelDefinition = new System.Windows.Forms.Label();
            this.panelNameError = new System.Windows.Forms.Panel();
            this.panelCategoryError = new System.Windows.Forms.Panel();
            this.panelDefinitionError = new System.Windows.Forms.Panel();
            this.panelWikiList = new System.Windows.Forms.Panel();
            this.errorProviderNameInCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNameCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStripUserMessaging.SuspendLayout();
            this.panelWikiInput.SuspendLayout();
            this.panelStructure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNameInCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNameCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStripUserMessaging
            // 
            this.statusStripUserMessaging.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statusStripUserMessaging.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripUserMessaging.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUserMessaging});
            this.statusStripUserMessaging.Location = new System.Drawing.Point(0, 631);
            this.statusStripUserMessaging.Name = "statusStripUserMessaging";
            this.statusStripUserMessaging.Size = new System.Drawing.Size(684, 30);
            this.statusStripUserMessaging.TabIndex = 0;
            this.statusStripUserMessaging.Text = "statusStripUserMesseging";
            this.toolTip1.SetToolTip(this.statusStripUserMessaging, "User Messaging");
            // 
            // toolStripStatusLabelUserMessaging
            // 
            this.toolStripStatusLabelUserMessaging.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.toolStripStatusLabelUserMessaging.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabelUserMessaging.Name = "toolStripStatusLabelUserMessaging";
            this.toolStripStatusLabelUserMessaging.Size = new System.Drawing.Size(307, 25);
            this.toolStripStatusLabelUserMessaging.Text = "toolStripStatusLabelUserMessaging";
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.BackColor = System.Drawing.Color.White;
            this.textBoxSearchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchName.Location = new System.Drawing.Point(313, 56);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(256, 29);
            this.textBoxSearchName.TabIndex = 12;
            this.toolTip1.SetToolTip(this.textBoxSearchName, "Enter Information Name to Search List View");
            // 
            // listViewWiki
            // 
            this.listViewWiki.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listViewWiki.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewWiki.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderCategory});
            this.listViewWiki.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewWiki.FullRowSelect = true;
            this.listViewWiki.HideSelection = false;
            this.listViewWiki.Location = new System.Drawing.Point(319, 107);
            this.listViewWiki.Name = "listViewWiki";
            this.listViewWiki.Size = new System.Drawing.Size(340, 508);
            this.listViewWiki.TabIndex = 13;
            this.toolTip1.SetToolTip(this.listViewWiki, "List View contains all Wiki Information");
            this.listViewWiki.UseCompatibleStateImageBehavior = false;
            this.listViewWiki.View = System.Windows.Forms.View.Details;
            this.listViewWiki.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listViewWiki_ColumnWidthChanging);
            this.listViewWiki.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewWiki_MouseClick);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 200;
            // 
            // columnHeaderCategory
            // 
            this.columnHeaderCategory.Text = "Category";
            this.columnHeaderCategory.Width = 140;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(143)))), ((int)(((byte)(201)))));
            this.labelName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(5, 8);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(61, 24);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name";
            // 
            // linkLabelDeimosWebsite
            // 
            this.linkLabelDeimosWebsite.AutoSize = true;
            this.linkLabelDeimosWebsite.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelDeimosWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelDeimosWebsite.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.linkLabelDeimosWebsite.LinkColor = System.Drawing.Color.White;
            this.linkLabelDeimosWebsite.Location = new System.Drawing.Point(519, 13);
            this.linkLabelDeimosWebsite.Name = "linkLabelDeimosWebsite";
            this.linkLabelDeimosWebsite.Size = new System.Drawing.Size(153, 13);
            this.linkLabelDeimosWebsite.TabIndex = 14;
            this.linkLabelDeimosWebsite.TabStop = true;
            this.linkLabelDeimosWebsite.Text = "DEIMOS CODING PROJECTS";
            this.toolTip1.SetToolTip(this.linkLabelDeimosWebsite, "Deimos Coding Projects Website Link");
            this.linkLabelDeimosWebsite.Click += new System.EventHandler(this.linkLabelDeimosWebsite_Click);
            // 
            // labelWikiTitleLogo
            // 
            this.labelWikiTitleLogo.AutoSize = true;
            this.labelWikiTitleLogo.BackColor = System.Drawing.Color.Transparent;
            this.labelWikiTitleLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWikiTitleLogo.Location = new System.Drawing.Point(52, 8);
            this.labelWikiTitleLogo.Name = "labelWikiTitleLogo";
            this.labelWikiTitleLogo.Size = new System.Drawing.Size(283, 24);
            this.labelWikiTitleLogo.TabIndex = 10;
            this.labelWikiTitleLogo.Text = "WikiList Title Logo goes Here";
            this.toolTip1.SetToolTip(this.labelWikiTitleLogo, "Wiki Application Title and Version");
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(143)))), ((int)(((byte)(201)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(70)))), ((int)(((byte)(143)))));
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(12, 55);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(86, 30);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "ADD";
            this.toolTip1.SetToolTip(this.buttonAdd, "Add Form Information to List View");
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(143)))), ((int)(((byte)(201)))));
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(70)))), ((int)(((byte)(143)))));
            this.buttonEdit.FlatAppearance.BorderSize = 2;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(109, 55);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(86, 30);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "EDIT";
            this.toolTip1.SetToolTip(this.buttonEdit, "Edit Form Information to List View");
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(143)))), ((int)(((byte)(201)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(70)))), ((int)(((byte)(143)))));
            this.buttonDelete.FlatAppearance.BorderSize = 2;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(206, 55);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(86, 30);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "DELETE";
            this.toolTip1.SetToolTip(this.buttonDelete, "Delete Form Information from List View");
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(143)))), ((int)(((byte)(201)))));
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(70)))), ((int)(((byte)(143)))));
            this.buttonSearch.FlatAppearance.BorderSize = 2;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(575, 55);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(86, 30);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "SEARCH";
            this.toolTip1.SetToolTip(this.buttonSearch, "Search List View for Information Name");
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(143)))), ((int)(((byte)(201)))));
            this.buttonOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(70)))), ((int)(((byte)(143)))));
            this.buttonOpen.FlatAppearance.BorderSize = 2;
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.Location = new System.Drawing.Point(12, 592);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(86, 30);
            this.buttonOpen.TabIndex = 6;
            this.buttonOpen.Text = "OPEN";
            this.toolTip1.SetToolTip(this.buttonOpen, "Open File of Wiki Information");
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(143)))), ((int)(((byte)(201)))));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(70)))), ((int)(((byte)(143)))));
            this.buttonSave.FlatAppearance.BorderSize = 2;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(206, 592);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(86, 30);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "SAVE";
            this.toolTip1.SetToolTip(this.buttonSave, "Save File of Wiki Information");
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(143)))), ((int)(((byte)(201)))));
            this.labelCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.Color.Black;
            this.labelCategory.Location = new System.Drawing.Point(5, 53);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(85, 24);
            this.labelCategory.TabIndex = 11;
            this.labelCategory.Text = "Category";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.White;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(97, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(175, 29);
            this.textBoxName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxName, "Enter Information Name");
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            this.textBoxName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxName_MouseDoubleClick);
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating);
            // 
            // textBoxDefinition
            // 
            this.textBoxDefinition.BackColor = System.Drawing.Color.White;
            this.textBoxDefinition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDefinition.Location = new System.Drawing.Point(6, 224);
            this.textBoxDefinition.Multiline = true;
            this.textBoxDefinition.Name = "textBoxDefinition";
            this.textBoxDefinition.Size = new System.Drawing.Size(266, 247);
            this.textBoxDefinition.TabIndex = 11;
            this.toolTip1.SetToolTip(this.textBoxDefinition, "Enter Information Definition");
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.BackColor = System.Drawing.Color.White;
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(97, 50);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(175, 32);
            this.comboBoxCategory.TabIndex = 8;
            this.toolTip1.SetToolTip(this.comboBoxCategory, "Select Information Category");
            this.comboBoxCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxCategory_KeyPress);
            this.comboBoxCategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxCategory_MouseClick);
            // 
            // panelWikiInput
            // 
            this.panelWikiInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(143)))), ((int)(((byte)(201)))));
            this.panelWikiInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWikiInput.Controls.Add(this.panelStructure);
            this.panelWikiInput.Controls.Add(this.labelStructure);
            this.panelWikiInput.Controls.Add(this.labelDefinition);
            this.panelWikiInput.Controls.Add(this.textBoxDefinition);
            this.panelWikiInput.Controls.Add(this.comboBoxCategory);
            this.panelWikiInput.Controls.Add(this.labelCategory);
            this.panelWikiInput.Controls.Add(this.textBoxName);
            this.panelWikiInput.Controls.Add(this.labelName);
            this.panelWikiInput.Controls.Add(this.panelNameError);
            this.panelWikiInput.Controls.Add(this.panelCategoryError);
            this.panelWikiInput.Controls.Add(this.panelDefinitionError);
            this.panelWikiInput.Location = new System.Drawing.Point(12, 100);
            this.panelWikiInput.Name = "panelWikiInput";
            this.panelWikiInput.Size = new System.Drawing.Size(280, 479);
            this.panelWikiInput.TabIndex = 15;
            // 
            // panelStructure
            // 
            this.panelStructure.BackColor = System.Drawing.Color.White;
            this.panelStructure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStructure.Controls.Add(this.radioButtonLinear);
            this.panelStructure.Controls.Add(this.radioButtonNonLinear);
            this.panelStructure.Controls.Add(this.panelStructureError);
            this.panelStructure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelStructure.Location = new System.Drawing.Point(6, 126);
            this.panelStructure.Name = "panelStructure";
            this.panelStructure.Size = new System.Drawing.Size(266, 60);
            this.panelStructure.TabIndex = 17;
            // 
            // radioButtonLinear
            // 
            this.radioButtonLinear.AutoSize = true;
            this.radioButtonLinear.BackColor = System.Drawing.Color.White;
            this.radioButtonLinear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioButtonLinear.ForeColor = System.Drawing.Color.Black;
            this.radioButtonLinear.Location = new System.Drawing.Point(16, 14);
            this.radioButtonLinear.Name = "radioButtonLinear";
            this.radioButtonLinear.Size = new System.Drawing.Size(80, 28);
            this.radioButtonLinear.TabIndex = 9;
            this.radioButtonLinear.TabStop = true;
            this.radioButtonLinear.Text = "Linear";
            this.toolTip1.SetToolTip(this.radioButtonLinear, "Select Information Structure");
            this.radioButtonLinear.UseVisualStyleBackColor = false;
            this.radioButtonLinear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonLinear_MouseClick);
            // 
            // radioButtonNonLinear
            // 
            this.radioButtonNonLinear.AutoSize = true;
            this.radioButtonNonLinear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioButtonNonLinear.ForeColor = System.Drawing.Color.Black;
            this.radioButtonNonLinear.Location = new System.Drawing.Point(126, 14);
            this.radioButtonNonLinear.Name = "radioButtonNonLinear";
            this.radioButtonNonLinear.Size = new System.Drawing.Size(122, 28);
            this.radioButtonNonLinear.TabIndex = 9;
            this.radioButtonNonLinear.TabStop = true;
            this.radioButtonNonLinear.Text = "Non-Linear";
            this.toolTip1.SetToolTip(this.radioButtonNonLinear, "Select Information Structure");
            this.radioButtonNonLinear.UseVisualStyleBackColor = true;
            this.radioButtonNonLinear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonNonLinear_MouseClick);
            // 
            // panelStructureError
            // 
            this.panelStructureError.BackgroundImage = global::WikiApplication.Properties.Resources.StructureErrorImage;
            this.panelStructureError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelStructureError.Location = new System.Drawing.Point(-1, -1);
            this.panelStructureError.Name = "panelStructureError";
            this.panelStructureError.Size = new System.Drawing.Size(266, 60);
            this.panelStructureError.TabIndex = 9;
            // 
            // labelStructure
            // 
            this.labelStructure.AutoSize = true;
            this.labelStructure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(143)))), ((int)(((byte)(201)))));
            this.labelStructure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStructure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStructure.ForeColor = System.Drawing.Color.Black;
            this.labelStructure.Location = new System.Drawing.Point(5, 98);
            this.labelStructure.Name = "labelStructure";
            this.labelStructure.Size = new System.Drawing.Size(115, 24);
            this.labelStructure.TabIndex = 15;
            this.labelStructure.Text = "Structure      ";
            // 
            // labelDefinition
            // 
            this.labelDefinition.AutoSize = true;
            this.labelDefinition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(143)))), ((int)(((byte)(201)))));
            this.labelDefinition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefinition.ForeColor = System.Drawing.Color.Black;
            this.labelDefinition.Location = new System.Drawing.Point(5, 197);
            this.labelDefinition.Name = "labelDefinition";
            this.labelDefinition.Size = new System.Drawing.Size(87, 24);
            this.labelDefinition.TabIndex = 16;
            this.labelDefinition.Text = "Definition";
            // 
            // panelNameError
            // 
            this.panelNameError.BackColor = System.Drawing.Color.White;
            this.panelNameError.BackgroundImage = global::WikiApplication.Properties.Resources.NameErrorImage;
            this.panelNameError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelNameError.Location = new System.Drawing.Point(96, 6);
            this.panelNameError.Name = "panelNameError";
            this.panelNameError.Size = new System.Drawing.Size(175, 29);
            this.panelNameError.TabIndex = 19;
            this.panelNameError.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelNameError_MouseClick);
            // 
            // panelCategoryError
            // 
            this.panelCategoryError.BackColor = System.Drawing.Color.White;
            this.panelCategoryError.BackgroundImage = global::WikiApplication.Properties.Resources.CategoryErrorImage;
            this.panelCategoryError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCategoryError.Location = new System.Drawing.Point(98, 50);
            this.panelCategoryError.Name = "panelCategoryError";
            this.panelCategoryError.Size = new System.Drawing.Size(158, 32);
            this.panelCategoryError.TabIndex = 20;
            this.panelCategoryError.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelCategoryError_MouseClick);
            // 
            // panelDefinitionError
            // 
            this.panelDefinitionError.BackColor = System.Drawing.Color.White;
            this.panelDefinitionError.BackgroundImage = global::WikiApplication.Properties.Resources.DefinitionErrorImage;
            this.panelDefinitionError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDefinitionError.Location = new System.Drawing.Point(7, 224);
            this.panelDefinitionError.Name = "panelDefinitionError";
            this.panelDefinitionError.Size = new System.Drawing.Size(266, 247);
            this.panelDefinitionError.TabIndex = 22;
            this.panelDefinitionError.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelDefinitionError_MouseClick);
            // 
            // panelWikiList
            // 
            this.panelWikiList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(143)))), ((int)(((byte)(201)))));
            this.panelWikiList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWikiList.Location = new System.Drawing.Point(312, 100);
            this.panelWikiList.Name = "panelWikiList";
            this.panelWikiList.Size = new System.Drawing.Size(354, 522);
            this.panelWikiList.TabIndex = 16;
            // 
            // errorProviderNameInCorrect
            // 
            this.errorProviderNameInCorrect.ContainerControl = this;
            this.errorProviderNameInCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderNameInCorrect.Icon")));
            this.errorProviderNameInCorrect.RightToLeft = true;
            // 
            // errorProviderNameCorrect
            // 
            this.errorProviderNameCorrect.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderNameCorrect.ContainerControl = this;
            this.errorProviderNameCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderNameCorrect.Icon")));
            this.errorProviderNameCorrect.RightToLeft = true;
            // 
            // WikiApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelWikiTitleLogo);
            this.Controls.Add(this.linkLabelDeimosWebsite);
            this.Controls.Add(this.listViewWiki);
            this.Controls.Add(this.textBoxSearchName);
            this.Controls.Add(this.statusStripUserMessaging);
            this.Controls.Add(this.panelWikiInput);
            this.Controls.Add(this.panelWikiList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WikiApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WikiList Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WikiApplicationForm_FormClosing);
            this.Load += new System.EventHandler(this.WikiApplicationForm_Load);
            this.statusStripUserMessaging.ResumeLayout(false);
            this.statusStripUserMessaging.PerformLayout();
            this.panelWikiInput.ResumeLayout(false);
            this.panelWikiInput.PerformLayout();
            this.panelStructure.ResumeLayout(false);
            this.panelStructure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNameInCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNameCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripUserMessaging;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUserMessaging;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.ListView listViewWiki;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.LinkLabel linkLabelDeimosWebsite;
        private System.Windows.Forms.Label labelWikiTitleLogo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDefinition;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Panel panelWikiInput;
        private System.Windows.Forms.Panel panelWikiList;
        private System.Windows.Forms.Label labelDefinition;
        private System.Windows.Forms.Label labelStructure;
        private System.Windows.Forms.RadioButton radioButtonNonLinear;
        private System.Windows.Forms.RadioButton radioButtonLinear;
        private System.Windows.Forms.Panel panelStructure;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderCategory;
        private System.Windows.Forms.ErrorProvider errorProviderNameInCorrect;
        private System.Windows.Forms.ErrorProvider errorProviderNameCorrect;
        private System.Windows.Forms.Panel panelDefinitionError;
        private System.Windows.Forms.Panel panelStructureError;
        private System.Windows.Forms.Panel panelCategoryError;
        private System.Windows.Forms.Panel panelNameError;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

