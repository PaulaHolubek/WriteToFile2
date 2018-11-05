namespace WritetoFile2
{
    partial class Form1
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
            this.tbResults = new System.Windows.Forms.TextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnWriteData = new System.Windows.Forms.Button();
            this.btnReadData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbResults
            // 
            this.tbResults.Location = new System.Drawing.Point(93, 65);
            this.tbResults.Multiline = true;
            this.tbResults.Name = "tbResults";
            this.tbResults.Size = new System.Drawing.Size(615, 122);
            this.tbResults.TabIndex = 0;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(89, 42);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(70, 20);
            this.lblResults.TabIndex = 1;
            this.lblResults.Text = "Results";
            // 
            // btnWriteData
            // 
            this.btnWriteData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteData.Location = new System.Drawing.Point(208, 211);
            this.btnWriteData.Name = "btnWriteData";
            this.btnWriteData.Size = new System.Drawing.Size(133, 50);
            this.btnWriteData.TabIndex = 2;
            this.btnWriteData.Text = "Write Data To File";
            this.btnWriteData.UseVisualStyleBackColor = true;
            this.btnWriteData.Click += new System.EventHandler(this.btnWriteData_Click);
            // 
            // btnReadData
            // 
            this.btnReadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadData.Location = new System.Drawing.Point(439, 211);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(133, 50);
            this.btnReadData.TabIndex = 3;
            this.btnReadData.Text = "Read File";
            this.btnReadData.UseVisualStyleBackColor = true;
            this.btnReadData.Click += new System.EventHandler(this.btnReadData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReadData);
            this.Controls.Add(this.btnWriteData);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.tbResults);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResults;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnWriteData;
        private System.Windows.Forms.Button btnReadData;
    }
}

