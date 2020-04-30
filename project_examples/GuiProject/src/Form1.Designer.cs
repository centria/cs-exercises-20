namespace src
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Text = "Hello World Application";

      this.textBox1 = new System.Windows.Forms.TextBox();

      this.textBox1.Text = "Hello World";
      this.textBox1.ReadOnly = true;
      this.textBox1.Location = new System.Drawing.Point((this.Width - this.textBox1.Width) / 2, (this.Height - this.textBox1.Height) / 2);
      this.Controls.Add(this.textBox1);

      this.button1 = new System.Windows.Forms.Button();
      this.button1.Text = "Click me!";
      this.button1.Click += new System.EventHandler(ShowMessage);
      Controls.Add(this.button1);

      this.button2 = new System.Windows.Forms.Button();
      this.button2.Text = "Click me instead!";
      this.button2.AutoSize = true;
      this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
      this.button2.Location = new System.Drawing.Point(this.button1.Width + 5, 0);
      this.button2.Click += new System.EventHandler(ShowMessage);
      Controls.Add(this.button2);


    }
    private void ShowMessage(object sender, System.EventArgs e)
    {
      string buttonName = (sender as System.Windows.Forms.Button).Text;
      if (buttonName == "Click me!")
      {
        this.textBox1.Text = "Button Clicked!";
      }
      else
      {
        this.textBox1.Text = "Other Button Clicked!";
      }

    }

  }
}

