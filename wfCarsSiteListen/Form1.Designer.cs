
namespace wfCarsSiteListen
{
    partial class FrmWebSiteListener
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
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnToJson = new System.Windows.Forms.Button();
            this.btnListen = new System.Windows.Forms.Button();
            this.txtWebUrl = new System.Windows.Forms.TextBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.gbContent = new System.Windows.Forms.GroupBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlFooter.SuspendLayout();
            this.gbContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnClear);
            this.pnlFooter.Controls.Add(this.btnToJson);
            this.pnlFooter.Controls.Add(this.btnListen);
            this.pnlFooter.Controls.Add(this.txtWebUrl);
            this.pnlFooter.Controls.Add(this.lblSite);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 547);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1016, 60);
            this.pnlFooter.TabIndex = 0;
            // 
            // btnToJson
            // 
            this.btnToJson.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnToJson.Location = new System.Drawing.Point(663, 18);
            this.btnToJson.Name = "btnToJson";
            this.btnToJson.Size = new System.Drawing.Size(90, 23);
            this.btnToJson.TabIndex = 3;
            this.btnToJson.Text = "To Json";
            this.btnToJson.UseVisualStyleBackColor = true;
            this.btnToJson.Click += new System.EventHandler(this.btnToJson_Click);
            // 
            // btnListen
            // 
            this.btnListen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListen.Location = new System.Drawing.Point(553, 18);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(87, 23);
            this.btnListen.TabIndex = 2;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // txtWebUrl
            // 
            this.txtWebUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtWebUrl.Location = new System.Drawing.Point(82, 18);
            this.txtWebUrl.Name = "txtWebUrl";
            this.txtWebUrl.Size = new System.Drawing.Size(459, 23);
            this.txtWebUrl.TabIndex = 1;
            this.txtWebUrl.Text = "www.cars.com";
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSite.Location = new System.Drawing.Point(13, 21);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(64, 15);
            this.lblSite.TabIndex = 0;
            this.lblSite.Text = "Web Site :";
            // 
            // gbContent
            // 
            this.gbContent.Controls.Add(this.txtContent);
            this.gbContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbContent.Location = new System.Drawing.Point(0, 0);
            this.gbContent.Name = "gbContent";
            this.gbContent.Size = new System.Drawing.Size(1016, 547);
            this.gbContent.TabIndex = 1;
            this.gbContent.TabStop = false;
            this.gbContent.Text = "Web Content";
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Location = new System.Drawing.Point(3, 19);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(1010, 525);
            this.txtContent.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(771, 18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmWebSiteListener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 607);
            this.Controls.Add(this.gbContent);
            this.Controls.Add(this.pnlFooter);
            this.Name = "FrmWebSiteListener";
            this.Text = "Web Site Listener";
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.gbContent.ResumeLayout(false);
            this.gbContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.TextBox txtWebUrl;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.GroupBox gbContent;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnToJson;
        private System.Windows.Forms.Button btnClear;
    }
}

