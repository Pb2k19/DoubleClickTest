namespace DoubleClickTest
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            CheckStateLabel = new System.Windows.Forms.Label();
            ClickCountLabel = new System.Windows.Forms.Label();
            ErrorClickCountLabel = new System.Windows.Forms.Label();
            ElapsedMsLabel = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            reset = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // CheckStateLabel
            // 
            CheckStateLabel.AutoSize = true;
            CheckStateLabel.Location = new System.Drawing.Point(14, 18);
            CheckStateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CheckStateLabel.Name = "CheckStateLabel";
            CheckStateLabel.Size = new System.Drawing.Size(38, 15);
            CheckStateLabel.TabIndex = 0;
            CheckStateLabel.Text = "label1";
            // 
            // ClickCountLabel
            // 
            ClickCountLabel.AutoSize = true;
            ClickCountLabel.Location = new System.Drawing.Point(219, 18);
            ClickCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ClickCountLabel.Name = "ClickCountLabel";
            ClickCountLabel.Size = new System.Drawing.Size(38, 15);
            ClickCountLabel.TabIndex = 1;
            ClickCountLabel.Text = "label2";
            // 
            // ErrorClickCountLabel
            // 
            ErrorClickCountLabel.AutoSize = true;
            ErrorClickCountLabel.Location = new System.Drawing.Point(77, 18);
            ErrorClickCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ErrorClickCountLabel.Name = "ErrorClickCountLabel";
            ErrorClickCountLabel.Size = new System.Drawing.Size(38, 15);
            ErrorClickCountLabel.TabIndex = 2;
            ErrorClickCountLabel.Text = "label3";
            // 
            // ElapsedMsLabel
            // 
            ElapsedMsLabel.AutoSize = true;
            ElapsedMsLabel.Location = new System.Drawing.Point(160, 18);
            ElapsedMsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ElapsedMsLabel.Name = "ElapsedMsLabel";
            ElapsedMsLabel.Size = new System.Drawing.Size(38, 15);
            ElapsedMsLabel.TabIndex = 3;
            ElapsedMsLabel.Text = "label3";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(18, 37);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(710, 241);
            button1.TabIndex = 4;
            button1.Text = "Click";
            button1.UseVisualStyleBackColor = false;
            button1.MouseDown += Button1_MouseDown;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(18, 286);
            textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(710, 169);
            textBox1.TabIndex = 5;
            // 
            // reset
            // 
            reset.Location = new System.Drawing.Point(572, 12);
            reset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            reset.Name = "reset";
            reset.Size = new System.Drawing.Size(145, 22);
            reset.TabIndex = 6;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += Reset_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(497, 15);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 15);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(742, 470);
            Controls.Add(label2);
            Controls.Add(reset);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(ElapsedMsLabel);
            Controls.Add(ErrorClickCountLabel);
            Controls.Add(ClickCountLabel);
            Controls.Add(CheckStateLabel);
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "DoubleClickTest";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label CheckStateLabel;
        private System.Windows.Forms.Label ClickCountLabel;
        private System.Windows.Forms.Label ErrorClickCountLabel;
        private System.Windows.Forms.Label ElapsedMsLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label2;
    }
}

