using System.ComponentModel;

namespace lab_2;

partial class WelcomeForm
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
        buttonLoadFromJson = new System.Windows.Forms.Button();
        buttonLoadFromXml = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // buttonLoadFromJson
        // 
        buttonLoadFromJson.Location = new System.Drawing.Point(72, 126);
        buttonLoadFromJson.Name = "buttonLoadFromJson";
        buttonLoadFromJson.Size = new System.Drawing.Size(277, 128);
        buttonLoadFromJson.TabIndex = 0;
        buttonLoadFromJson.Text = "Закгрузить из json";
        buttonLoadFromJson.UseVisualStyleBackColor = true;
        buttonLoadFromJson.Click += buttonLoadFromJson_Click;
        // 
        // buttonLoadFromXml
        // 
        buttonLoadFromXml.Location = new System.Drawing.Point(401, 126);
        buttonLoadFromXml.Name = "buttonLoadFromXml";
        buttonLoadFromXml.Size = new System.Drawing.Size(249, 123);
        buttonLoadFromXml.TabIndex = 1;
        buttonLoadFromXml.Text = "Загрузить из xml";
        buttonLoadFromXml.UseVisualStyleBackColor = true;
        buttonLoadFromXml.Click += buttonLoadFromXml_Click;
        // 
        // WelcomeForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(buttonLoadFromXml);
        Controls.Add(buttonLoadFromJson);
        Text = "WelcomeForm";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button buttonLoadFromJson;
    private System.Windows.Forms.Button buttonLoadFromXml;

    #endregion
}