namespace SourceControlTest
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
            btnWarning = new Button();
            lblClickMe = new Label();
            SuspendLayout();
            // 
            // btnWarning
            // 
            btnWarning.Location = new Point(341, 163);
            btnWarning.Name = "btnWarning";
            btnWarning.Size = new Size(129, 84);
            btnWarning.TabIndex = 0;
            btnWarning.Text = "Don't Click Me!";
            btnWarning.UseVisualStyleBackColor = true;
            btnWarning.Click += BtnWarning_Click;
            // 
            // lblClickMe
            // 
            lblClickMe.AutoSize = true;
            lblClickMe.Location = new Point(256, 163);
            lblClickMe.Name = "lblClickMe";
            lblClickMe.Size = new Size(56, 15);
            lblClickMe.TabIndex = 1;
            lblClickMe.Text = "Click Me!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblClickMe);
            Controls.Add(btnWarning);
            Name = "Form1";
            Text = "Misleading Button";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWarning;
        private Label lblClickMe;
    }
}
