using System.ComponentModel;

namespace lab_2;

partial class EntityInfoForm
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
        richTextBox1 = new System.Windows.Forms.RichTextBox();
        SuspendLayout();
        // 
        // richTextBox1
        // 
        richTextBox1.Location = new System.Drawing.Point(5, 4);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new System.Drawing.Size(793, 444);
        richTextBox1.TabIndex = 0;
        richTextBox1.Text = "";
        // 
        // EntityInfoForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(richTextBox1);
        Text = "BeeInfo";
        ResumeLayout(false);
    }

    private System.Windows.Forms.RichTextBox richTextBox1;

    #endregion
}