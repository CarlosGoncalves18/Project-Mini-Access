namespace MiniAccess_Project.GUI
{
    partial class MiniAccessForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniAccessForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mbTheme = new MetroFramework.Controls.MetroComboBox();
            this.metrolblTheme = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mbColor = new MetroFramework.Controls.MetroComboBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroButtonCreateRelations = new MetroFramework.Controls.MetroButton();
            this.metroLabelTabla2 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxIndex2 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxTabla2 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxIndex1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelTabla1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxTabla1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelChooseTables = new MetroFramework.Controls.MetroLabel();
            this.metroLabelCreateRelation = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTextBoxTableName = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonCreateTable = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTileFieldName = new MetroFramework.Controls.MetroTile();
            this.metroTileDataType = new MetroFramework.Controls.MetroTile();
            this.metroButtonRelation = new MetroFramework.Controls.MetroButton();
            this.metroButtonSaveTable = new MetroFramework.Controls.MetroButton();
            this.metroButtonCreateField = new MetroFramework.Controls.MetroButton();
            this.metroLabelCreateField = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxDataType = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBoxFieldName = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.FieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTileHome = new MetroFramework.Controls.MetroTile();
            this.metroTileDisplay = new MetroFramework.Controls.MetroTile();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.metroButtonDisplay = new MetroFramework.Controls.MetroButton();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroButtonSaveData = new MetroFramework.Controls.MetroButton();
            this.metroButtonCreateFake = new MetroFramework.Controls.MetroButton();
            this.mlblfilename = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxName = new MetroFramework.Controls.MetroTextBox();
            this.lblBlankData = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroTileExit = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroPanel5.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(867, 40);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 23);
            this.metroLabel1.TabIndex = 0;
            // 
            // mbTheme
            // 
            this.mbTheme.FormattingEnabled = true;
            this.mbTheme.ItemHeight = 23;
            this.mbTheme.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.mbTheme.Location = new System.Drawing.Point(62, 3);
            this.mbTheme.Name = "mbTheme";
            this.mbTheme.Size = new System.Drawing.Size(134, 29);
            this.mbTheme.TabIndex = 0;
            this.mbTheme.UseSelectable = true;
            this.mbTheme.SelectedIndexChanged += new System.EventHandler(this.mbTheme_SelectedIndexChanged);
            // 
            // metrolblTheme
            // 
            this.metrolblTheme.AutoSize = true;
            this.metrolblTheme.Location = new System.Drawing.Point(7, 13);
            this.metrolblTheme.Name = "metrolblTheme";
            this.metrolblTheme.Size = new System.Drawing.Size(49, 19);
            this.metrolblTheme.TabIndex = 1;
            this.metrolblTheme.Text = "Theme";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(197, 13);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Color";
            // 
            // mbColor
            // 
            this.mbColor.FormattingEnabled = true;
            this.mbColor.ItemHeight = 23;
            this.mbColor.Items.AddRange(new object[] {
            "Default",
            "Black",
            "White",
            "Silver",
            "Blue",
            "Green",
            "Lime",
            "Teal",
            "Orange",
            "Brown",
            "Pink",
            "Margarita"});
            this.mbColor.Location = new System.Drawing.Point(245, 3);
            this.mbColor.Name = "mbColor";
            this.mbColor.Size = new System.Drawing.Size(134, 29);
            this.mbColor.TabIndex = 2;
            this.mbColor.UseSelectable = true;
            this.mbColor.SelectedIndexChanged += new System.EventHandler(this.mbColor_SelectedIndexChanged);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.mbColor);
            this.metroPanel1.Controls.Add(this.metrolblTheme);
            this.metroPanel1.Controls.Add(this.mbTheme);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(448, 51);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(386, 46);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.metroTile3);
            this.metroPanel4.Controls.Add(this.metroButtonCreateRelations);
            this.metroPanel4.Controls.Add(this.metroLabelTabla2);
            this.metroPanel4.Controls.Add(this.metroComboBoxIndex2);
            this.metroPanel4.Controls.Add(this.metroComboBoxTabla2);
            this.metroPanel4.Controls.Add(this.metroComboBoxIndex1);
            this.metroPanel4.Controls.Add(this.metroLabelTabla1);
            this.metroPanel4.Controls.Add(this.metroComboBoxTabla1);
            this.metroPanel4.Controls.Add(this.metroLabelChooseTables);
            this.metroPanel4.Controls.Add(this.metroLabelCreateRelation);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(429, 134);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(405, 477);
            this.metroPanel4.TabIndex = 22;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Enabled = false;
            this.metroTile3.Location = new System.Drawing.Point(0, 21);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(405, 40);
            this.metroTile3.TabIndex = 29;
            this.metroTile3.Text = "Create Relations";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseSelectable = true;
            // 
            // metroButtonCreateRelations
            // 
            this.metroButtonCreateRelations.Location = new System.Drawing.Point(144, 311);
            this.metroButtonCreateRelations.Name = "metroButtonCreateRelations";
            this.metroButtonCreateRelations.Size = new System.Drawing.Size(106, 35);
            this.metroButtonCreateRelations.TabIndex = 22;
            this.metroButtonCreateRelations.Text = "&Create Relations";
            this.metroButtonCreateRelations.UseSelectable = true;
            this.metroButtonCreateRelations.Click += new System.EventHandler(this.metroButtonCreateRelations_Click);
            // 
            // metroLabelTabla2
            // 
            this.metroLabelTabla2.AutoSize = true;
            this.metroLabelTabla2.Location = new System.Drawing.Point(111, 209);
            this.metroLabelTabla2.Name = "metroLabelTabla2";
            this.metroLabelTabla2.Size = new System.Drawing.Size(49, 19);
            this.metroLabelTabla2.TabIndex = 27;
            this.metroLabelTabla2.Text = "Table2:";
            // 
            // metroComboBoxIndex2
            // 
            this.metroComboBoxIndex2.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBoxIndex2.FormattingEnabled = true;
            this.metroComboBoxIndex2.ItemHeight = 19;
            this.metroComboBoxIndex2.Location = new System.Drawing.Point(111, 262);
            this.metroComboBoxIndex2.Name = "metroComboBoxIndex2";
            this.metroComboBoxIndex2.Size = new System.Drawing.Size(170, 25);
            this.metroComboBoxIndex2.TabIndex = 26;
            this.metroComboBoxIndex2.UseSelectable = true;
            // 
            // metroComboBoxTabla2
            // 
            this.metroComboBoxTabla2.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBoxTabla2.FormattingEnabled = true;
            this.metroComboBoxTabla2.ItemHeight = 19;
            this.metroComboBoxTabla2.Location = new System.Drawing.Point(111, 231);
            this.metroComboBoxTabla2.Name = "metroComboBoxTabla2";
            this.metroComboBoxTabla2.Size = new System.Drawing.Size(170, 25);
            this.metroComboBoxTabla2.TabIndex = 25;
            this.metroComboBoxTabla2.UseSelectable = true;
            this.metroComboBoxTabla2.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxTabla2_SelectedIndexChanged);
            // 
            // metroComboBoxIndex1
            // 
            this.metroComboBoxIndex1.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBoxIndex1.FormattingEnabled = true;
            this.metroComboBoxIndex1.ItemHeight = 19;
            this.metroComboBoxIndex1.Location = new System.Drawing.Point(108, 171);
            this.metroComboBoxIndex1.Name = "metroComboBoxIndex1";
            this.metroComboBoxIndex1.Size = new System.Drawing.Size(170, 25);
            this.metroComboBoxIndex1.TabIndex = 24;
            this.metroComboBoxIndex1.UseSelectable = true;
            // 
            // metroLabelTabla1
            // 
            this.metroLabelTabla1.AutoSize = true;
            this.metroLabelTabla1.Location = new System.Drawing.Point(108, 109);
            this.metroLabelTabla1.Name = "metroLabelTabla1";
            this.metroLabelTabla1.Size = new System.Drawing.Size(47, 19);
            this.metroLabelTabla1.TabIndex = 23;
            this.metroLabelTabla1.Text = "Table1:";
            // 
            // metroComboBoxTabla1
            // 
            this.metroComboBoxTabla1.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBoxTabla1.FormattingEnabled = true;
            this.metroComboBoxTabla1.ItemHeight = 19;
            this.metroComboBoxTabla1.Location = new System.Drawing.Point(108, 133);
            this.metroComboBoxTabla1.Name = "metroComboBoxTabla1";
            this.metroComboBoxTabla1.Size = new System.Drawing.Size(170, 25);
            this.metroComboBoxTabla1.TabIndex = 22;
            this.metroComboBoxTabla1.UseSelectable = true;
            this.metroComboBoxTabla1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabelChooseTables
            // 
            this.metroLabelChooseTables.AutoSize = true;
            this.metroLabelChooseTables.Location = new System.Drawing.Point(26, 79);
            this.metroLabelChooseTables.Name = "metroLabelChooseTables";
            this.metroLabelChooseTables.Size = new System.Drawing.Size(173, 19);
            this.metroLabelChooseTables.TabIndex = 20;
            this.metroLabelChooseTables.Text = "You need to select to tables:";
            // 
            // metroLabelCreateRelation
            // 
            this.metroLabelCreateRelation.AutoSize = true;
            this.metroLabelCreateRelation.Location = new System.Drawing.Point(148, 26);
            this.metroLabelCreateRelation.Name = "metroLabelCreateRelation";
            this.metroLabelCreateRelation.Size = new System.Drawing.Size(104, 19);
            this.metroLabelCreateRelation.TabIndex = 19;
            this.metroLabelCreateRelation.Text = "Create Relations";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroTile2);
            this.metroPanel3.Controls.Add(this.metroTextBoxTableName);
            this.metroPanel3.Controls.Add(this.metroButtonCreateTable);
            this.metroPanel3.Controls.Add(this.metroTile1);
            this.metroPanel3.Controls.Add(this.metroTileFieldName);
            this.metroPanel3.Controls.Add(this.metroTileDataType);
            this.metroPanel3.Controls.Add(this.metroButtonRelation);
            this.metroPanel3.Controls.Add(this.metroButtonSaveTable);
            this.metroPanel3.Controls.Add(this.metroButtonCreateField);
            this.metroPanel3.Controls.Add(this.metroLabelCreateField);
            this.metroPanel3.Controls.Add(this.metroComboBoxDataType);
            this.metroPanel3.Controls.Add(this.metroTextBoxFieldName);
            this.metroPanel3.Controls.Add(this.metroGrid1);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(2, 134);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(421, 477);
            this.metroPanel3.TabIndex = 25;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Enabled = false;
            this.metroTile2.Location = new System.Drawing.Point(14, 23);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(262, 40);
            this.metroTile2.TabIndex = 28;
            this.metroTile2.Text = "Create Tables";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            // 
            // metroTextBoxTableName
            // 
            // 
            // 
            // 
            this.metroTextBoxTableName.CustomButton.Image = null;
            this.metroTextBoxTableName.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.metroTextBoxTableName.CustomButton.Name = "";
            this.metroTextBoxTableName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxTableName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxTableName.CustomButton.TabIndex = 1;
            this.metroTextBoxTableName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxTableName.CustomButton.UseSelectable = true;
            this.metroTextBoxTableName.CustomButton.Visible = false;
            this.metroTextBoxTableName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxTableName.Lines = new string[0];
            this.metroTextBoxTableName.Location = new System.Drawing.Point(11, 69);
            this.metroTextBoxTableName.MaxLength = 32767;
            this.metroTextBoxTableName.Name = "metroTextBoxTableName";
            this.metroTextBoxTableName.PasswordChar = '\0';
            this.metroTextBoxTableName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTableName.SelectedText = "";
            this.metroTextBoxTableName.SelectionLength = 0;
            this.metroTextBoxTableName.SelectionStart = 0;
            this.metroTextBoxTableName.ShortcutsEnabled = true;
            this.metroTextBoxTableName.Size = new System.Drawing.Size(265, 23);
            this.metroTextBoxTableName.TabIndex = 16;
            this.metroTextBoxTableName.UseSelectable = true;
            this.metroTextBoxTableName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxTableName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonCreateTable
            // 
            this.metroButtonCreateTable.Location = new System.Drawing.Point(300, 32);
            this.metroButtonCreateTable.Name = "metroButtonCreateTable";
            this.metroButtonCreateTable.Size = new System.Drawing.Size(106, 35);
            this.metroButtonCreateTable.TabIndex = 18;
            this.metroButtonCreateTable.Text = "&Create Table";
            this.metroButtonCreateTable.UseSelectable = true;
            this.metroButtonCreateTable.Click += new System.EventHandler(this.metroButtonCreateTable_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Enabled = false;
            this.metroTile1.Location = new System.Drawing.Point(14, 103);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(262, 40);
            this.metroTile1.TabIndex = 27;
            this.metroTile1.Text = "Create Fields";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            // 
            // metroTileFieldName
            // 
            this.metroTileFieldName.ActiveControl = null;
            this.metroTileFieldName.Enabled = false;
            this.metroTileFieldName.Location = new System.Drawing.Point(11, 175);
            this.metroTileFieldName.Name = "metroTileFieldName";
            this.metroTileFieldName.Size = new System.Drawing.Size(203, 40);
            this.metroTileFieldName.TabIndex = 22;
            this.metroTileFieldName.Text = "Field Name";
            this.metroTileFieldName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileFieldName.UseSelectable = true;
            // 
            // metroTileDataType
            // 
            this.metroTileDataType.ActiveControl = null;
            this.metroTileDataType.Enabled = false;
            this.metroTileDataType.Location = new System.Drawing.Point(211, 175);
            this.metroTileDataType.Name = "metroTileDataType";
            this.metroTileDataType.Size = new System.Drawing.Size(204, 40);
            this.metroTileDataType.TabIndex = 27;
            this.metroTileDataType.Text = "DataType";
            this.metroTileDataType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileDataType.UseSelectable = true;
            // 
            // metroButtonRelation
            // 
            this.metroButtonRelation.Enabled = false;
            this.metroButtonRelation.Location = new System.Drawing.Point(309, 419);
            this.metroButtonRelation.Name = "metroButtonRelation";
            this.metroButtonRelation.Size = new System.Drawing.Size(106, 35);
            this.metroButtonRelation.TabIndex = 21;
            this.metroButtonRelation.Text = "&Relations";
            this.metroButtonRelation.UseSelectable = true;
            this.metroButtonRelation.Click += new System.EventHandler(this.metroButtonRelation_Click);
            // 
            // metroButtonSaveTable
            // 
            this.metroButtonSaveTable.Enabled = false;
            this.metroButtonSaveTable.Location = new System.Drawing.Point(11, 419);
            this.metroButtonSaveTable.Name = "metroButtonSaveTable";
            this.metroButtonSaveTable.Size = new System.Drawing.Size(106, 35);
            this.metroButtonSaveTable.TabIndex = 20;
            this.metroButtonSaveTable.Text = "&Save Table";
            this.metroButtonSaveTable.UseSelectable = true;
            this.metroButtonSaveTable.Click += new System.EventHandler(this.metroButtonSaveTable_Click);
            // 
            // metroButtonCreateField
            // 
            this.metroButtonCreateField.Location = new System.Drawing.Point(300, 103);
            this.metroButtonCreateField.Name = "metroButtonCreateField";
            this.metroButtonCreateField.Size = new System.Drawing.Size(106, 35);
            this.metroButtonCreateField.TabIndex = 19;
            this.metroButtonCreateField.Text = "&Create Field";
            this.metroButtonCreateField.UseSelectable = true;
            this.metroButtonCreateField.Click += new System.EventHandler(this.metroButtonCreateField_Click);
            // 
            // metroLabelCreateField
            // 
            this.metroLabelCreateField.AutoSize = true;
            this.metroLabelCreateField.Location = new System.Drawing.Point(11, 124);
            this.metroLabelCreateField.Name = "metroLabelCreateField";
            this.metroLabelCreateField.Size = new System.Drawing.Size(144, 19);
            this.metroLabelCreateField.TabIndex = 17;
            this.metroLabelCreateField.Text = "Create Fields for Table ";
            // 
            // metroComboBoxDataType
            // 
            this.metroComboBoxDataType.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBoxDataType.FormattingEnabled = true;
            this.metroComboBoxDataType.ItemHeight = 19;
            this.metroComboBoxDataType.Location = new System.Drawing.Point(282, 144);
            this.metroComboBoxDataType.Name = "metroComboBoxDataType";
            this.metroComboBoxDataType.Size = new System.Drawing.Size(133, 25);
            this.metroComboBoxDataType.TabIndex = 13;
            this.metroComboBoxDataType.UseSelectable = true;
            // 
            // metroTextBoxFieldName
            // 
            // 
            // 
            // 
            this.metroTextBoxFieldName.CustomButton.Image = null;
            this.metroTextBoxFieldName.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.metroTextBoxFieldName.CustomButton.Name = "";
            this.metroTextBoxFieldName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxFieldName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFieldName.CustomButton.TabIndex = 1;
            this.metroTextBoxFieldName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFieldName.CustomButton.UseSelectable = true;
            this.metroTextBoxFieldName.CustomButton.Visible = false;
            this.metroTextBoxFieldName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxFieldName.Lines = new string[0];
            this.metroTextBoxFieldName.Location = new System.Drawing.Point(11, 146);
            this.metroTextBoxFieldName.MaxLength = 32767;
            this.metroTextBoxFieldName.Name = "metroTextBoxFieldName";
            this.metroTextBoxFieldName.PasswordChar = '\0';
            this.metroTextBoxFieldName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFieldName.SelectedText = "";
            this.metroTextBoxFieldName.SelectionLength = 0;
            this.metroTextBoxFieldName.SelectionStart = 0;
            this.metroTextBoxFieldName.ShortcutsEnabled = true;
            this.metroTextBoxFieldName.Size = new System.Drawing.Size(265, 23);
            this.metroTextBoxFieldName.TabIndex = 12;
            this.metroTextBoxFieldName.UseSelectable = true;
            this.metroTextBoxFieldName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFieldName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FieldName,
            this.DataType});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle19;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(11, 200);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.metroGrid1.RowHeadersVisible = false;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(404, 199);
            this.metroGrid1.TabIndex = 14;
            // 
            // FieldName
            // 
            this.FieldName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldName.DefaultCellStyle = dataGridViewCellStyle17;
            this.FieldName.HeaderText = "FieldName";
            this.FieldName.Name = "FieldName";
            this.FieldName.ReadOnly = true;
            // 
            // DataType
            // 
            this.DataType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataType.DefaultCellStyle = dataGridViewCellStyle18;
            this.DataType.HeaderText = "Data Type";
            this.DataType.Name = "DataType";
            this.DataType.ReadOnly = true;
            // 
            // metroTileHome
            // 
            this.metroTileHome.ActiveControl = null;
            this.metroTileHome.Location = new System.Drawing.Point(16, 63);
            this.metroTileHome.Name = "metroTileHome";
            this.metroTileHome.Size = new System.Drawing.Size(129, 58);
            this.metroTileHome.TabIndex = 26;
            this.metroTileHome.Text = "Home";
            this.metroTileHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileHome.UseSelectable = true;
            this.metroTileHome.Click += new System.EventHandler(this.metroTileHome_Click);
            // 
            // metroTileDisplay
            // 
            this.metroTileDisplay.ActiveControl = null;
            this.metroTileDisplay.Location = new System.Drawing.Point(286, 64);
            this.metroTileDisplay.Name = "metroTileDisplay";
            this.metroTileDisplay.Size = new System.Drawing.Size(129, 58);
            this.metroTileDisplay.TabIndex = 27;
            this.metroTileDisplay.Text = "&Display";
            this.metroTileDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileDisplay.UseSelectable = true;
            this.metroTileDisplay.Click += new System.EventHandler(this.metroTileDisplay_Click);
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.metroButtonDisplay);
            this.metroPanel5.Controls.Add(this.listBoxDisplay);
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(2, 127);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(832, 480);
            this.metroPanel5.TabIndex = 28;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // metroButtonDisplay
            // 
            this.metroButtonDisplay.Location = new System.Drawing.Point(315, 39);
            this.metroButtonDisplay.Name = "metroButtonDisplay";
            this.metroButtonDisplay.Size = new System.Drawing.Size(224, 56);
            this.metroButtonDisplay.TabIndex = 3;
            this.metroButtonDisplay.Text = "&Display Information";
            this.metroButtonDisplay.UseSelectable = true;
            this.metroButtonDisplay.Click += new System.EventHandler(this.metroButtonDisplay_Click);
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.ItemHeight = 21;
            this.listBoxDisplay.Location = new System.Drawing.Point(130, 109);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(575, 298);
            this.listBoxDisplay.TabIndex = 2;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.metroButtonSaveData);
            this.metroPanel2.Controls.Add(this.metroButtonCreateFake);
            this.metroPanel2.Controls.Add(this.mlblfilename);
            this.metroPanel2.Controls.Add(this.metroTextBoxName);
            this.metroPanel2.Controls.Add(this.lblBlankData);
            this.metroPanel2.Controls.Add(this.pictureBox2);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(147, 179);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(544, 253);
            this.metroPanel2.TabIndex = 29;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroButtonSaveData
            // 
            this.metroButtonSaveData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButtonSaveData.BackgroundImage")));
            this.metroButtonSaveData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButtonSaveData.Location = new System.Drawing.Point(480, 86);
            this.metroButtonSaveData.Name = "metroButtonSaveData";
            this.metroButtonSaveData.Size = new System.Drawing.Size(26, 23);
            this.metroButtonSaveData.TabIndex = 14;
            this.metroButtonSaveData.UseSelectable = true;
            this.metroButtonSaveData.Click += new System.EventHandler(this.metroButtonSaveData_Click_1);
            // 
            // metroButtonCreateFake
            // 
            this.metroButtonCreateFake.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButtonCreateFake.BackgroundImage")));
            this.metroButtonCreateFake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButtonCreateFake.Location = new System.Drawing.Point(274, 124);
            this.metroButtonCreateFake.Name = "metroButtonCreateFake";
            this.metroButtonCreateFake.Size = new System.Drawing.Size(79, 79);
            this.metroButtonCreateFake.TabIndex = 13;
            this.metroButtonCreateFake.UseSelectable = true;
            this.metroButtonCreateFake.Click += new System.EventHandler(this.metroButtonCreateFake_Click);
            // 
            // mlblfilename
            // 
            this.mlblfilename.AutoSize = true;
            this.mlblfilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblfilename.Location = new System.Drawing.Point(274, 64);
            this.mlblfilename.Name = "mlblfilename";
            this.mlblfilename.Size = new System.Drawing.Size(69, 19);
            this.mlblfilename.TabIndex = 12;
            this.mlblfilename.Text = "File Name";
            // 
            // metroTextBoxName
            // 
            // 
            // 
            // 
            this.metroTextBoxName.CustomButton.Image = null;
            this.metroTextBoxName.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.metroTextBoxName.CustomButton.Name = "";
            this.metroTextBoxName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxName.CustomButton.TabIndex = 1;
            this.metroTextBoxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxName.CustomButton.UseSelectable = true;
            this.metroTextBoxName.CustomButton.Visible = false;
            this.metroTextBoxName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxName.Lines = new string[0];
            this.metroTextBoxName.Location = new System.Drawing.Point(274, 86);
            this.metroTextBoxName.MaxLength = 32767;
            this.metroTextBoxName.Name = "metroTextBoxName";
            this.metroTextBoxName.PasswordChar = '\0';
            this.metroTextBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxName.SelectedText = "";
            this.metroTextBoxName.SelectionLength = 0;
            this.metroTextBoxName.SelectionStart = 0;
            this.metroTextBoxName.ShortcutsEnabled = true;
            this.metroTextBoxName.Size = new System.Drawing.Size(200, 23);
            this.metroTextBoxName.TabIndex = 1;
            this.metroTextBoxName.UseSelectable = true;
            this.metroTextBoxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblBlankData
            // 
            this.lblBlankData.AutoSize = true;
            this.lblBlankData.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlankData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBlankData.Location = new System.Drawing.Point(269, 31);
            this.lblBlankData.Name = "lblBlankData";
            this.lblBlankData.Size = new System.Drawing.Size(139, 25);
            this.lblBlankData.TabIndex = 7;
            this.lblBlankData.Text = "Blank database";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(38, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 199);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // metroTileExit
            // 
            this.metroTileExit.ActiveControl = null;
            this.metroTileExit.Location = new System.Drawing.Point(151, 63);
            this.metroTileExit.Name = "metroTileExit";
            this.metroTileExit.Size = new System.Drawing.Size(129, 58);
            this.metroTileExit.TabIndex = 30;
            this.metroTileExit.Text = "&Exit";
            this.metroTileExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileExit.UseSelectable = true;
            this.metroTileExit.Click += new System.EventHandler(this.metroTileExit_Click);
            // 
            // MiniAccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 611);
            this.ControlBox = false;
            this.Controls.Add(this.metroTileExit);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroTileDisplay);
            this.Controls.Add(this.metroTileHome);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.metroPanel5);
            this.Name = "MiniAccessForm";
            this.Text = "Mini Access Project";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox mbTheme;
        private MetroFramework.Controls.MetroLabel metrolblTheme;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox mbColor;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroLabel metroLabelTabla1;
        private MetroFramework.Controls.MetroComboBox metroComboBoxTabla1;
        private MetroFramework.Controls.MetroLabel metroLabelChooseTables;
        private MetroFramework.Controls.MetroLabel metroLabelCreateRelation;
        private MetroFramework.Controls.MetroLabel metroLabelTabla2;
        private MetroFramework.Controls.MetroComboBox metroComboBoxIndex2;
        private MetroFramework.Controls.MetroComboBox metroComboBoxTabla2;
        private MetroFramework.Controls.MetroComboBox metroComboBoxIndex1;
        private MetroFramework.Controls.MetroButton metroButtonCreateRelations;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton metroButtonRelation;
        private MetroFramework.Controls.MetroButton metroButtonSaveTable;
        private MetroFramework.Controls.MetroButton metroButtonCreateField;
        private MetroFramework.Controls.MetroButton metroButtonCreateTable;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTableName;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroLabel metroLabelCreateField;
        private MetroFramework.Controls.MetroComboBox metroComboBoxDataType;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFieldName;
        private MetroFramework.Controls.MetroTile metroTileHome;
        private MetroFramework.Controls.MetroTile metroTileDisplay;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTileFieldName;
        private MetroFramework.Controls.MetroTile metroTileDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataType;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton metroButtonSaveData;
        private MetroFramework.Controls.MetroButton metroButtonCreateFake;
        private MetroFramework.Controls.MetroLabel mlblfilename;
        private MetroFramework.Controls.MetroTextBox metroTextBoxName;
        private System.Windows.Forms.Label lblBlankData;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroButton metroButtonDisplay;
        private System.Windows.Forms.ListBox listBoxDisplay;
        private MetroFramework.Controls.MetroTile metroTileExit;
    }
}