
namespace CandFConverter
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnComputeF = new System.Windows.Forms.Button();
            this.btnComputeC = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(54, 68);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(293, 46);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Enter a number";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(421, 68);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(281, 53);
            this.txtNumber.TabIndex = 1;
            // 
            // btnComputeF
            // 
            this.btnComputeF.Location = new System.Drawing.Point(45, 186);
            this.btnComputeF.Name = "btnComputeF";
            this.btnComputeF.Size = new System.Drawing.Size(287, 120);
            this.btnComputeF.TabIndex = 2;
            this.btnComputeF.Text = "Compute to F";
            this.btnComputeF.UseVisualStyleBackColor = true;
            this.btnComputeF.Click += new System.EventHandler(this.btnComputeF_Click);
            // 
            // btnComputeC
            // 
            this.btnComputeC.Location = new System.Drawing.Point(444, 183);
            this.btnComputeC.Name = "btnComputeC";
            this.btnComputeC.Size = new System.Drawing.Size(334, 122);
            this.btnComputeC.TabIndex = 3;
            this.btnComputeC.Text = "Compute to C";
            this.btnComputeC.UseVisualStyleBackColor = true;
            this.btnComputeC.Click += new System.EventHandler(this.btnComputeC_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(63, 369);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(2, 48);
            this.lblResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 505);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnComputeC);
            this.Controls.Add(this.btnComputeF);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnComputeF;
        private System.Windows.Forms.Button btnComputeC;
        private System.Windows.Forms.Label lblResult;
    }
}

