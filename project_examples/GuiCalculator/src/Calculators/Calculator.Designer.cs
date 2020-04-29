namespace GuiCalculator
{
  partial class Calculator
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
      this.ClientSize = new System.Drawing.Size(300, 300);
      // Text at the top
      this.Text = "Calculator";

      // Button sizes
      int buttonWidth = 60;
      int buttonHeight = 60;

      // Results box
      this.results.Text = "0";
      this.results.Font = new System.Drawing.Font("Arial", 30);
      this.results.Width = 300;
      // Move text to right side
      this.results.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.results.ReadOnly = true;
      this.results.Location = new System.Drawing.Point(0, 0);

      // Define button 7, top-left
      this.button7.Location = new System.Drawing.Point(0, buttonHeight);
      this.button7.Font = new System.Drawing.Font("Arial", 20);
      this.button7.Height = buttonHeight;
      this.button7.Width = buttonWidth;
      this.button7.Text = "7";
      this.button7.Click += new System.EventHandler(AddToString);

      // Define button 8
      this.button8.Location = new System.Drawing.Point(buttonWidth, buttonHeight);
      this.button8.Font = new System.Drawing.Font("Arial", 20);
      this.button8.Height = buttonHeight;
      this.button8.Width = buttonWidth;
      this.button8.Text = "8";
      this.button8.Click += new System.EventHandler(AddToString);

      // Define button 9
      this.button9.Location = new System.Drawing.Point(buttonWidth * 2, buttonHeight);
      this.button9.Font = new System.Drawing.Font("Arial", 20);
      this.button9.Height = buttonHeight;
      this.button9.Width = buttonWidth;
      this.button9.Text = "9";
      this.button9.Click += new System.EventHandler(AddToString);

      // Next row numbers
      this.button4.Location = new System.Drawing.Point(0, buttonHeight * 2);
      this.button4.Font = new System.Drawing.Font("Arial", 20);
      this.button4.Height = buttonHeight;
      this.button4.Width = buttonWidth;
      this.button4.Text = "4";
      this.button4.Click += new System.EventHandler(AddToString);

      this.button5.Location = new System.Drawing.Point(buttonWidth, buttonHeight * 2);
      this.button5.Font = new System.Drawing.Font("Arial", 20);
      this.button5.Height = buttonHeight;
      this.button5.Width = buttonWidth;
      this.button5.Text = "5";
      this.button5.Click += new System.EventHandler(AddToString);

      this.button6.Location = new System.Drawing.Point(buttonWidth * 2, buttonHeight * 2);
      this.button6.Font = new System.Drawing.Font("Arial", 20);
      this.button6.Height = buttonHeight;
      this.button6.Width = buttonWidth;
      this.button6.Text = "6";
      this.button6.Click += new System.EventHandler(AddToString);

      // Next row numbers
      this.button1.Location = new System.Drawing.Point(0, buttonHeight * 3);
      this.button1.Font = new System.Drawing.Font("Arial", 20);
      this.button1.Height = buttonHeight;
      this.button1.Width = buttonWidth;
      this.button1.Text = "1";
      this.button1.Click += new System.EventHandler(AddToString);

      this.button2.Location = new System.Drawing.Point(buttonWidth, buttonHeight * 3);
      this.button2.Font = new System.Drawing.Font("Arial", 20);
      this.button2.Height = buttonHeight;
      this.button2.Width = buttonWidth;
      this.button2.Text = "2";
      this.button2.Click += new System.EventHandler(AddToString);

      this.button3.Location = new System.Drawing.Point(buttonWidth * 2, buttonHeight * 3);
      this.button3.Font = new System.Drawing.Font("Arial", 20);
      this.button3.Height = buttonHeight;
      this.button3.Width = buttonWidth;
      this.button3.Text = "3";
      this.button3.Click += new System.EventHandler(AddToString);

      // Last row
      this.button0.Location = new System.Drawing.Point(0, buttonHeight * 4);
      this.button0.Font = new System.Drawing.Font("Arial", 20);
      this.button0.Height = buttonHeight;
      this.button0.Width = buttonWidth * 2;
      this.button0.Text = "0";
      this.button0.Click += new System.EventHandler(AddToString);

      this.dec.Location = new System.Drawing.Point(buttonWidth * 2, buttonHeight * 4);
      this.dec.Font = new System.Drawing.Font("Arial", 20);
      this.dec.Height = buttonHeight;
      this.dec.Width = buttonWidth;
      this.dec.Text = ".";
      this.dec.Click += new System.EventHandler(AddToString);


      // Calculation column
      this.divide.Location = new System.Drawing.Point(buttonWidth * 3, buttonHeight);
      this.divide.Font = new System.Drawing.Font("Arial", 20);
      this.divide.Height = buttonHeight;
      this.divide.Width = buttonWidth;
      this.divide.Text = "/";
      this.divide.Click += new System.EventHandler(CalculateResult);

      this.multiply.Location = new System.Drawing.Point(buttonWidth * 3, buttonHeight * 2);
      this.multiply.Font = new System.Drawing.Font("Arial", 20);
      this.multiply.Height = buttonHeight;
      this.multiply.Width = buttonWidth;
      this.multiply.Text = "*";
      this.multiply.Click += new System.EventHandler(CalculateResult);

      this.substract.Location = new System.Drawing.Point(buttonWidth * 3, buttonHeight * 3);
      this.substract.Font = new System.Drawing.Font("Arial", 20);
      this.substract.Height = buttonHeight;
      this.substract.Width = buttonWidth;
      this.substract.Text = "-";
      this.substract.Click += new System.EventHandler(CalculateResult);

      this.add.Location = new System.Drawing.Point(buttonWidth * 3, buttonHeight * 4);
      this.add.Font = new System.Drawing.Font("Arial", 20);
      this.add.Height = buttonHeight;
      this.add.Width = buttonWidth;
      this.add.Text = "+";
      this.add.Click += new System.EventHandler(CalculateResult);

      // Other buttons
      this.zero.Location = new System.Drawing.Point(buttonWidth * 4, buttonHeight);
      this.zero.Font = new System.Drawing.Font("Arial", 20);
      this.zero.Height = buttonHeight * 2;
      this.zero.Width = buttonWidth;
      this.zero.Text = "C";
      this.zero.Click += new System.EventHandler(CalculateResult);

      this.total.Location = new System.Drawing.Point(buttonWidth * 4, buttonHeight * 3);
      this.total.Font = new System.Drawing.Font("Arial", 20);
      this.total.Height = buttonHeight * 2;
      this.total.Width = buttonWidth;
      this.total.Text = "=";
      this.total.Click += new System.EventHandler(CalculateResult);

      // Add all the buttons to the Controls
      this.Controls.Add(this.results);

      this.Controls.Add(button0);
      this.Controls.Add(button1);
      this.Controls.Add(button2);
      this.Controls.Add(button3);
      this.Controls.Add(button4);
      this.Controls.Add(button5);
      this.Controls.Add(button6);
      this.Controls.Add(button7);
      this.Controls.Add(button8);
      this.Controls.Add(button9);

      this.Controls.Add(dec);
      this.Controls.Add(divide);
      this.Controls.Add(multiply);
      this.Controls.Add(substract);
      this.Controls.Add(add);

      this.Controls.Add(zero);
      this.Controls.Add(total);

    }



    private void AddToString(object sender, System.EventArgs e)
    {
      string number = (sender as System.Windows.Forms.Button).Text;
      if ((results.Text.Contains(".") && number == ".") || (results.Text == "0" && number == "."))
      {
        return;
      }
      if (results.Text == "0")
      {
        results.Text = number;
      }
      else
      {
        results.Text += number;
      }
    }

    private void CalculateResult(object sender, System.EventArgs e)
    {
      string operation = (sender as System.Windows.Forms.Button).Text;
      double currentValue = System.Convert.ToDouble(results.Text, System.Globalization.CultureInfo.InvariantCulture);
      if (operation == "C")
      {
        this.accumulator = 0;
      }
      else if (lastOperation == "+")
      {
        accumulator += currentValue;
      }
      else if (lastOperation == "-")
      {
        accumulator -= currentValue;
      }
      else if (lastOperation == "*")
      {
        accumulator *= currentValue;
      }
      else if (lastOperation == "/")
      {
        accumulator /= currentValue;
      }
      else
      {
        accumulator = currentValue;
      }

      lastOperation = operation;

      if (operation == "=")
      {
        results.Text = accumulator.ToString();
      }
      else
      {
        results.Text = "0";
      }
    }
  }
}

