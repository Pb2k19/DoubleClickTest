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
            TestButton = new System.Windows.Forms.Button();
            OutputTextBox = new System.Windows.Forms.TextBox();
            ResetButton = new System.Windows.Forms.Button();
            FastestClickLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // CheckStateLabel
            // 
            CheckStateLabel.AutoSize = true;
            CheckStateLabel.Location = new System.Drawing.Point(14, 18);
            CheckStateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CheckStateLabel.Name = "CheckStateLabel";
            CheckStateLabel.Size = new System.Drawing.Size(23, 15);
            CheckStateLabel.TabIndex = 0;
            CheckStateLabel.Text = "OK";
            // 
            // ClickCountLabel
            // 
            ClickCountLabel.AutoSize = true;
            ClickCountLabel.Location = new System.Drawing.Point(253, 18);
            ClickCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ClickCountLabel.Name = "ClickCountLabel";
            ClickCountLabel.Size = new System.Drawing.Size(13, 15);
            ClickCountLabel.TabIndex = 1;
            ClickCountLabel.Text = "0";
            // 
            // ErrorClickCountLabel
            // 
            ErrorClickCountLabel.AutoSize = true;
            ErrorClickCountLabel.Location = new System.Drawing.Point(77, 18);
            ErrorClickCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ErrorClickCountLabel.Name = "ErrorClickCountLabel";
            ErrorClickCountLabel.Size = new System.Drawing.Size(13, 15);
            ErrorClickCountLabel.TabIndex = 2;
            ErrorClickCountLabel.Text = "0";
            // 
            // ElapsedMsLabel
            // 
            ElapsedMsLabel.AutoSize = true;
            ElapsedMsLabel.Location = new System.Drawing.Point(160, 18);
            ElapsedMsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ElapsedMsLabel.Name = "ElapsedMsLabel";
            ElapsedMsLabel.Size = new System.Drawing.Size(13, 15);
            ElapsedMsLabel.TabIndex = 3;
            ElapsedMsLabel.Text = "0";
            // 
            // TestButton
            // 
            TestButton.Location = new System.Drawing.Point(18, 37);
            TestButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TestButton.Name = "TestButton";
            TestButton.Size = new System.Drawing.Size(710, 241);
            TestButton.TabIndex = 4;
            TestButton.Text = "Click";
            TestButton.UseVisualStyleBackColor = false;
            TestButton.MouseDown += Button1_MouseDown;
            // 
            // OutputTextBox
            // 
            OutputTextBox.Location = new System.Drawing.Point(18, 286);
            OutputTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            OutputTextBox.Multiline = true;
            OutputTextBox.Name = "OutputTextBox";
            OutputTextBox.ReadOnly = true;
            OutputTextBox.Size = new System.Drawing.Size(710, 169);
            OutputTextBox.TabIndex = 5;
            // 
            // ResetButton
            // 
            ResetButton.Location = new System.Drawing.Point(572, 12);
            ResetButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new System.Drawing.Size(145, 22);
            ResetButton.TabIndex = 6;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += Reset_Click;
            // 
            // FastestClickLabel
            // 
            FastestClickLabel.AutoSize = true;
            FastestClickLabel.Location = new System.Drawing.Point(480, 16);
            FastestClickLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            FastestClickLabel.Name = "FastestClickLabel";
            FastestClickLabel.Size = new System.Drawing.Size(13, 15);
            FastestClickLabel.TabIndex = 7;
            FastestClickLabel.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 3);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(33, 15);
            label1.TabIndex = 8;
            label1.Text = "State";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(77, 3);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(66, 15);
            label2.TabIndex = 9;
            label2.Text = "Error count";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(160, 3);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 15);
            label3.TabIndex = 10;
            label3.Text = "Elapsed Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(253, 3);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(67, 15);
            label4.TabIndex = 11;
            label4.Text = "Click count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(480, 3);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(70, 15);
            label5.TabIndex = 12;
            label5.Text = "Fastest click";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(742, 470);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FastestClickLabel);
            Controls.Add(ResetButton);
            Controls.Add(OutputTextBox);
            Controls.Add(TestButton);
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
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label FastestClickLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

