namespace BasicCalculator
{
    partial class FrmBasicCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.tbInput1 = new System.Windows.Forms.TextBox();
            this.tbInput2 = new System.Windows.Forms.TextBox();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Calculator";
            // 
            // tbInput1
            // 
            this.tbInput1.BackColor = System.Drawing.Color.Yellow;
            this.tbInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput1.Location = new System.Drawing.Point(29, 121);
            this.tbInput1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbInput1.Name = "tbInput1";
            this.tbInput1.Size = new System.Drawing.Size(572, 53);
            this.tbInput1.TabIndex = 1;
            this.tbInput1.Text = "0";
            // 
            // tbInput2
            // 
            this.tbInput2.BackColor = System.Drawing.Color.Yellow;
            this.tbInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput2.Location = new System.Drawing.Point(29, 299);
            this.tbInput2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbInput2.Name = "tbInput2";
            this.tbInput2.Size = new System.Drawing.Size(572, 53);
            this.tbInput2.TabIndex = 2;
            this.tbInput2.Text = "0";
            // 
            // cbOperation
            // 
            this.cbOperation.BackColor = System.Drawing.Color.White;
            this.cbOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Location = new System.Drawing.Point(224, 210);
            this.cbOperation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(160, 54);
            this.cbOperation.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(208, 425);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Compute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmBasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(655, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbOperation);
            this.Controls.Add(this.tbInput2);
            this.Controls.Add(this.tbInput1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBasicCalculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmBasicCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInput1;
        private System.Windows.Forms.TextBox tbInput2;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.Button button1;
    }
}

