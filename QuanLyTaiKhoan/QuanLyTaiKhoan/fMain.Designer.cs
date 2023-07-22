namespace QuanLyTaiKhoan
{
    partial class fMain
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnWd = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCN = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(6, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(181, 58);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "In danh sách khách hàng";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(193, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(199, 58);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Lập phiếu gửi tiền";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnWd
            // 
            this.btnWd.Location = new System.Drawing.Point(6, 67);
            this.btnWd.Name = "btnWd";
            this.btnWd.Size = new System.Drawing.Size(181, 58);
            this.btnWd.TabIndex = 2;
            this.btnWd.Text = "Lập phiếu rút tiền";
            this.btnWd.UseVisualStyleBackColor = true;
            this.btnWd.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(193, 67);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(199, 58);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Lập phiếu report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnWd);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Location = new System.Drawing.Point(6, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 130);
            this.panel1.TabIndex = 4;
            // 
            // lbCN
            // 
            this.lbCN.AutoSize = true;
            this.lbCN.Location = new System.Drawing.Point(9, 144);
            this.lbCN.Name = "lbCN";
            this.lbCN.Size = new System.Drawing.Size(38, 17);
            this.lbCN.TabIndex = 5;
            this.lbCN.Text = "lbCN";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 186);
            this.Controls.Add(this.lbCN);
            this.Controls.Add(this.panel1);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình chính";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnWd;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCN;
    }
}