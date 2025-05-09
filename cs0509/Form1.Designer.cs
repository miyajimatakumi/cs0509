namespace cs0509
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
            buttonproperty = new Button();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // buttonproperty
            // 
            buttonproperty.BackColor = Color.FromArgb(255, 192, 192);
            buttonproperty.Font = new Font("Yu Gothic UI", 25F);
            buttonproperty.ForeColor = Color.Blue;
            buttonproperty.Location = new Point(41, 21);
            buttonproperty.Name = "buttonproperty";
            buttonproperty.Size = new Size(273, 134);
            buttonproperty.TabIndex = 0;
            buttonproperty.Text = "ボタン";
            buttonproperty.TextAlign = ContentAlignment.TopLeft;
            buttonproperty.UseVisualStyleBackColor = false;
            buttonproperty.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(41, 161);
            button1.Name = "button1";
            button1.Size = new Size(131, 51);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 20F);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(350, 190);
            label1.Name = "label1";
            label1.Size = new Size(69, 37);
            label1.TabIndex = 2;
            label1.Text = "^p^";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(498, 295);
            button2.Name = "button2";
            button2.Size = new Size(51, 48);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(555, 253);
            button3.Name = "button3";
            button3.Size = new Size(51, 48);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(612, 295);
            button4.Name = "button4";
            button4.Size = new Size(51, 48);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(555, 341);
            button5.Name = "button5";
            button5.Size = new Size(51, 48);
            button5.TabIndex = 6;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(buttonproperty);
            Name = "Form1";
            Text = "form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonproperty;
        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
