namespace UrlTransfer
{
    partial class TransferForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferForm));
            this.txtSourceUrl = new System.Windows.Forms.TextBox();
            this.txtThunderUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTrans = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDecodeUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFlashgetUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQQDLUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSourceUrl
            // 
            this.txtSourceUrl.Location = new System.Drawing.Point(78, 24);
            this.txtSourceUrl.Multiline = true;
            this.txtSourceUrl.Name = "txtSourceUrl";
            this.txtSourceUrl.Size = new System.Drawing.Size(340, 52);
            this.txtSourceUrl.TabIndex = 0;
            // 
            // txtThunderUrl
            // 
            this.txtThunderUrl.Location = new System.Drawing.Point(78, 141);
            this.txtThunderUrl.Multiline = true;
            this.txtThunderUrl.Name = "txtThunderUrl";
            this.txtThunderUrl.ReadOnly = true;
            this.txtThunderUrl.Size = new System.Drawing.Size(340, 51);
            this.txtThunderUrl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "源Url:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "迅雷Url:";
            // 
            // btnTrans
            // 
            this.btnTrans.Location = new System.Drawing.Point(162, 316);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(75, 23);
            this.btnTrans.TabIndex = 4;
            this.btnTrans.Text = "转换";
            this.btnTrans.UseVisualStyleBackColor = true;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "原始Url:";
            // 
            // txtDecodeUrl
            // 
            this.txtDecodeUrl.Location = new System.Drawing.Point(78, 84);
            this.txtDecodeUrl.Multiline = true;
            this.txtDecodeUrl.Name = "txtDecodeUrl";
            this.txtDecodeUrl.ReadOnly = true;
            this.txtDecodeUrl.Size = new System.Drawing.Size(340, 51);
            this.txtDecodeUrl.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "快车Url:";
            // 
            // txtFlashgetUrl
            // 
            this.txtFlashgetUrl.Location = new System.Drawing.Point(78, 198);
            this.txtFlashgetUrl.Multiline = true;
            this.txtFlashgetUrl.Name = "txtFlashgetUrl";
            this.txtFlashgetUrl.ReadOnly = true;
            this.txtFlashgetUrl.Size = new System.Drawing.Size(340, 51);
            this.txtFlashgetUrl.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "QQ旋风Url:";
            // 
            // txtQQDLUrl
            // 
            this.txtQQDLUrl.Location = new System.Drawing.Point(78, 259);
            this.txtQQDLUrl.Multiline = true;
            this.txtQQDLUrl.Name = "txtQQDLUrl";
            this.txtQQDLUrl.ReadOnly = true;
            this.txtQQDLUrl.Size = new System.Drawing.Size(340, 51);
            this.txtQQDLUrl.TabIndex = 9;
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 351);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQQDLUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFlashgetUrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDecodeUrl);
            this.Controls.Add(this.btnTrans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtThunderUrl);
            this.Controls.Add(this.txtSourceUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TransferForm";
            this.Text = "Url转换工具(支持迅雷、快车、QQ旋风互相转换)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSourceUrl;
        private System.Windows.Forms.TextBox txtThunderUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDecodeUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFlashgetUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQQDLUrl;
    }
}

