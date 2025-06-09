using System.ComponentModel;

namespace registrationform;

partial class ViewStudents
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudents));
        dataGridView1 = new System.Windows.Forms.DataGridView();
        stext = new System.Windows.Forms.TextBox();
        Search = new System.Windows.Forms.Button();
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
        saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
        cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
        selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new System.Drawing.Point(16, 78);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new System.Drawing.Size(765, 353);
        dataGridView1.TabIndex = 0;
        dataGridView1.Text = "dataGridView1";
        dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        // 
        // stext
        // 
        stext.Location = new System.Drawing.Point(28, 25);
        stext.Name = "stext";
        stext.Size = new System.Drawing.Size(161, 23);
        stext.TabIndex = 1;
        stext.Text = "Search...";
        // 
        // Search
        // 
        Search.Location = new System.Drawing.Point(207, 25);
        Search.Name = "Search";
        Search.Size = new System.Drawing.Size(75, 23);
        Search.TabIndex = 2;
        Search.Text = "Search";
        Search.UseVisualStyleBackColor = true;
        Search.Click += Search_Click;
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, toolStripMenuItem1, editToolStripMenuItem });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(800, 24);
        menuStrip1.TabIndex = 3;
        menuStrip1.Text = "menuStrip1";
        menuStrip1.ItemClicked += menuStrip1_ItemClicked;
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, printToolStripMenuItem, printPreviewToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
        fileToolStripMenuItem.Text = "&File";
        fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
        // 
        // newToolStripMenuItem
        // 
        newToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("newToolStripMenuItem.Image"));
        newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        newToolStripMenuItem.Name = "newToolStripMenuItem";
        newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
        newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        newToolStripMenuItem.Text = "&New";
        // 
        // openToolStripMenuItem
        // 
        openToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("openToolStripMenuItem.Image"));
        openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        openToolStripMenuItem.Name = "openToolStripMenuItem";
        openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
        openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        openToolStripMenuItem.Text = "&Open";
        // 
        // toolStripSeparator
        // 
        toolStripSeparator.Name = "toolStripSeparator";
        toolStripSeparator.Size = new System.Drawing.Size(177, 6);
        // 
        // saveToolStripMenuItem
        // 
        saveToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("saveToolStripMenuItem.Image"));
        saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
        saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        saveToolStripMenuItem.Text = "&Save";
        // 
        // saveAsToolStripMenuItem
        // 
        saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
        saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        saveAsToolStripMenuItem.Text = "Save &As";
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
        // 
        // printToolStripMenuItem
        // 
        printToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("printToolStripMenuItem.Image"));
        printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        printToolStripMenuItem.Name = "printToolStripMenuItem";
        printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
        printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        printToolStripMenuItem.Text = "&Print";
        // 
        // printPreviewToolStripMenuItem
        // 
        printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("printPreviewToolStripMenuItem.Image"));
        printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
        printPreviewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        printPreviewToolStripMenuItem.Text = "Print Pre&view";
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
        // 
        // exitToolStripMenuItem
        // 
        exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        exitToolStripMenuItem.Text = "E&xit";
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
        // 
        // editToolStripMenuItem
        // 
        editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem });
        editToolStripMenuItem.Name = "editToolStripMenuItem";
        editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
        editToolStripMenuItem.Text = "&Edit";
        editToolStripMenuItem.Click += editToolStripMenuItem_Click;
        // 
        // undoToolStripMenuItem
        // 
        undoToolStripMenuItem.Name = "undoToolStripMenuItem";
        undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
        undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
        undoToolStripMenuItem.Text = "&Undo";
        // 
        // redoToolStripMenuItem
        // 
        redoToolStripMenuItem.Name = "redoToolStripMenuItem";
        redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y));
        redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
        redoToolStripMenuItem.Text = "&Redo";
        // 
        // toolStripSeparator3
        // 
        toolStripSeparator3.Name = "toolStripSeparator3";
        toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
        // 
        // cutToolStripMenuItem
        // 
        cutToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("cutToolStripMenuItem.Image"));
        cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        cutToolStripMenuItem.Name = "cutToolStripMenuItem";
        cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
        cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
        cutToolStripMenuItem.Text = "Cu&t";
        // 
        // copyToolStripMenuItem
        // 
        copyToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("copyToolStripMenuItem.Image"));
        copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        copyToolStripMenuItem.Name = "copyToolStripMenuItem";
        copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
        copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
        copyToolStripMenuItem.Text = "&Copy";
        // 
        // pasteToolStripMenuItem
        // 
        pasteToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("pasteToolStripMenuItem.Image"));
        pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
        pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V));
        pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
        pasteToolStripMenuItem.Text = "&Paste";
        // 
        // toolStripSeparator4
        // 
        toolStripSeparator4.Name = "toolStripSeparator4";
        toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
        // 
        // selectAllToolStripMenuItem
        // 
        selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
        selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
        selectAllToolStripMenuItem.Text = "Select &All";
        // 
        // ViewStudents
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(Search);
        Controls.Add(stext);
        Controls.Add(dataGridView1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Text = "ViewStudents";
        Load += ViewStudents_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;

    private System.Windows.Forms.MenuStrip menuStrip1;

    private System.Windows.Forms.TextBox stext;
    private System.Windows.Forms.Button Search;

    private System.Windows.Forms.DataGridView dataGridView1;

    #endregion
}