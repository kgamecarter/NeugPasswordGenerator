namespace NeugPasswordGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbCom = new System.Windows.Forms.TextBox();
            this.btnToggle = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbLength = new System.Windows.Forms.TrackBar();
            this.lbLength = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbLength)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "PASS";
            // 
            // tbResult
            // 
            this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResult.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResult.Location = new System.Drawing.Point(51, 12);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(736, 22);
            this.tbResult.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(119, 40);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // tbCom
            // 
            this.tbCom.Location = new System.Drawing.Point(13, 40);
            this.tbCom.Name = "tbCom";
            this.tbCom.Size = new System.Drawing.Size(100, 22);
            this.tbCom.TabIndex = 3;
            this.tbCom.Text = "COM5";
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(200, 40);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(75, 23);
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
            this.tbLength.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLength.Location = new System.Drawing.Point(310, 40);
            this.tbLength.Maximum = 100;
            this.tbLength.Minimum = 1;
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(477, 45);
            this.tbLength.TabIndex = 5;
            this.tbLength.Value = 100;
            this.tbLength.Scroll += new System.EventHandler(this.TbLength_Scroll);
            // 
            // lbLength
            // 
            this.lbLength.AutoSize = true;
            this.lbLength.Location = new System.Drawing.Point(281, 50);
            this.lbLength.Name = "lbLength";
            this.lbLength.Size = new System.Drawing.Size(23, 12);
            this.lbLength.TabIndex = 6;
            this.lbLength.Text = "100";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 84);
            this.Controls.Add(this.lbLength);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.tbCom);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Neug Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.tbLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbCom;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbLength;
        private System.Windows.Forms.Label lbLength;
    }
}

