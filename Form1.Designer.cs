namespace MiniApps
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertDate = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Counter = new System.Windows.Forms.TabPage();
            this.labelCounter = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.Randomizer = new System.Windows.Forms.TabPage();
            this.checkBoxDuplicates = new System.Windows.Forms.CheckBox();
            this.buttonToClipboard = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.RndList = new System.Windows.Forms.TextBox();
            this.labelRndResult = new System.Windows.Forms.Label();
            this.numericUpDownTo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownFrom = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGen = new System.Windows.Forms.Button();
            this.tabNotepad = new System.Windows.Forms.TabPage();
            this.Notepad = new System.Windows.Forms.RichTextBox();
            this.Password = new System.Windows.Forms.TabPage();
            this.GeneratedPassword = new System.Windows.Forms.TextBox();
            this.GeneratePassword = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordLength = new System.Windows.Forms.NumericUpDown();
            this.PasswordSettings = new System.Windows.Forms.CheckedListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Converter = new System.Windows.Forms.TabPage();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.comboBoxIn = new System.Windows.Forms.ComboBox();
            this.comboBoxOut = new System.Windows.Forms.ComboBox();
            this.ValueOut = new System.Windows.Forms.TextBox();
            this.ButtonSwap = new System.Windows.Forms.Button();
            this.comboBoxTypes = new System.Windows.Forms.ComboBox();
            this.numericUpDownValueIn = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Counter.SuspendLayout();
            this.Randomizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).BeginInit();
            this.tabNotepad.SuspendLayout();
            this.Password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLength)).BeginInit();
            this.Converter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValueIn)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.notepadToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(446, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsertDate,
            this.InsertTime,
            this.toolStripMenuItem1,
            this.saveNoteToolStripMenuItem,
            this.loadNoteToolStripMenuItem});
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.notepadToolStripMenuItem.Text = "Notepad";
            // 
            // InsertDate
            // 
            this.InsertDate.Name = "InsertDate";
            this.InsertDate.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.InsertDate.Size = new System.Drawing.Size(203, 22);
            this.InsertDate.Text = "Insert date";
            this.InsertDate.Click += new System.EventHandler(this.InsertDate_Click);
            // 
            // InsertTime
            // 
            this.InsertTime.Name = "InsertTime";
            this.InsertTime.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.InsertTime.Size = new System.Drawing.Size(203, 22);
            this.InsertTime.Text = "Insert time";
            this.InsertTime.Click += new System.EventHandler(this.InsertTime_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(200, 6);
            // 
            // saveNoteToolStripMenuItem
            // 
            this.saveNoteToolStripMenuItem.Name = "saveNoteToolStripMenuItem";
            this.saveNoteToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.saveNoteToolStripMenuItem.Text = "Save Note";
            this.saveNoteToolStripMenuItem.Click += new System.EventHandler(this.saveNoteToolStripMenuItem_Click);
            // 
            // loadNoteToolStripMenuItem
            // 
            this.loadNoteToolStripMenuItem.Name = "loadNoteToolStripMenuItem";
            this.loadNoteToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.loadNoteToolStripMenuItem.Text = "Load Note";
            this.loadNoteToolStripMenuItem.Click += new System.EventHandler(this.loadNoteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Counter);
            this.tabControl1.Controls.Add(this.Randomizer);
            this.tabControl1.Controls.Add(this.tabNotepad);
            this.tabControl1.Controls.Add(this.Password);
            this.tabControl1.Controls.Add(this.Converter);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(446, 370);
            this.tabControl1.TabIndex = 1;
            // 
            // Counter
            // 
            this.Counter.Controls.Add(this.labelCounter);
            this.Counter.Controls.Add(this.buttonReset);
            this.Counter.Controls.Add(this.buttonMinus);
            this.Counter.Controls.Add(this.buttonPlus);
            this.Counter.Location = new System.Drawing.Point(4, 22);
            this.Counter.Name = "Counter";
            this.Counter.Padding = new System.Windows.Forms.Padding(3);
            this.Counter.Size = new System.Drawing.Size(438, 344);
            this.Counter.TabIndex = 0;
            this.Counter.Text = "Counter";
            this.Counter.UseVisualStyleBackColor = true;
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Location = new System.Drawing.Point(32, 77);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(13, 13);
            this.labelCounter.TabIndex = 3;
            this.labelCounter.Text = "0";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(91, 53);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(127, 60);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(8, 108);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(59, 54);
            this.buttonMinus.TabIndex = 1;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(8, 6);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(59, 54);
            this.buttonPlus.TabIndex = 0;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // Randomizer
            // 
            this.Randomizer.Controls.Add(this.checkBoxDuplicates);
            this.Randomizer.Controls.Add(this.buttonToClipboard);
            this.Randomizer.Controls.Add(this.buttonClear);
            this.Randomizer.Controls.Add(this.RndList);
            this.Randomizer.Controls.Add(this.labelRndResult);
            this.Randomizer.Controls.Add(this.numericUpDownTo);
            this.Randomizer.Controls.Add(this.label2);
            this.Randomizer.Controls.Add(this.numericUpDownFrom);
            this.Randomizer.Controls.Add(this.label1);
            this.Randomizer.Controls.Add(this.buttonGen);
            this.Randomizer.Location = new System.Drawing.Point(4, 22);
            this.Randomizer.Name = "Randomizer";
            this.Randomizer.Padding = new System.Windows.Forms.Padding(3);
            this.Randomizer.Size = new System.Drawing.Size(438, 344);
            this.Randomizer.TabIndex = 1;
            this.Randomizer.Text = "Randomizer";
            this.Randomizer.UseVisualStyleBackColor = true;
            // 
            // checkBoxDuplicates
            // 
            this.checkBoxDuplicates.AutoSize = true;
            this.checkBoxDuplicates.Location = new System.Drawing.Point(321, 26);
            this.checkBoxDuplicates.Name = "checkBoxDuplicates";
            this.checkBoxDuplicates.Size = new System.Drawing.Size(96, 17);
            this.checkBoxDuplicates.TabIndex = 9;
            this.checkBoxDuplicates.Text = "Add duplicates";
            this.checkBoxDuplicates.UseVisualStyleBackColor = true;
            // 
            // buttonToClipboard
            // 
            this.buttonToClipboard.Location = new System.Drawing.Point(119, 143);
            this.buttonToClipboard.Name = "buttonToClipboard";
            this.buttonToClipboard.Size = new System.Drawing.Size(75, 23);
            this.buttonToClipboard.TabIndex = 8;
            this.buttonToClipboard.Text = "To Clipboard";
            this.buttonToClipboard.UseVisualStyleBackColor = true;
            this.buttonToClipboard.Click += new System.EventHandler(this.buttonToClipboard_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(119, 102);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // RndList
            // 
            this.RndList.Location = new System.Drawing.Point(224, 102);
            this.RndList.Multiline = true;
            this.RndList.Name = "RndList";
            this.RndList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RndList.Size = new System.Drawing.Size(137, 206);
            this.RndList.TabIndex = 6;
            // 
            // labelRndResult
            // 
            this.labelRndResult.AutoSize = true;
            this.labelRndResult.Location = new System.Drawing.Point(235, 63);
            this.labelRndResult.Name = "labelRndResult";
            this.labelRndResult.Size = new System.Drawing.Size(0, 13);
            this.labelRndResult.TabIndex = 5;
            // 
            // numericUpDownTo
            // 
            this.numericUpDownTo.Location = new System.Drawing.Point(74, 61);
            this.numericUpDownTo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTo.Name = "numericUpDownTo";
            this.numericUpDownTo.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTo.TabIndex = 4;
            this.numericUpDownTo.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownTo.ValueChanged += new System.EventHandler(this.numericUpDownTo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "From";
            // 
            // numericUpDownFrom
            // 
            this.numericUpDownFrom.Location = new System.Drawing.Point(74, 22);
            this.numericUpDownFrom.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownFrom.Name = "numericUpDownFrom";
            this.numericUpDownFrom.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownFrom.TabIndex = 2;
            this.numericUpDownFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFrom.ValueChanged += new System.EventHandler(this.numericUpDownFrom_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "To";
            // 
            // buttonGen
            // 
            this.buttonGen.Location = new System.Drawing.Point(224, 22);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(75, 23);
            this.buttonGen.TabIndex = 0;
            this.buttonGen.Text = "Generate";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // tabNotepad
            // 
            this.tabNotepad.Controls.Add(this.Notepad);
            this.tabNotepad.Location = new System.Drawing.Point(4, 22);
            this.tabNotepad.Name = "tabNotepad";
            this.tabNotepad.Size = new System.Drawing.Size(438, 344);
            this.tabNotepad.TabIndex = 2;
            this.tabNotepad.Text = "Notepad";
            this.tabNotepad.UseVisualStyleBackColor = true;
            // 
            // Notepad
            // 
            this.Notepad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Notepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Notepad.Location = new System.Drawing.Point(0, 0);
            this.Notepad.Name = "Notepad";
            this.Notepad.Size = new System.Drawing.Size(438, 344);
            this.Notepad.TabIndex = 0;
            this.Notepad.Text = "";
            // 
            // Password
            // 
            this.Password.Controls.Add(this.GeneratedPassword);
            this.Password.Controls.Add(this.GeneratePassword);
            this.Password.Controls.Add(this.PasswordLabel);
            this.Password.Controls.Add(this.PasswordLength);
            this.Password.Controls.Add(this.PasswordSettings);
            this.Password.Location = new System.Drawing.Point(4, 22);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(438, 344);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            this.Password.UseVisualStyleBackColor = true;
            // 
            // GeneratedPassword
            // 
            this.GeneratedPassword.Location = new System.Drawing.Point(129, 214);
            this.GeneratedPassword.Name = "GeneratedPassword";
            this.GeneratedPassword.ReadOnly = true;
            this.GeneratedPassword.Size = new System.Drawing.Size(120, 20);
            this.GeneratedPassword.TabIndex = 4;
            // 
            // GeneratePassword
            // 
            this.GeneratePassword.Location = new System.Drawing.Point(37, 211);
            this.GeneratePassword.Name = "GeneratePassword";
            this.GeneratePassword.Size = new System.Drawing.Size(75, 23);
            this.GeneratePassword.TabIndex = 3;
            this.GeneratePassword.Text = "Generate";
            this.GeneratePassword.UseVisualStyleBackColor = true;
            this.GeneratePassword.Click += new System.EventHandler(this.GeneratePassword_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(34, 181);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(89, 13);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password Length";
            // 
            // PasswordLength
            // 
            this.PasswordLength.Location = new System.Drawing.Point(129, 179);
            this.PasswordLength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PasswordLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PasswordLength.Name = "PasswordLength";
            this.PasswordLength.Size = new System.Drawing.Size(120, 20);
            this.PasswordLength.TabIndex = 1;
            this.PasswordLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PasswordSettings
            // 
            this.PasswordSettings.CheckOnClick = true;
            this.PasswordSettings.FormattingEnabled = true;
            this.PasswordSettings.Items.AddRange(new object[] {
            "Upper case",
            "Lower case",
            "Numbers",
            "Special Symbols($, #, ~, `, %, *, (, ), &)"});
            this.PasswordSettings.Location = new System.Drawing.Point(26, 15);
            this.PasswordSettings.Name = "PasswordSettings";
            this.PasswordSettings.Size = new System.Drawing.Size(386, 154);
            this.PasswordSettings.TabIndex = 0;
            this.PasswordSettings.SelectedIndexChanged += new System.EventHandler(this.PasswordSettings_SelectedIndexChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "rtf";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.DefaultExt = "rtf";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Converter
            // 
            this.Converter.Controls.Add(this.numericUpDownValueIn);
            this.Converter.Controls.Add(this.comboBoxTypes);
            this.Converter.Controls.Add(this.ButtonSwap);
            this.Converter.Controls.Add(this.ValueOut);
            this.Converter.Controls.Add(this.comboBoxOut);
            this.Converter.Controls.Add(this.comboBoxIn);
            this.Converter.Controls.Add(this.buttonConvert);
            this.Converter.Location = new System.Drawing.Point(4, 22);
            this.Converter.Name = "Converter";
            this.Converter.Padding = new System.Windows.Forms.Padding(3);
            this.Converter.Size = new System.Drawing.Size(438, 344);
            this.Converter.TabIndex = 4;
            this.Converter.Text = "Converter";
            this.Converter.UseVisualStyleBackColor = true;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(182, 84);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 0;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // comboBoxIn
            // 
            this.comboBoxIn.AutoCompleteCustomSource.AddRange(new string[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.comboBoxIn.FormattingEnabled = true;
            this.comboBoxIn.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.comboBoxIn.Location = new System.Drawing.Point(41, 51);
            this.comboBoxIn.Name = "comboBoxIn";
            this.comboBoxIn.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIn.TabIndex = 1;
            this.comboBoxIn.Text = "mm";
            // 
            // comboBoxOut
            // 
            this.comboBoxOut.AutoCompleteCustomSource.AddRange(new string[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.comboBoxOut.FormattingEnabled = true;
            this.comboBoxOut.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.comboBoxOut.Location = new System.Drawing.Point(275, 51);
            this.comboBoxOut.Name = "comboBoxOut";
            this.comboBoxOut.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOut.TabIndex = 2;
            this.comboBoxOut.Text = "m";
            // 
            // ValueOut
            // 
            this.ValueOut.Location = new System.Drawing.Point(275, 87);
            this.ValueOut.Name = "ValueOut";
            this.ValueOut.ReadOnly = true;
            this.ValueOut.Size = new System.Drawing.Size(121, 20);
            this.ValueOut.TabIndex = 4;
            // 
            // ButtonSwap
            // 
            this.ButtonSwap.Location = new System.Drawing.Point(182, 51);
            this.ButtonSwap.Name = "ButtonSwap";
            this.ButtonSwap.Size = new System.Drawing.Size(75, 23);
            this.ButtonSwap.TabIndex = 5;
            this.ButtonSwap.Text = "Swap";
            this.ButtonSwap.UseVisualStyleBackColor = true;
            this.ButtonSwap.Click += new System.EventHandler(this.ButtonSwap_Click);
            // 
            // comboBoxTypes
            // 
            this.comboBoxTypes.FormattingEnabled = true;
            this.comboBoxTypes.Items.AddRange(new object[] {
            "Length",
            "Weight"});
            this.comboBoxTypes.Location = new System.Drawing.Point(159, 136);
            this.comboBoxTypes.Name = "comboBoxTypes";
            this.comboBoxTypes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypes.TabIndex = 6;
            this.comboBoxTypes.Text = "Length";
            this.comboBoxTypes.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypes_SelectedIndexChanged);
            // 
            // numericUpDownValueIn
            // 
            this.numericUpDownValueIn.DecimalPlaces = 2;
            this.numericUpDownValueIn.Location = new System.Drawing.Point(41, 88);
            this.numericUpDownValueIn.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownValueIn.Name = "numericUpDownValueIn";
            this.numericUpDownValueIn.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownValueIn.TabIndex = 7;
            this.numericUpDownValueIn.ThousandsSeparator = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 394);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Mini Apps";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Counter.ResumeLayout(false);
            this.Counter.PerformLayout();
            this.Randomizer.ResumeLayout(false);
            this.Randomizer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).EndInit();
            this.tabNotepad.ResumeLayout(false);
            this.Password.ResumeLayout(false);
            this.Password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLength)).EndInit();
            this.Converter.ResumeLayout(false);
            this.Converter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValueIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Counter;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.TabPage Randomizer;
        private System.Windows.Forms.Label labelRndResult;
        private System.Windows.Forms.NumericUpDown numericUpDownTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.TextBox RndList;
        private System.Windows.Forms.Button buttonToClipboard;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.CheckBox checkBoxDuplicates;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsertDate;
        private System.Windows.Forms.ToolStripMenuItem InsertTime;
        private System.Windows.Forms.TabPage tabNotepad;
        private System.Windows.Forms.RichTextBox Notepad;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadNoteToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage Password;
        private System.Windows.Forms.TextBox GeneratedPassword;
        private System.Windows.Forms.Button GeneratePassword;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.NumericUpDown PasswordLength;
        private System.Windows.Forms.CheckedListBox PasswordSettings;
        private System.Windows.Forms.TabPage Converter;
        private System.Windows.Forms.TextBox ValueOut;
        private System.Windows.Forms.ComboBox comboBoxOut;
        private System.Windows.Forms.ComboBox comboBoxIn;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button ButtonSwap;
        private System.Windows.Forms.ComboBox comboBoxTypes;
        private System.Windows.Forms.NumericUpDown numericUpDownValueIn;
    }
}

