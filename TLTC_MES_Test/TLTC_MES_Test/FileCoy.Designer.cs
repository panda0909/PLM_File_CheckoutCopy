namespace TLTC_MES_Test
{
    partial class FileCopy
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFileID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnCopyTo = new System.Windows.Forms.Button();
            this.txtLocalPath = new System.Windows.Forms.TextBox();
            this.btnCopyNet = new System.Windows.Forms.Button();
            this.txtNetPath = new System.Windows.Forms.TextBox();
            this.btnCopyNetAD = new System.Windows.Forms.Button();
            this.txtCheckoutPath = new System.Windows.Forms.TextBox();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.txtPWD = new System.Windows.Forms.TextBox();
            this.txtCheckoutPathAfter = new System.Windows.Forms.TextBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.txtPLMIP = new System.Windows.Forms.TextBox();
            this.txtPLMDB = new System.Windows.Forms.TextBox();
            this.txtPLMAD = new System.Windows.Forms.TextBox();
            this.txtPLMPWD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFileID
            // 
            this.txtFileID.Location = new System.Drawing.Point(62, 23);
            this.txtFileID.Name = "txtFileID";
            this.txtFileID.Size = new System.Drawing.Size(308, 25);
            this.txtFileID.TabIndex = 0;
            this.txtFileID.Text = "F414A95DCA084E47B858F97D6ACEFA76";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "FileID";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(388, 21);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(164, 25);
            this.btnCheckout.TabIndex = 3;
            this.btnCheckout.Text = "checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnCopyTo
            // 
            this.btnCopyTo.Location = new System.Drawing.Point(387, 52);
            this.btnCopyTo.Name = "btnCopyTo";
            this.btnCopyTo.Size = new System.Drawing.Size(164, 25);
            this.btnCopyTo.TabIndex = 4;
            this.btnCopyTo.Text = "copy to";
            this.btnCopyTo.UseVisualStyleBackColor = true;
            this.btnCopyTo.Click += new System.EventHandler(this.btnCopyTo_Click);
            // 
            // txtLocalPath
            // 
            this.txtLocalPath.Location = new System.Drawing.Point(575, 52);
            this.txtLocalPath.Name = "txtLocalPath";
            this.txtLocalPath.Size = new System.Drawing.Size(275, 25);
            this.txtLocalPath.TabIndex = 5;
            this.txtLocalPath.Text = "C:\\Users\\User\\Downloads\\tmp2\\Copy2";
            // 
            // btnCopyNet
            // 
            this.btnCopyNet.Location = new System.Drawing.Point(389, 106);
            this.btnCopyNet.Name = "btnCopyNet";
            this.btnCopyNet.Size = new System.Drawing.Size(163, 25);
            this.btnCopyNet.TabIndex = 6;
            this.btnCopyNet.Text = "copy to network ";
            this.btnCopyNet.UseVisualStyleBackColor = true;
            this.btnCopyNet.Click += new System.EventHandler(this.btnCopyNet_Click);
            // 
            // txtNetPath
            // 
            this.txtNetPath.Location = new System.Drawing.Point(575, 106);
            this.txtNetPath.Name = "txtNetPath";
            this.txtNetPath.Size = new System.Drawing.Size(276, 25);
            this.txtNetPath.TabIndex = 7;
            this.txtNetPath.Text = "\\\\192.168.0.180\\MES_Vault\\Copy3";
            // 
            // btnCopyNetAD
            // 
            this.btnCopyNetAD.Location = new System.Drawing.Point(389, 139);
            this.btnCopyNetAD.Name = "btnCopyNetAD";
            this.btnCopyNetAD.Size = new System.Drawing.Size(163, 25);
            this.btnCopyNetAD.TabIndex = 8;
            this.btnCopyNetAD.Text = "copy to network AD";
            this.btnCopyNetAD.UseVisualStyleBackColor = true;
            this.btnCopyNetAD.Click += new System.EventHandler(this.btnCopyNetAD_Click);
            // 
            // txtCheckoutPath
            // 
            this.txtCheckoutPath.Location = new System.Drawing.Point(575, 21);
            this.txtCheckoutPath.Name = "txtCheckoutPath";
            this.txtCheckoutPath.Size = new System.Drawing.Size(275, 25);
            this.txtCheckoutPath.TabIndex = 9;
            this.txtCheckoutPath.Text = "C:\\Users\\User\\Downloads\\tmp";
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(147, 139);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(223, 25);
            this.txtAD.TabIndex = 10;
            this.txtAD.Text = "administrator";
            // 
            // txtPWD
            // 
            this.txtPWD.Location = new System.Drawing.Point(147, 170);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.Size = new System.Drawing.Size(223, 25);
            this.txtPWD.TabIndex = 11;
            this.txtPWD.Text = "1Qaz2Wsx";
            // 
            // txtCheckoutPathAfter
            // 
            this.txtCheckoutPathAfter.Location = new System.Drawing.Point(116, 56);
            this.txtCheckoutPathAfter.Name = "txtCheckoutPathAfter";
            this.txtCheckoutPathAfter.Size = new System.Drawing.Size(254, 25);
            this.txtCheckoutPathAfter.TabIndex = 12;
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(147, 108);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(223, 25);
            this.txtDomain.TabIndex = 13;
            this.txtDomain.Text = "192.168.0.180";
            // 
            // txtPLMIP
            // 
            this.txtPLMIP.Location = new System.Drawing.Point(79, 296);
            this.txtPLMIP.Name = "txtPLMIP";
            this.txtPLMIP.Size = new System.Drawing.Size(220, 25);
            this.txtPLMIP.TabIndex = 14;
            this.txtPLMIP.Text = "http://192.168.0.200/plm";
            // 
            // txtPLMDB
            // 
            this.txtPLMDB.Location = new System.Drawing.Point(79, 327);
            this.txtPLMDB.Name = "txtPLMDB";
            this.txtPLMDB.Size = new System.Drawing.Size(220, 25);
            this.txtPLMDB.TabIndex = 15;
            this.txtPLMDB.Text = "Panda_NY";
            // 
            // txtPLMAD
            // 
            this.txtPLMAD.Location = new System.Drawing.Point(79, 358);
            this.txtPLMAD.Name = "txtPLMAD";
            this.txtPLMAD.Size = new System.Drawing.Size(220, 25);
            this.txtPLMAD.TabIndex = 16;
            this.txtPLMAD.Text = "admin";
            // 
            // txtPLMPWD
            // 
            this.txtPLMPWD.Location = new System.Drawing.Point(79, 390);
            this.txtPLMPWD.Name = "txtPLMPWD";
            this.txtPLMPWD.Size = new System.Drawing.Size(220, 25);
            this.txtPLMPWD.TabIndex = 17;
            this.txtPLMPWD.Text = "innovator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "PLM IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "PLM DB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "AD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "PWD";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 31);
            this.button1.TabIndex = 22;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Checkout After";
            // 
            // FileCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 431);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPLMPWD);
            this.Controls.Add(this.txtPLMAD);
            this.Controls.Add(this.txtPLMDB);
            this.Controls.Add(this.txtPLMIP);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.txtCheckoutPathAfter);
            this.Controls.Add(this.txtPWD);
            this.Controls.Add(this.txtAD);
            this.Controls.Add(this.txtCheckoutPath);
            this.Controls.Add(this.btnCopyNetAD);
            this.Controls.Add(this.txtNetPath);
            this.Controls.Add(this.btnCopyNet);
            this.Controls.Add(this.txtLocalPath);
            this.Controls.Add(this.btnCopyTo);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileID);
            this.Name = "FileCopy";
            this.Text = "檔案簽出";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnCopyTo;
        private System.Windows.Forms.TextBox txtLocalPath;
        private System.Windows.Forms.Button btnCopyNet;
        private System.Windows.Forms.TextBox txtNetPath;
        private System.Windows.Forms.Button btnCopyNetAD;
        private System.Windows.Forms.TextBox txtCheckoutPath;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.TextBox txtPWD;
        private System.Windows.Forms.TextBox txtCheckoutPathAfter;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.TextBox txtPLMIP;
        private System.Windows.Forms.TextBox txtPLMDB;
        private System.Windows.Forms.TextBox txtPLMAD;
        private System.Windows.Forms.TextBox txtPLMPWD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}

