﻿namespace CSNotepad
 {
     partial class frmNotepad
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("New File");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotepad));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyCTRLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteCTRLVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sidebarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextNoteArea = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contextTabMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInNewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabWorkspace = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabFileProps = new System.Windows.Forms.TabPage();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabCtrlFiles = new System.Windows.Forms.TabControl();
            this.lineNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextNoteArea.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.contextTabMenu.SuspendLayout();
            this.tabWorkspace.SuspendLayout();
            this.tabFileProps.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(575, 379);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.newToolStripMenuItem1,
            this.textToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator4,
            this.findToolStripMenuItem,
            this.toolStripSeparator5,
            this.printToolStripMenuItem,
            this.toolStripSeparator6,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click_1);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(120, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(120, 6);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(120, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(120, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator1,
            this.copyCTRLCToolStripMenuItem,
            this.pasteCTRLVToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.toolStripSeparator2,
            this.preferencesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.undoToolStripMenuItem.Text = "Undo (CTRL + Z)";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.redoToolStripMenuItem.Text = "Redo (CTRL + Y)";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // copyCTRLCToolStripMenuItem
            // 
            this.copyCTRLCToolStripMenuItem.Name = "copyCTRLCToolStripMenuItem";
            this.copyCTRLCToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.copyCTRLCToolStripMenuItem.Text = "Copy (CTRL + C)";
            // 
            // pasteCTRLVToolStripMenuItem
            // 
            this.pasteCTRLVToolStripMenuItem.Name = "pasteCTRLVToolStripMenuItem";
            this.pasteCTRLVToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pasteCTRLVToolStripMenuItem.Text = "Paste (CTRL + V)";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cutToolStripMenuItem.Text = "Cut (CTRL + X)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(160, 6);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Checked = true;
            this.newToolStripMenuItem1.CheckOnClick = true;
            this.newToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.newToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sidebarToolStripMenuItem,
            this.lineNumbersToolStripMenuItem});
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.newToolStripMenuItem1.Text = "View";
            // 
            // sidebarToolStripMenuItem
            // 
            this.sidebarToolStripMenuItem.Checked = true;
            this.sidebarToolStripMenuItem.CheckOnClick = true;
            this.sidebarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sidebarToolStripMenuItem.Name = "sidebarToolStripMenuItem";
            this.sidebarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sidebarToolStripMenuItem.Text = "Sidebar";
            this.sidebarToolStripMenuItem.Click += new System.EventHandler(this.sidebarToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWrapToolStripMenuItem});
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.textToolStripMenuItem.Text = "Format";
            // 
            // wordWrapToolStripMenuItem
            // 
            this.wordWrapToolStripMenuItem.Checked = true;
            this.wordWrapToolStripMenuItem.CheckOnClick = true;
            this.wordWrapToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.wordWrapToolStripMenuItem.Text = "Word Wrap";
            this.wordWrapToolStripMenuItem.Click += new System.EventHandler(this.wordWrapToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(583, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "fileName1.txt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(583, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // contextNoteArea
            // 
            this.contextNoteArea.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextNoteArea.Name = "contextMenuStrip1";
            this.contextNoteArea.Size = new System.Drawing.Size(103, 48);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Plain text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.ContextMenuStrip = this.contextTabMenu;
            this.tabControl1.Controls.Add(this.tabWorkspace);
            this.tabControl1.Controls.Add(this.tabFileProps);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(134, 440);
            this.tabControl1.TabIndex = 3;
            // 
            // contextTabMenu
            // 
            this.contextTabMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.openInNewWindowToolStripMenuItem});
            this.contextTabMenu.Name = "contextTabMenu";
            this.contextTabMenu.Size = new System.Drawing.Size(187, 48);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.renameToolStripMenuItem.Text = "Rename Tab";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // openInNewWindowToolStripMenuItem
            // 
            this.openInNewWindowToolStripMenuItem.Name = "openInNewWindowToolStripMenuItem";
            this.openInNewWindowToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openInNewWindowToolStripMenuItem.Text = "Open in new window";
            // 
            // tabWorkspace
            // 
            this.tabWorkspace.AllowDrop = true;
            this.tabWorkspace.AutoScroll = true;
            this.tabWorkspace.Controls.Add(this.treeView1);
            this.tabWorkspace.Location = new System.Drawing.Point(23, 4);
            this.tabWorkspace.Name = "tabWorkspace";
            this.tabWorkspace.Padding = new System.Windows.Forms.Padding(3);
            this.tabWorkspace.Size = new System.Drawing.Size(107, 432);
            this.tabWorkspace.TabIndex = 0;
            this.tabWorkspace.Text = "Explorer";
            this.tabWorkspace.UseVisualStyleBackColor = true;
            this.tabWorkspace.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 4);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "treeviewRootWorkspace";
            treeNode1.Text = "New File";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(95, 401);
            this.treeView1.TabIndex = 0;
            // 
            // tabFileProps
            // 
            this.tabFileProps.Controls.Add(this.treeView2);
            this.tabFileProps.Location = new System.Drawing.Point(23, 4);
            this.tabFileProps.Name = "tabFileProps";
            this.tabFileProps.Padding = new System.Windows.Forms.Padding(3);
            this.tabFileProps.Size = new System.Drawing.Size(107, 432);
            this.tabFileProps.TabIndex = 1;
            this.tabFileProps.Text = "Contents";
            this.tabFileProps.UseVisualStyleBackColor = true;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(6, 6);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(114, 401);
            this.treeView2.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.SupportMultiDottedExtensions = true;
            // 
            // tabCtrlFiles
            // 
            this.tabCtrlFiles.ContextMenuStrip = this.contextTabMenu;
            this.tabCtrlFiles.Location = new System.Drawing.Point(161, 24);
            this.tabCtrlFiles.Name = "tabCtrlFiles";
            this.tabCtrlFiles.SelectedIndex = 0;
            this.tabCtrlFiles.Size = new System.Drawing.Size(593, 440);
            this.tabCtrlFiles.TabIndex = 0;
            // 
            // lineNumbersToolStripMenuItem
            // 
            this.lineNumbersToolStripMenuItem.Checked = true;
            this.lineNumbersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lineNumbersToolStripMenuItem.Name = "lineNumbersToolStripMenuItem";
            this.lineNumbersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lineNumbersToolStripMenuItem.Text = "Line Numbers";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "1"});
            this.listBox1.Location = new System.Drawing.Point(136, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(22, 438);
            this.listBox1.TabIndex = 1;
            // 
            // frmNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(754, 464);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tabCtrlFiles);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmNotepad";
            this.Text = "Notepad Studio";
            this.Load += new System.EventHandler(this.frmNotepad_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.contextNoteArea.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.contextTabMenu.ResumeLayout(false);
            this.tabWorkspace.ResumeLayout(false);
            this.tabFileProps.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

         }
         #endregion

         private System.Windows.Forms.RichTextBox richTextBox1;
         private System.Windows.Forms.RichTextBox notePadField0;
         private System.Windows.Forms.MenuStrip menuStrip1;
         private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
         private System.Windows.Forms.TabPage tabPage1;
         private System.Windows.Forms.TabPage tabPage2;
         private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
         private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
         private System.Windows.Forms.SaveFileDialog saveFileDialog1;
         private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
         private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
         private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
         private System.Windows.Forms.TabControl tabControl1;
         private System.Windows.Forms.TabPage tabWorkspace;
         private System.Windows.Forms.TabPage tabFileProps;
         private System.Windows.Forms.OpenFileDialog openFileDialog1;
         private System.Windows.Forms.ContextMenuStrip contextNoteArea;
         private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem sidebarToolStripMenuItem;
         private System.Windows.Forms.ContextMenuStrip contextTabMenu;
         private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
         private System.Windows.Forms.TreeView treeView1;
         private System.Windows.Forms.TreeView treeView2;
         private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
         private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
         private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
         private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
         private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
         private System.Windows.Forms.ToolStripMenuItem copyCTRLCToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem pasteCTRLVToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
         private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
         private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
         private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
         private System.Windows.Forms.TabControl tabCtrlFiles;
         private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem openInNewWindowToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem lineNumbersToolStripMenuItem;
         private System.Windows.Forms.ListBox listBox1;
     }
 }