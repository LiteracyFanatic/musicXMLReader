namespace musicXMLReader
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.readButton = new System.Windows.Forms.Button();
            this.openMusicDialog = new System.Windows.Forms.OpenFileDialog();
            this.partsListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tempoBox = new System.Windows.Forms.RichTextBox();
            this.divisionBox = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.notesBox = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timesBox = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.durationsBox = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rawBox = new System.Windows.Forms.RichTextBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(10, 12);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(132, 53);
            this.readButton.TabIndex = 2;
            this.readButton.Text = "Import";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // partsListBox
            // 
            this.partsListBox.FormattingEnabled = true;
            this.partsListBox.ItemHeight = 20;
            this.partsListBox.Location = new System.Drawing.Point(12, 78);
            this.partsListBox.Name = "partsListBox";
            this.partsListBox.Size = new System.Drawing.Size(200, 504);
            this.partsListBox.TabIndex = 3;
            this.partsListBox.SelectedIndexChanged += new System.EventHandler(this.partsListBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(824, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Division";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(683, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tempo";
            // 
            // tempoBox
            // 
            this.tempoBox.Location = new System.Drawing.Point(687, 35);
            this.tempoBox.Multiline = false;
            this.tempoBox.Name = "tempoBox";
            this.tempoBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tempoBox.Size = new System.Drawing.Size(90, 30);
            this.tempoBox.TabIndex = 16;
            this.tempoBox.Text = "";
            // 
            // divisionBox
            // 
            this.divisionBox.Location = new System.Drawing.Point(828, 35);
            this.divisionBox.Multiline = false;
            this.divisionBox.Name = "divisionBox";
            this.divisionBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.divisionBox.Size = new System.Drawing.Size(90, 30);
            this.divisionBox.TabIndex = 17;
            this.divisionBox.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(218, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 504);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.notesBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(702, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Notes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // notesBox
            // 
            this.notesBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notesBox.Location = new System.Drawing.Point(3, 6);
            this.notesBox.Name = "notesBox";
            this.notesBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.notesBox.Size = new System.Drawing.Size(693, 456);
            this.notesBox.TabIndex = 14;
            this.notesBox.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.timesBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(702, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Times";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timesBox
            // 
            this.timesBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timesBox.Location = new System.Drawing.Point(3, 3);
            this.timesBox.Name = "timesBox";
            this.timesBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.timesBox.Size = new System.Drawing.Size(693, 465);
            this.timesBox.TabIndex = 15;
            this.timesBox.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.durationsBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(702, 471);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Durations";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // durationsBox
            // 
            this.durationsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.durationsBox.Location = new System.Drawing.Point(3, 3);
            this.durationsBox.Name = "durationsBox";
            this.durationsBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.durationsBox.Size = new System.Drawing.Size(693, 462);
            this.durationsBox.TabIndex = 16;
            this.durationsBox.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rawBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(702, 471);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Raw";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rawBox
            // 
            this.rawBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rawBox.Location = new System.Drawing.Point(6, 5);
            this.rawBox.Name = "rawBox";
            this.rawBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rawBox.Size = new System.Drawing.Size(690, 459);
            this.rawBox.TabIndex = 16;
            this.rawBox.Text = "";
            // 
            // copyButton
            // 
            this.copyButton.Enabled = false;
            this.copyButton.Location = new System.Drawing.Point(156, 12);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(190, 53);
            this.copyButton.TabIndex = 19;
            this.copyButton.Text = "Copy To Clipboard";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(378, 35);
            this.nameBox.Multiline = false;
            this.nameBox.Name = "nameBox";
            this.nameBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.nameBox.Size = new System.Drawing.Size(263, 30);
            this.nameBox.TabIndex = 21;
            this.nameBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 592);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.divisionBox);
            this.Controls.Add(this.tempoBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.partsListBox);
            this.Controls.Add(this.readButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Music XML Reader";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.OpenFileDialog openMusicDialog;
        private System.Windows.Forms.ListBox partsListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox tempoBox;
        private System.Windows.Forms.RichTextBox divisionBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox timesBox;
        private System.Windows.Forms.RichTextBox durationsBox;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox notesBox;
        private System.Windows.Forms.RichTextBox rawBox;
        private System.Windows.Forms.RichTextBox nameBox;
        private System.Windows.Forms.Label label1;
    }
}

