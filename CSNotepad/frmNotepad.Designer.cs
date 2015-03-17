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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("workspaceName0");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotepad));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sidebarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notePadField0 = new System.Windows.Forms.RichTextBox();
            this.contextNoteArea = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabWorkspace = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabContent = new System.Windows.Forms.TabPage();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.contextTabStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renameTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteTab1 = new System.Windows.Forms.TabPage();
            this.noteTab2 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextNoteArea.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabWorkspace.SuspendLayout();
            this.tabContent.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.contextTabStrip.SuspendLayout();
            this.noteTab1.SuspendLayout();
            this.noteTab2.SuspendLayout();
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
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(717, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New (Ctrl + N)";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click_1);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open (Ctrl + O)";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save (Ctrl + S)";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit (Ctrl + Q)";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator1,
            this.preferencesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.undoToolStripMenuItem.Text = "Undo (CTRL + Z)";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.redoToolStripMenuItem.Text = "Redo (CTRL + Y)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sidebarToolStripMenuItem});
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.newToolStripMenuItem1.Text = "View";
            // 
            // sidebarToolStripMenuItem
            // 
            this.sidebarToolStripMenuItem.Checked = true;
            this.sidebarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sidebarToolStripMenuItem.Name = "sidebarToolStripMenuItem";
            this.sidebarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sidebarToolStripMenuItem.Text = "Sidebar";
            this.sidebarToolStripMenuItem.Click += new System.EventHandler(this.sidebarToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
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
            // notePadField0
            // 
            this.notePadField0.AcceptsTab = true;
            this.notePadField0.ContextMenuStrip = this.contextNoteArea;
            this.notePadField0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notePadField0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notePadField0.Location = new System.Drawing.Point(3, 3);
            this.notePadField0.Name = "notePadField0";
            this.notePadField0.Size = new System.Drawing.Size(569, 407);
            this.notePadField0.TabIndex = 2;
            this.notePadField0.Text = "";
            this.notePadField0.TextChanged += new System.EventHandler(this.notePadField0_TextChanged);
            // 
            // contextNoteArea
            // 
            this.contextNoteArea.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextNoteArea.Name = "contextMenuStrip1";
            this.contextNoteArea.Size = new System.Drawing.Size(102, 48);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabWorkspace);
            this.tabControl1.Controls.Add(this.tabContent);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(134, 439);
            this.tabControl1.TabIndex = 3;
            // 
            // tabWorkspace
            // 
            this.tabWorkspace.AllowDrop = true;
            this.tabWorkspace.AutoScroll = true;
            this.tabWorkspace.Controls.Add(this.treeView1);
            this.tabWorkspace.Location = new System.Drawing.Point(4, 22);
            this.tabWorkspace.Name = "tabWorkspace";
            this.tabWorkspace.Padding = new System.Windows.Forms.Padding(3);
            this.tabWorkspace.Size = new System.Drawing.Size(126, 413);
            this.tabWorkspace.TabIndex = 0;
            this.tabWorkspace.Text = "Workspace";
            this.tabWorkspace.UseVisualStyleBackColor = true;
            this.tabWorkspace.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "workspaceName0";
            treeNode1.Text = "workspaceName0";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(120, 407);
            this.treeView1.TabIndex = 0;
            // 
            // tabContent
            // 
            this.tabContent.Controls.Add(this.treeView2);
            this.tabContent.Location = new System.Drawing.Point(4, 22);
            this.tabContent.Name = "tabContent";
            this.tabContent.Padding = new System.Windows.Forms.Padding(3);
            this.tabContent.Size = new System.Drawing.Size(126, 413);
            this.tabContent.TabIndex = 1;
            this.tabContent.Text = "Content";
            this.tabContent.UseVisualStyleBackColor = true;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(2, 3);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(121, 402);
            this.treeView2.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.ContextMenuStrip = this.contextTabStrip;
            this.tabControl2.Controls.Add(this.noteTab1);
            this.tabControl2.Controls.Add(this.noteTab2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(134, 24);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(583, 439);
            this.tabControl2.TabIndex = 4;
            // 
            // contextTabStrip
            // 
            this.contextTabStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameTabToolStripMenuItem});
            this.contextTabStrip.Name = "contextTabStrip";
            this.contextTabStrip.Size = new System.Drawing.Size(135, 26);
            // 
            // renameTabToolStripMenuItem
            // 
            this.renameTabToolStripMenuItem.Name = "renameTabToolStripMenuItem";
            this.renameTabToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.renameTabToolStripMenuItem.Text = "Rename Tab";
            // 
            // noteTab1
            // 
            this.noteTab1.Controls.Add(this.notePadField0);
            this.noteTab1.Location = new System.Drawing.Point(4, 22);
            this.noteTab1.Name = "noteTab1";
            this.noteTab1.Padding = new System.Windows.Forms.Padding(3);
            this.noteTab1.Size = new System.Drawing.Size(575, 413);
            this.noteTab1.TabIndex = 0;
            this.noteTab1.Text = "New Text";
            this.noteTab1.UseVisualStyleBackColor = true;
            // 
            // noteTab2
            // 
            this.noteTab2.Controls.Add(this.richTextBox2);
            this.noteTab2.Location = new System.Drawing.Point(4, 22);
            this.noteTab2.Name = "noteTab2";
            this.noteTab2.Padding = new System.Windows.Forms.Padding(3);
            this.noteTab2.Size = new System.Drawing.Size(575, 413);
            this.noteTab2.TabIndex = 1;
            this.noteTab2.Text = "New Text 2";
            this.noteTab2.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(3, 3);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(569, 407);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // frmNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(717, 463);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmNotepad";
            this.Text = "Notepad Studio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.contextNoteArea.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabWorkspace.ResumeLayout(false);
            this.tabContent.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.contextTabStrip.ResumeLayout(false);
            this.noteTab1.ResumeLayout(false);
            this.noteTab2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

         }
         #endregion

         private System.Windows.Forms.RichTextBox richTextBox1;
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
         private System.Windows.Forms.RichTextBox notePadField0;
         private System.Windows.Forms.SaveFileDialog saveFileDialog1;
         private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
         private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
         private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
         private System.Windows.Forms.TabControl tabControl1;
         private System.Windows.Forms.TabPage tabWorkspace;
         private System.Windows.Forms.TabPage tabContent;
         private System.Windows.Forms.TabControl tabControl2;
         private System.Windows.Forms.TabPage noteTab1;
         private System.Windows.Forms.TabPage noteTab2;
         private System.Windows.Forms.OpenFileDialog openFileDialog1;
         private System.Windows.Forms.RichTextBox richTextBox2;
         private System.Windows.Forms.ContextMenuStrip contextNoteArea;
         private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem sidebarToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
         private System.Windows.Forms.TreeView treeView1;
         private System.Windows.Forms.ContextMenuStrip contextTabStrip;
         private System.Windows.Forms.ToolStripMenuItem renameTabToolStripMenuItem;
         private System.Windows.Forms.TreeView treeView2;
         private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
     }
 }