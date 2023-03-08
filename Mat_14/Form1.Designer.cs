namespace Mat_14
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
      components = new System.ComponentModel.Container();
      button1 = new Button();
      textBox1 = new TextBox();
      timer1 = new System.Windows.Forms.Timer(components);
      panel1 = new Panel();
      button2 = new Button();
      SuspendLayout();
      // 
      // button1
      // 
      button1.Location = new Point(12, 14);
      button1.Name = "button1";
      button1.Size = new Size(94, 29);
      button1.TabIndex = 0;
      button1.Text = "button1";
      button1.UseVisualStyleBackColor = true;
      button1.Click += button1_Click;
      // 
      // textBox1
      // 
      textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      textBox1.BackColor = SystemColors.Highlight;
      textBox1.Location = new Point(112, 14);
      textBox1.Name = "textBox1";
      textBox1.Size = new Size(311, 27);
      textBox1.TabIndex = 1;
      // 
      // panel1
      // 
      panel1.BackColor = SystemColors.ActiveCaption;
      panel1.Location = new Point(349, 138);
      panel1.Name = "panel1";
      panel1.Size = new Size(319, 198);
      panel1.TabIndex = 2;
      panel1.Paint += panel1_Paint;
      // 
      // button2
      // 
      button2.Location = new Point(12, 49);
      button2.Name = "button2";
      button2.Size = new Size(94, 29);
      button2.TabIndex = 3;
      button2.Text = "button2";
      button2.UseVisualStyleBackColor = true;
      button2.Click += button2_Click;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(button2);
      Controls.Add(panel1);
      Controls.Add(textBox1);
      Controls.Add(button1);
      Name = "Form1";
      Text = "Form1";
      Resize += Form1_Resize;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button button1;
    private TextBox textBox1;
    private System.Windows.Forms.Timer timer1;
    private Panel panel1;
    private Button button2;
  }
}