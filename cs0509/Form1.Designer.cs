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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonproperty);
            Name = "Form1";
            Text = "form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonproperty;
    }
}
