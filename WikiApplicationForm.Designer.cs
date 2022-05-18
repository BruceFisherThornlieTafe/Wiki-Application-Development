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
            this.toolStripStatusLabelUserMessinging = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.listViewWiki = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.linkLabelDeimosWebsite = new System.Windows.Forms.LinkLabel();
            this.labelWikiTitleLogo = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDefinition = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.panelWikiInput = new System.Windows.Forms.Panel();
            this.panelStructure = new System.Windows.Forms.Panel();
            this.radioButtonLinear = new System.Windows.Forms.RadioButton();
            this.radioButtonNonLinear = new System.Windows.Forms.RadioButton();
            this.labelStructure = new System.Windows.Forms.Label();
            this.labelDefinition = new System.Windows.Forms.Label();
            this.panelWikiList = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStripUserMessaging.SuspendLayout();
            this.panelWikiInput.SuspendLayout();
            this.panelStructure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStripUserMessaging
            // 
            this.statusStripUserMessaging.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statusStripUserMessaging.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripUserMessaging.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUserMessinging});
            this.statusStripUserMessaging.Location = new System.Drawing.Point(0, 635);
            this.statusStripUserMessaging.Name = "statusStripUserMessaging";
            this.statusStripUserMessaging.Size = new System.Drawing.Size(684, 26);
            this.statusStripUserMessaging.TabIndex = 0;
            this.statusStripUserMessaging.Text = "statusStripUserMesseging";
            // 
            // toolStripStatusLabelUserMessinging
            // 
            this.toolStripStatusLabelUserMessinging.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripStatusLabelUserMessinging.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabelUserMessinging.Name = "toolStripStatusLabelUserMessinging";
            this.toolStripStatusLabelUserMessinging.Size = new System.Drawing.Size(260, 21);
            this.toolStripStatusLabelUserMessinging.Text = "toolStripStatusLabelUserMessinging";
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.BackColor = System.Drawing.Color.White;
            this.textBoxSearchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchName.Location = new System.Drawing.Point(313, 56);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(256, 29);
            this.textBoxSearchName.TabIndex = 5;
            this.textBoxSearchName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSearchName_Validating);
            // 
            // listViewWiki
            // 
            this.listViewWiki.BackColor = System.Drawing.Color.White;
            this.listViewWiki.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewWiki.HideSelection = false;
            this.listViewWiki.Location = new System.Drawing.Point(319, 107);
            this.listViewWiki.Name = "listViewWiki";
            this.listViewWiki.Size = new System.Drawing.Size(340, 508);
            this.listViewWiki.TabIndex = 11;
            this.listViewWiki.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(143)))), ((int)(((byte)(201)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
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
            this.linkLabelDeimosWebsite.Click += new System.EventHandler(this.linkLabelDeimosWebsite_Click);
            // 
            // labelWikiTitleLogo
            // 
            this.labelWikiTitleLogo.AutoSize = true;
            this.labelWikiTitleLogo.BackColor = System.Drawing.Color.Transparent;
            this.labelWikiTitleLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWikiTitleLogo.Location = new System.Drawing.Point(52, 8);
            this.labelWikiTitleLogo.Name = "labelWikiTitleLogo";
            this.labelWikiTitleLogo.Size = new System.Drawing.Size(0, 24);
            this.labelWikiTitleLogo.TabIndex = 10;
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
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
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
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = false;
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
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
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
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = false;
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
            this.buttonOpen.TabIndex = 5;
            this.buttonOpen.Text = "OPEN";
            this.buttonOpen.UseVisualStyleBackColor = false;
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
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(143)))), ((int)(((byte)(201)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Category";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.White;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(97, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(175, 29);
            this.textBoxName.TabIndex = 6;
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
            this.textBoxDefinition.TabIndex = 10;
            this.textBoxDefinition.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDefinition_Validating);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.BackColor = System.Drawing.Color.White;
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(97, 50);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(175, 32);
            this.comboBoxCategory.TabIndex = 7;
            this.comboBoxCategory.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxCategory_Validating);
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
            this.panelWikiInput.Controls.Add(this.label2);
            this.panelWikiInput.Controls.Add(this.textBoxName);
            this.panelWikiInput.Controls.Add(this.label1);
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
            this.panelStructure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelStructure.Location = new System.Drawing.Point(6, 126);
            this.panelStructure.Name = "panelStructure";
            this.panelStructure.Size = new System.Drawing.Size(266, 60);
            this.panelStructure.TabIndex = 17;
            this.panelStructure.Validating += new System.ComponentModel.CancelEventHandler(this.panelStructure_Validating);
            // 
            // radioButtonLinear
            // 
            this.radioButtonLinear.AutoSize = true;
            this.radioButtonLinear.Location = new System.Drawing.Point(16, 14);
            this.radioButtonLinear.Name = "radioButtonLinear";
            this.radioButtonLinear.Size = new System.Drawing.Size(80, 28);
            this.radioButtonLinear.TabIndex = 8;
            this.radioButtonLinear.TabStop = true;
            this.radioButtonLinear.Text = "Linear";
            this.radioButtonLinear.UseVisualStyleBackColor = true;
            // 
            // radioButtonNonLinear
            // 
            this.radioButtonNonLinear.AutoSize = true;
            this.radioButtonNonLinear.Location = new System.Drawing.Point(126, 14);
            this.radioButtonNonLinear.Name = "radioButtonNonLinear";
            this.radioButtonNonLinear.Size = new System.Drawing.Size(122, 28);
            this.radioButtonNonLinear.TabIndex = 9;
            this.radioButtonNonLinear.TabStop = true;
            this.radioButtonNonLinear.Text = "Non-Linear";
            this.radioButtonNonLinear.UseVisualStyleBackColor = true;
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
            // panelWikiList
            // 
            this.panelWikiList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(143)))), ((int)(((byte)(201)))));
            this.panelWikiList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWikiList.Location = new System.Drawing.Point(312, 100);
            this.panelWikiList.Name = "panelWikiList";
            this.panelWikiList.Size = new System.Drawing.Size(354, 522);
            this.panelWikiList.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // WikiApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WikiApplication.Properties.Resources.Binary_Background_5;
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
            this.Name = "WikiApplicationForm";
            this.Text = "Wiki Application";
            this.statusStripUserMessaging.ResumeLayout(false);
            this.statusStripUserMessaging.PerformLayout();
            this.panelWikiInput.ResumeLayout(false);
            this.panelWikiInput.PerformLayout();
            this.panelStructure.ResumeLayout(false);
            this.panelStructure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripUserMessaging;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUserMessinging;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.ListView listViewWiki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.LinkLabel linkLabelDeimosWebsite;
        private System.Windows.Forms.Label labelWikiTitleLogo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}

