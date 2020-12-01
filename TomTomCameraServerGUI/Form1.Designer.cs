namespace TomTomCameraServerGUI
{
    partial class btnGetStatus
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
            this.lbLog = new System.Windows.Forms.ListBox();
            this.btnGetVer = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblRevision = new System.Windows.Forms.Label();
            this.lblSupportedVersions = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.ListBox();
            this.btnGetCameraDTcv = new System.Windows.Forms.Button();
            this.btnSetCameraDT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLog
            // 
            this.lbLog.BackColor = System.Drawing.Color.Black;
            this.lbLog.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLog.ForeColor = System.Drawing.Color.Lime;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 18;
            this.lbLog.Location = new System.Drawing.Point(2, 434);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(960, 112);
            this.lbLog.TabIndex = 0;
            // 
            // btnGetVer
            // 
            this.btnGetVer.Location = new System.Drawing.Point(13, 23);
            this.btnGetVer.Name = "btnGetVer";
            this.btnGetVer.Size = new System.Drawing.Size(167, 48);
            this.btnGetVer.TabIndex = 1;
            this.btnGetVer.Text = "Get API Version";
            this.btnGetVer.UseVisualStyleBackColor = true;
            this.btnGetVer.Click += new System.EventHandler(this.btnGetVer_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(13, 78);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 17);
            this.lblVersion.TabIndex = 2;
            // 
            // lblRevision
            // 
            this.lblRevision.AutoSize = true;
            this.lblRevision.Location = new System.Drawing.Point(13, 108);
            this.lblRevision.Name = "lblRevision";
            this.lblRevision.Size = new System.Drawing.Size(0, 17);
            this.lblRevision.TabIndex = 3;
            // 
            // lblSupportedVersions
            // 
            this.lblSupportedVersions.AutoSize = true;
            this.lblSupportedVersions.Location = new System.Drawing.Point(13, 136);
            this.lblSupportedVersions.Name = "lblSupportedVersions";
            this.lblSupportedVersions.Size = new System.Drawing.Size(0, 17);
            this.lblSupportedVersions.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Get Status";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.FormattingEnabled = true;
            this.lbStatus.HorizontalScrollbar = true;
            this.lbStatus.ItemHeight = 16;
            this.lbStatus.Location = new System.Drawing.Point(157, 78);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(238, 260);
            this.lbStatus.TabIndex = 6;
            // 
            // btnGetCameraDTcv
            // 
            this.btnGetCameraDTcv.Location = new System.Drawing.Point(363, 24);
            this.btnGetCameraDTcv.Name = "btnGetCameraDTcv";
            this.btnGetCameraDTcv.Size = new System.Drawing.Size(186, 43);
            this.btnGetCameraDTcv.TabIndex = 7;
            this.btnGetCameraDTcv.Text = "Get Camera Date and Time";
            this.btnGetCameraDTcv.UseVisualStyleBackColor = true;
            this.btnGetCameraDTcv.Click += new System.EventHandler(this.btnGetCameraDTcv_Click);
            // 
            // btnSetCameraDT
            // 
            this.btnSetCameraDT.Location = new System.Drawing.Point(401, 73);
            this.btnSetCameraDT.Name = "btnSetCameraDT";
            this.btnSetCameraDT.Size = new System.Drawing.Size(186, 43);
            this.btnSetCameraDT.TabIndex = 8;
            this.btnSetCameraDT.Text = "Set Camera Date and Time";
            this.btnSetCameraDT.UseVisualStyleBackColor = true;
            this.btnSetCameraDT.Click += new System.EventHandler(this.btnSetCameraDT_Click);
            // 
            // btnGetStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 562);
            this.Controls.Add(this.btnSetCameraDT);
            this.Controls.Add(this.btnGetCameraDTcv);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSupportedVersions);
            this.Controls.Add(this.lblRevision);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnGetVer);
            this.Controls.Add(this.lbLog);
            this.Name = "btnGetStatus";
            this.Text = "TomTom Camera Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Button btnGetVer;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblRevision;
        private System.Windows.Forms.Label lblSupportedVersions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbStatus;
        private System.Windows.Forms.Button btnGetCameraDTcv;
        private System.Windows.Forms.Button btnSetCameraDT;
    }
}

