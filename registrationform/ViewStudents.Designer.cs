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
        dataGridView1 = new System.Windows.Forms.DataGridView();
        stext = new System.Windows.Forms.TextBox();
        Search = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
        // 
        // ViewStudents
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(Search);
        Controls.Add(stext);
        Controls.Add(dataGridView1);
        Text = "ViewStudents";
        Load += ViewStudents_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox stext;
    private System.Windows.Forms.Button Search;

    private System.Windows.Forms.DataGridView dataGridView1;

    #endregion
}