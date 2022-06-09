﻿namespace NeugPasswordGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.components = new System.ComponentModel.Container();
            this.lbAscii85 = new System.Windows.Forms.Label();
            this.tbAscii85 = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbCom = new System.Windows.Forms.TextBox();
            this.btnToggle = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbLength = new System.Windows.Forms.TrackBar();
            this.lbLength = new System.Windows.Forms.Label();
            this.tbBase62 = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.tbHex = new System.Windows.Forms.TextBox();
            this.lbHex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbLength)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAscii85
            // 
            this.lbAscii85.AutoSize = true;
            this.lbAscii85.Location = new System.Drawing.Point(11, 105);
            this.lbAscii85.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAscii85.Name = "lbAscii85";
            this.lbAscii85.Size = new System.Drawing.Size(63, 19);
            this.lbAscii85.TabIndex = 0;
            this.lbAscii85.Text = "Ascii85";
            // 
            // tbAscii85
            // 
            this.tbAscii85.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAscii85.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAscii85.Location = new System.Drawing.Point(71, 100);
            this.tbAscii85.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAscii85.Name = "tbAscii85";
            this.tbAscii85.Size = new System.Drawing.Size(1102, 22);
            this.tbAscii85.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(173, 144);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(112, 37);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // tbCom
            // 
            this.tbCom.Location = new System.Drawing.Point(14, 144);
            this.tbCom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCom.Name = "tbCom";
            this.tbCom.Size = new System.Drawing.Size(148, 26);
            this.tbCom.TabIndex = 3;
            this.tbCom.Text = "COM5";
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(295, 144);
            this.btnToggle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(112, 37);
            this.btnToggle.TabIndex = 4;
            this.btnToggle.Text = "Stop / Start";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.BtnToggle_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // tbLength
            // 
            this.tbLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLength.Location = new System.Drawing.Point(459, 144);
            this.tbLength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLength.Maximum = 150;
            this.tbLength.Minimum = 1;
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(714, 45);
            this.tbLength.TabIndex = 5;
            this.tbLength.Value = 150;
            this.tbLength.Scroll += new System.EventHandler(this.TbLength_Scroll);
            // 
            // lbLength
            // 
            this.lbLength.AutoSize = true;
            this.lbLength.Location = new System.Drawing.Point(416, 160);
            this.lbLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLength.Name = "lbLength";
            this.lbLength.Size = new System.Drawing.Size(39, 19);
            this.lbLength.TabIndex = 6;
            this.lbLength.Text = "150";
            // 
            // tbBase62
            // 
            this.tbBase62.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBase62.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBase62.Location = new System.Drawing.Point(71, 58);
            this.tbBase62.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBase62.Name = "tbBase62";
            this.tbBase62.Size = new System.Drawing.Size(1102, 22);
            this.tbBase62.TabIndex = 8;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(11, 63);
            this.lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(64, 19);
            this.lb.TabIndex = 7;
            this.lb.Text = "Base62";
            // 
            // tbHex
            // 
            this.tbHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHex.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbHex.Location = new System.Drawing.Point(71, 16);
            this.tbHex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbHex.Name = "tbHex";
            this.tbHex.Size = new System.Drawing.Size(1102, 22);
            this.tbHex.TabIndex = 10;
            // 
            // lbHex
            // 
            this.lbHex.AutoSize = true;
            this.lbHex.Location = new System.Drawing.Point(11, 22);
            this.lbHex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHex.Name = "lbHex";
            this.lbHex.Size = new System.Drawing.Size(39, 19);
            this.lbHex.TabIndex = 9;
            this.lbHex.Text = "HEX";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 196);
            this.Controls.Add(this.tbHex);
            this.Controls.Add(this.lbHex);
            this.Controls.Add(this.tbBase62);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lbLength);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.tbCom);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbAscii85);
            this.Controls.Add(this.lbAscii85);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Neug Password Generator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAscii85;
        private System.Windows.Forms.TextBox tbAscii85;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbCom;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbLength;
        private System.Windows.Forms.Label lbLength;
        private System.Windows.Forms.TextBox tbBase62;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox tbHex;
        private System.Windows.Forms.Label lbHex;
    }
}

