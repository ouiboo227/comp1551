namespace Coursework
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox stringInput;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Label notification;
        private System.Windows.Forms.Label EncodeResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.Button print1Button;
        private System.Windows.Forms.Button print2Button;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label stringInputLabel;
        private System.Windows.Forms.Label numberInputLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.stringInput = new System.Windows.Forms.TextBox();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.notification = new System.Windows.Forms.Label();
            this.EncodeResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.print1Button = new System.Windows.Forms.Button();
            this.print2Button = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.stringInputLabel = new System.Windows.Forms.Label();
            this.numberInputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stringInput
            // 
            this.stringInput.Location = new System.Drawing.Point(173, 100);
            this.stringInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stringInput.Name = "stringInput";
            this.stringInput.Size = new System.Drawing.Size(333, 26);
            this.stringInput.TabIndex = 3;
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(529, 100);
            this.numberInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(151, 26);
            this.numberInput.TabIndex = 4;
            // 
            // notification
            // 
            this.notification.AutoSize = true;
            this.notification.Location = new System.Drawing.Point(169, 138);
            this.notification.Name = "notification";
            this.notification.Size = new System.Drawing.Size(0, 20);
            this.notification.TabIndex = 5;
            // 
            // EncodeResult
            // 
            this.EncodeResult.AutoSize = true;
            this.EncodeResult.Location = new System.Drawing.Point(169, 275);
            this.EncodeResult.Name = "EncodeResult";
            this.EncodeResult.Size = new System.Drawing.Size(59, 20);
            this.EncodeResult.TabIndex = 6;
            this.EncodeResult.Text = "Result:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 188);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Validate";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EncodeButton
            // 
            this.EncodeButton.Location = new System.Drawing.Point(264, 188);
            this.EncodeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(84, 29);
            this.EncodeButton.TabIndex = 8;
            this.EncodeButton.Text = "Encode";
            this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // print1Button
            // 
            this.print1Button.Location = new System.Drawing.Point(360, 188);
            this.print1Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.print1Button.Name = "print1Button";
            this.print1Button.Size = new System.Drawing.Size(112, 29);
            this.print1Button.TabIndex = 9;
            this.print1Button.Text = "Print Input";
            this.print1Button.Click += new System.EventHandler(this.print1Button_Click);
            // 
            // print2Button
            // 
            this.print2Button.Location = new System.Drawing.Point(478, 188);
            this.print2Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.print2Button.Name = "print2Button";
            this.print2Button.Size = new System.Drawing.Size(112, 29);
            this.print2Button.TabIndex = 10;
            this.print2Button.Text = "Print Output";
            this.print2Button.Click += new System.EventHandler(this.print2Button_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(596, 188);
            this.SortButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(84, 29);
            this.SortButton.TabIndex = 11;
            this.SortButton.Text = "Sort";
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(315, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(265, 45);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "String Processor";
            // 
            // stringInputLabel
            // 
            this.stringInputLabel.AutoSize = true;
            this.stringInputLabel.Location = new System.Drawing.Point(169, 76);
            this.stringInputLabel.Name = "stringInputLabel";
            this.stringInputLabel.Size = new System.Drawing.Size(96, 20);
            this.stringInputLabel.TabIndex = 1;
            this.stringInputLabel.Text = "Input String:";
            // 
            // numberInputLabel
            // 
            this.numberInputLabel.AutoSize = true;
            this.numberInputLabel.Location = new System.Drawing.Point(525, 76);
            this.numberInputLabel.Name = "numberInputLabel";
            this.numberInputLabel.Size = new System.Drawing.Size(131, 20);
            this.numberInputLabel.TabIndex = 2;
            this.numberInputLabel.Text = "Shift Amount (N):";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 438);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.stringInputLabel);
            this.Controls.Add(this.numberInputLabel);
            this.Controls.Add(this.stringInput);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.notification);
            this.Controls.Add(this.EncodeResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EncodeButton);
            this.Controls.Add(this.print1Button);
            this.Controls.Add(this.print2Button);
            this.Controls.Add(this.SortButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "String Processor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}