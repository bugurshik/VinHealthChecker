namespace VinHealthChecker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
       
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vinInput = new System.Windows.Forms.TextBox();
            this.FindVinBtn = new System.Windows.Forms.Button();
            this.etkVinDataOutput = new System.Windows.Forms.RichTextBox();
            this.DeleteEtkVinBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.Tab = new System.Windows.Forms.TabControl();
            this.etkPage = new System.Windows.Forms.TabPage();
            this.petPage = new System.Windows.Forms.TabPage();
            this.DeletePetVinBtn = new System.Windows.Forms.Button();
            this.petVinDataOutput = new System.Windows.Forms.RichTextBox();
            this.wrongPage = new System.Windows.Forms.TabPage();
            this.DeleteWrongVinBtn = new System.Windows.Forms.Button();
            this.wrongVinDataOutput = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.wrapPannel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.Tab.SuspendLayout();
            this.etkPage.SuspendLayout();
            this.petPage.SuspendLayout();
            this.wrongPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.wrapPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // vinInput
            // 
            this.vinInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vinInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.vinInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.vinInput.Location = new System.Drawing.Point(3, 28);
            this.vinInput.Name = "vinInput";
            this.vinInput.PlaceholderText = "Vin";
            this.vinInput.Size = new System.Drawing.Size(210, 23);
            this.vinInput.TabIndex = 0;
            this.vinInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vinInput_KeyDown);
            // 
            // FindVinBtn
            // 
            this.FindVinBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FindVinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindVinBtn.Location = new System.Drawing.Point(219, 28);
            this.FindVinBtn.Name = "FindVinBtn";
            this.FindVinBtn.Size = new System.Drawing.Size(77, 23);
            this.FindVinBtn.TabIndex = 1;
            this.FindVinBtn.Text = "Найти";
            this.FindVinBtn.UseVisualStyleBackColor = true;
            this.FindVinBtn.Click += new System.EventHandler(this.FindVinBtn_buttonClick);
            this.FindVinBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vinInput_KeyDown);
            // 
            // etkVinDataOutput
            // 
            this.etkVinDataOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.etkVinDataOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.etkVinDataOutput.Location = new System.Drawing.Point(6, 6);
            this.etkVinDataOutput.Name = "etkVinDataOutput";
            this.etkVinDataOutput.Size = new System.Drawing.Size(504, 408);
            this.etkVinDataOutput.TabIndex = 2;
            this.etkVinDataOutput.Text = "";
            // 
            // DeleteEtkVinBtn
            // 
            this.DeleteEtkVinBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteEtkVinBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.DeleteEtkVinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteEtkVinBtn.Location = new System.Drawing.Point(435, 420);
            this.DeleteEtkVinBtn.Name = "DeleteEtkVinBtn";
            this.DeleteEtkVinBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteEtkVinBtn.TabIndex = 1;
            this.DeleteEtkVinBtn.Text = "Удалить";
            this.DeleteEtkVinBtn.UseVisualStyleBackColor = true;
            this.DeleteEtkVinBtn.Click += new System.EventHandler(this.DeleteEtkVinBtn_buttonClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.FindVinBtn);
            this.panel1.Controls.Add(this.vinInput);
            this.panel1.Location = new System.Drawing.Point(14, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 60);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Поиск VIN кода:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResult.Location = new System.Drawing.Point(14, 91);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(141, 21);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Результат поиска: ";
            // 
            // Tab
            // 
            this.Tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab.Controls.Add(this.etkPage);
            this.Tab.Controls.Add(this.petPage);
            this.Tab.Controls.Add(this.wrongPage);
            this.Tab.Location = new System.Drawing.Point(10, 122);
            this.Tab.Margin = new System.Windows.Forms.Padding(10);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(524, 477);
            this.Tab.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.Tab.TabIndex = 5;
            // 
            // etkPage
            // 
            this.etkPage.BackColor = System.Drawing.Color.White;
            this.etkPage.Controls.Add(this.DeleteEtkVinBtn);
            this.etkPage.Controls.Add(this.etkVinDataOutput);
            this.etkPage.Location = new System.Drawing.Point(4, 24);
            this.etkPage.Name = "etkPage";
            this.etkPage.Padding = new System.Windows.Forms.Padding(3);
            this.etkPage.Size = new System.Drawing.Size(516, 449);
            this.etkPage.TabIndex = 0;
            this.etkPage.Text = "ETKA";
            // 
            // petPage
            // 
            this.petPage.Controls.Add(this.DeletePetVinBtn);
            this.petPage.Controls.Add(this.petVinDataOutput);
            this.petPage.Location = new System.Drawing.Point(4, 24);
            this.petPage.Name = "petPage";
            this.petPage.Padding = new System.Windows.Forms.Padding(3);
            this.petPage.Size = new System.Drawing.Size(516, 449);
            this.petPage.TabIndex = 1;
            this.petPage.Text = "PET";
            this.petPage.UseVisualStyleBackColor = true;
            // 
            // DeletePetVinBtn
            // 
            this.DeletePetVinBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeletePetVinBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.DeletePetVinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePetVinBtn.Location = new System.Drawing.Point(435, 420);
            this.DeletePetVinBtn.Name = "DeletePetVinBtn";
            this.DeletePetVinBtn.Size = new System.Drawing.Size(75, 23);
            this.DeletePetVinBtn.TabIndex = 3;
            this.DeletePetVinBtn.Text = "Удалить";
            this.DeletePetVinBtn.UseVisualStyleBackColor = true;
            this.DeletePetVinBtn.Click += new System.EventHandler(this.DeletePetVinBtn_Click);
            // 
            // petVinDataOutput
            // 
            this.petVinDataOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petVinDataOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.petVinDataOutput.Location = new System.Drawing.Point(6, 6);
            this.petVinDataOutput.Name = "petVinDataOutput";
            this.petVinDataOutput.Size = new System.Drawing.Size(504, 408);
            this.petVinDataOutput.TabIndex = 4;
            this.petVinDataOutput.Text = "";
            // 
            // wrongPage
            // 
            this.wrongPage.Controls.Add(this.DeleteWrongVinBtn);
            this.wrongPage.Controls.Add(this.wrongVinDataOutput);
            this.wrongPage.Location = new System.Drawing.Point(4, 24);
            this.wrongPage.Name = "wrongPage";
            this.wrongPage.Padding = new System.Windows.Forms.Padding(3);
            this.wrongPage.Size = new System.Drawing.Size(516, 449);
            this.wrongPage.TabIndex = 2;
            this.wrongPage.Text = "Wrong";
            this.wrongPage.UseVisualStyleBackColor = true;
            // 
            // DeleteWrongVinBtn
            // 
            this.DeleteWrongVinBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteWrongVinBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.DeleteWrongVinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteWrongVinBtn.Location = new System.Drawing.Point(435, 420);
            this.DeleteWrongVinBtn.Name = "DeleteWrongVinBtn";
            this.DeleteWrongVinBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteWrongVinBtn.TabIndex = 5;
            this.DeleteWrongVinBtn.Text = "Удалить";
            this.DeleteWrongVinBtn.UseVisualStyleBackColor = true;
            this.DeleteWrongVinBtn.Click += new System.EventHandler(this.DeleteWrongVinBtn_Click);
            // 
            // wrongVinDataOutput
            // 
            this.wrongVinDataOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wrongVinDataOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wrongVinDataOutput.Location = new System.Drawing.Point(6, 6);
            this.wrongVinDataOutput.Name = "wrongVinDataOutput";
            this.wrongVinDataOutput.Size = new System.Drawing.Size(504, 408);
            this.wrongVinDataOutput.TabIndex = 6;
            this.wrongVinDataOutput.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labelResult);
            this.panel2.Controls.Add(this.Tab);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(7, 7);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7);
            this.panel2.Size = new System.Drawing.Size(544, 609);
            this.panel2.TabIndex = 9;
            // 
            // wrapPannel
            // 
            this.wrapPannel.Controls.Add(this.panel2);
            this.wrapPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapPannel.Location = new System.Drawing.Point(0, 24);
            this.wrapPannel.Name = "wrapPannel";
            this.wrapPannel.Padding = new System.Windows.Forms.Padding(7);
            this.wrapPannel.Size = new System.Drawing.Size(558, 623);
            this.wrapPannel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(558, 647);
            this.Controls.Add(this.wrapPannel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(400, 39);
            this.Name = "Form1";
            this.Text = "Vin Checker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Tab.ResumeLayout(false);
            this.etkPage.ResumeLayout(false);
            this.petPage.ResumeLayout(false);
            this.wrongPage.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.wrapPannel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vinInput;
        private System.Windows.Forms.Button FindVinBtn;
        
        private System.Windows.Forms.Panel panel1;
       
        private System.Windows.Forms.Label labelResult;

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage etkPage;
        private System.Windows.Forms.TabPage petPage;
        private System.Windows.Forms.TabPage wrongPage;

        private System.Windows.Forms.Button DeletePetVinBtn;
        private System.Windows.Forms.Button DeleteWrongVinBtn;
        private System.Windows.Forms.Button DeleteEtkVinBtn;

        private System.Windows.Forms.RichTextBox etkVinDataOutput;
        private System.Windows.Forms.RichTextBox petVinDataOutput;
        private System.Windows.Forms.RichTextBox wrongVinDataOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel wrapPannel;
        private System.Windows.Forms.Label label1;
    }


}

