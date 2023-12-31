﻿namespace MakefileGui
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.wdTextBox = new System.Windows.Forms.TextBox();
            this.wdTextBoxLabel = new System.Windows.Forms.Label();
            this.wdBrowseButton = new System.Windows.Forms.Button();
            this.makefileTextBoxLabel = new System.Windows.Forms.Label();
            this.makefileTextBox = new System.Windows.Forms.TextBox();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.targetTextBoxLabel = new System.Windows.Forms.Label();
            this.extraVarsLabel = new System.Windows.Forms.Label();
            this.extraVarsList = new System.Windows.Forms.ListBox();
            this.extraVarNameTextBox = new System.Windows.Forms.TextBox();
            this.extraVarValueTextBox = new System.Windows.Forms.TextBox();
            this.extraVarAddButton = new System.Windows.Forms.Button();
            this.extraVarNameTextBoxLabel = new System.Windows.Forms.Label();
            this.extraVarValueTextBoxLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.removeSelectedExtraVarButton = new System.Windows.Forms.Button();
            this.makeButton = new System.Windows.Forms.Button();
            this.makeOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRecentDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraFlagsTextBoxLabel = new System.Windows.Forms.Label();
            this.extraFlagsTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // wdTextBox
            // 
            this.wdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wdTextBox.Location = new System.Drawing.Point(11, 26);
            this.wdTextBox.Name = "wdTextBox";
            this.wdTextBox.Size = new System.Drawing.Size(209, 20);
            this.wdTextBox.TabIndex = 0;
            // 
            // wdTextBoxLabel
            // 
            this.wdTextBoxLabel.AutoSize = true;
            this.wdTextBoxLabel.Location = new System.Drawing.Point(8, 10);
            this.wdTextBoxLabel.Name = "wdTextBoxLabel";
            this.wdTextBoxLabel.Size = new System.Drawing.Size(90, 13);
            this.wdTextBoxLabel.TabIndex = 1;
            this.wdTextBoxLabel.Text = "Working directory";
            // 
            // wdBrowseButton
            // 
            this.wdBrowseButton.Location = new System.Drawing.Point(226, 26);
            this.wdBrowseButton.Name = "wdBrowseButton";
            this.wdBrowseButton.Size = new System.Drawing.Size(72, 20);
            this.wdBrowseButton.TabIndex = 2;
            this.wdBrowseButton.Text = "Browse...";
            this.wdBrowseButton.UseVisualStyleBackColor = true;
            this.wdBrowseButton.Click += new System.EventHandler(this.wdBrowseButton_Click);
            // 
            // makefileTextBoxLabel
            // 
            this.makefileTextBoxLabel.AutoSize = true;
            this.makefileTextBoxLabel.Location = new System.Drawing.Point(8, 49);
            this.makefileTextBoxLabel.Name = "makefileTextBoxLabel";
            this.makefileTextBoxLabel.Size = new System.Drawing.Size(299, 13);
            this.makefileTextBoxLabel.TabIndex = 3;
            this.makefileTextBoxLabel.Text = "Makefile name relative to working directory (blank = \'Makefile\')";
            // 
            // makefileTextBox
            // 
            this.makefileTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makefileTextBox.Location = new System.Drawing.Point(11, 65);
            this.makefileTextBox.Name = "makefileTextBox";
            this.makefileTextBox.Size = new System.Drawing.Size(209, 20);
            this.makefileTextBox.TabIndex = 4;
            // 
            // targetTextBox
            // 
            this.targetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetTextBox.Location = new System.Drawing.Point(11, 104);
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.Size = new System.Drawing.Size(209, 20);
            this.targetTextBox.TabIndex = 6;
            // 
            // targetTextBoxLabel
            // 
            this.targetTextBoxLabel.AutoSize = true;
            this.targetTextBoxLabel.Location = new System.Drawing.Point(8, 88);
            this.targetTextBoxLabel.Name = "targetTextBoxLabel";
            this.targetTextBoxLabel.Size = new System.Drawing.Size(290, 13);
            this.targetTextBoxLabel.TabIndex = 5;
            this.targetTextBoxLabel.Text = "Targets to build separated by spaces (blank = default target)";
            // 
            // extraVarsLabel
            // 
            this.extraVarsLabel.AutoSize = true;
            this.extraVarsLabel.Location = new System.Drawing.Point(9, 8);
            this.extraVarsLabel.Name = "extraVarsLabel";
            this.extraVarsLabel.Size = new System.Drawing.Size(76, 13);
            this.extraVarsLabel.TabIndex = 7;
            this.extraVarsLabel.Text = "Extra variables";
            // 
            // extraVarsList
            // 
            this.extraVarsList.FormattingEnabled = true;
            this.extraVarsList.Location = new System.Drawing.Point(12, 24);
            this.extraVarsList.Name = "extraVarsList";
            this.extraVarsList.Size = new System.Drawing.Size(252, 121);
            this.extraVarsList.TabIndex = 8;
            // 
            // extraVarNameTextBox
            // 
            this.extraVarNameTextBox.Location = new System.Drawing.Point(12, 152);
            this.extraVarNameTextBox.Name = "extraVarNameTextBox";
            this.extraVarNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.extraVarNameTextBox.TabIndex = 9;
            // 
            // extraVarValueTextBox
            // 
            this.extraVarValueTextBox.Location = new System.Drawing.Point(119, 151);
            this.extraVarValueTextBox.Name = "extraVarValueTextBox";
            this.extraVarValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.extraVarValueTextBox.TabIndex = 10;
            // 
            // extraVarAddButton
            // 
            this.extraVarAddButton.Location = new System.Drawing.Point(226, 151);
            this.extraVarAddButton.Name = "extraVarAddButton";
            this.extraVarAddButton.Size = new System.Drawing.Size(38, 20);
            this.extraVarAddButton.TabIndex = 11;
            this.extraVarAddButton.Text = "Add";
            this.extraVarAddButton.UseVisualStyleBackColor = true;
            this.extraVarAddButton.Click += new System.EventHandler(this.extraVarAddButton_Click);
            // 
            // extraVarNameTextBoxLabel
            // 
            this.extraVarNameTextBoxLabel.AutoSize = true;
            this.extraVarNameTextBoxLabel.Location = new System.Drawing.Point(9, 175);
            this.extraVarNameTextBoxLabel.Name = "extraVarNameTextBoxLabel";
            this.extraVarNameTextBoxLabel.Size = new System.Drawing.Size(35, 13);
            this.extraVarNameTextBoxLabel.TabIndex = 12;
            this.extraVarNameTextBoxLabel.Text = "Name";
            // 
            // extraVarValueTextBoxLabel
            // 
            this.extraVarValueTextBoxLabel.AutoSize = true;
            this.extraVarValueTextBoxLabel.Location = new System.Drawing.Point(119, 175);
            this.extraVarValueTextBoxLabel.Name = "extraVarValueTextBoxLabel";
            this.extraVarValueTextBoxLabel.Size = new System.Drawing.Size(34, 13);
            this.extraVarValueTextBoxLabel.TabIndex = 13;
            this.extraVarValueTextBoxLabel.Text = "Value";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.extraFlagsTextBox);
            this.panel1.Controls.Add(this.extraFlagsTextBoxLabel);
            this.panel1.Controls.Add(this.wdTextBoxLabel);
            this.panel1.Controls.Add(this.wdTextBox);
            this.panel1.Controls.Add(this.wdBrowseButton);
            this.panel1.Controls.Add(this.makefileTextBoxLabel);
            this.panel1.Controls.Add(this.makefileTextBox);
            this.panel1.Controls.Add(this.targetTextBoxLabel);
            this.panel1.Controls.Add(this.targetTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 224);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.removeSelectedExtraVarButton);
            this.panel2.Controls.Add(this.extraVarsList);
            this.panel2.Controls.Add(this.extraVarsLabel);
            this.panel2.Controls.Add(this.extraVarValueTextBoxLabel);
            this.panel2.Controls.Add(this.extraVarNameTextBox);
            this.panel2.Controls.Add(this.extraVarNameTextBoxLabel);
            this.panel2.Controls.Add(this.extraVarValueTextBox);
            this.panel2.Controls.Add(this.extraVarAddButton);
            this.panel2.Location = new System.Drawing.Point(334, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 224);
            this.panel2.TabIndex = 15;
            // 
            // removeSelectedExtraVarButton
            // 
            this.removeSelectedExtraVarButton.Location = new System.Drawing.Point(12, 192);
            this.removeSelectedExtraVarButton.Name = "removeSelectedExtraVarButton";
            this.removeSelectedExtraVarButton.Size = new System.Drawing.Size(100, 23);
            this.removeSelectedExtraVarButton.TabIndex = 14;
            this.removeSelectedExtraVarButton.Text = "Remove selected";
            this.removeSelectedExtraVarButton.UseVisualStyleBackColor = true;
            this.removeSelectedExtraVarButton.Click += new System.EventHandler(this.removeSelectedExtraVarButton_Click);
            // 
            // makeButton
            // 
            this.makeButton.Location = new System.Drawing.Point(13, 258);
            this.makeButton.Name = "makeButton";
            this.makeButton.Size = new System.Drawing.Size(75, 23);
            this.makeButton.TabIndex = 16;
            this.makeButton.Text = "Make";
            this.makeButton.UseVisualStyleBackColor = true;
            this.makeButton.Click += new System.EventHandler(this.makeButton_Click);
            // 
            // makeOutput
            // 
            this.makeOutput.BackColor = System.Drawing.SystemColors.Window;
            this.makeOutput.Location = new System.Drawing.Point(94, 274);
            this.makeOutput.Multiline = true;
            this.makeOutput.Name = "makeOutput";
            this.makeOutput.ReadOnly = true;
            this.makeOutput.Size = new System.Drawing.Size(524, 88);
            this.makeOutput.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Output";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(630, 24);
            this.menuStrip.TabIndex = 19;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openRecentDirectoryToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openRecentDirectoryToolStripMenuItem
            // 
            this.openRecentDirectoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.openRecentDirectoryToolStripMenuItem.Name = "openRecentDirectoryToolStripMenuItem";
            this.openRecentDirectoryToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.openRecentDirectoryToolStripMenuItem.Text = "Open recent directory";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(83, 22);
            this.toolStripMenuItem2.Text = "...";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
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
            // extraFlagsTextBoxLabel
            // 
            this.extraFlagsTextBoxLabel.AutoSize = true;
            this.extraFlagsTextBoxLabel.Location = new System.Drawing.Point(8, 127);
            this.extraFlagsTextBoxLabel.Name = "extraFlagsTextBoxLabel";
            this.extraFlagsTextBoxLabel.Size = new System.Drawing.Size(56, 13);
            this.extraFlagsTextBoxLabel.TabIndex = 7;
            this.extraFlagsTextBoxLabel.Text = "Extra flags";
            // 
            // extraFlagsTextBox
            // 
            this.extraFlagsTextBox.Location = new System.Drawing.Point(11, 144);
            this.extraFlagsTextBox.Name = "extraFlagsTextBox";
            this.extraFlagsTextBox.Size = new System.Drawing.Size(209, 20);
            this.extraFlagsTextBox.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.makeOutput);
            this.Controls.Add(this.makeButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Makefile GUI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wdTextBox;
        private System.Windows.Forms.Label wdTextBoxLabel;
        private System.Windows.Forms.Button wdBrowseButton;
        private System.Windows.Forms.Label makefileTextBoxLabel;
        private System.Windows.Forms.TextBox makefileTextBox;
        private System.Windows.Forms.TextBox targetTextBox;
        private System.Windows.Forms.Label targetTextBoxLabel;
        private System.Windows.Forms.Label extraVarsLabel;
        private System.Windows.Forms.ListBox extraVarsList;
        private System.Windows.Forms.TextBox extraVarNameTextBox;
        private System.Windows.Forms.TextBox extraVarValueTextBox;
        private System.Windows.Forms.Button extraVarAddButton;
        private System.Windows.Forms.Label extraVarNameTextBoxLabel;
        private System.Windows.Forms.Label extraVarValueTextBoxLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button removeSelectedExtraVarButton;
        private System.Windows.Forms.Button makeButton;
        private System.Windows.Forms.TextBox makeOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRecentDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TextBox extraFlagsTextBox;
        private System.Windows.Forms.Label extraFlagsTextBoxLabel;
    }
}