namespace Technical_Equipment_Supplier
{
    partial class FrmHomeScreen
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
            this.btnNewRequest = new System.Windows.Forms.Button();
            this.btnRequestList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Technical Equipment Supplier";
            // 
            // btnNewRequest
            // 
            this.btnNewRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRequest.Location = new System.Drawing.Point(12, 95);
            this.btnNewRequest.Name = "btnNewRequest";
            this.btnNewRequest.Size = new System.Drawing.Size(159, 56);
            this.btnNewRequest.TabIndex = 1;
            this.btnNewRequest.Text = "Novi zahtjev";
            this.btnNewRequest.UseVisualStyleBackColor = true;
            this.btnNewRequest.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRequestList
            // 
            this.btnRequestList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestList.Location = new System.Drawing.Point(12, 168);
            this.btnRequestList.Name = "btnRequestList";
            this.btnRequestList.Size = new System.Drawing.Size(159, 56);
            this.btnRequestList.TabIndex = 2;
            this.btnRequestList.Text = "Popis zahtjeva";
            this.btnRequestList.UseVisualStyleBackColor = true;
            // 
            // FrmHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRequestList);
            this.Controls.Add(this.btnNewRequest);
            this.Controls.Add(this.label1);
            this.Name = "FrmHomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHomeScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewRequest;
        private System.Windows.Forms.Button btnRequestList;
    }
}