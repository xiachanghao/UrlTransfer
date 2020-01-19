using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UrlTransfer
{
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSourceUrl.Text))
            {
                MessageBox.Show("请输入原始Url");
                return;
            }

            string fun = "";
            try
            {
                string sourceUrl = txtSourceUrl.Text;
                int headIndex = sourceUrl.IndexOf(":");
                string head = sourceUrl.Substring(0, headIndex);

                switch (head.ToLower())
                {
                    case "thunder":
                        fun = "迅雷";
                        txtDecodeUrl.Text = Transfers.DecodingThunderUrl(sourceUrl);
                        break;
                    case "flashget":
                        fun = "快车";
                        txtDecodeUrl.Text = Transfers.DecodingFlashgetUrl(sourceUrl);
                        break;
                    case "qqdl":
                        fun = "QQ旋风";
                        txtDecodeUrl.Text = Transfers.DecodingQQDLUrl(sourceUrl);

                        break;
                    default:
                        txtDecodeUrl.Text = sourceUrl;
                        break;
                }
            }
            catch
            {
                MessageBox.Show(string.Format("请输入一个合法的{0}下载地址!", fun));
                txtDecodeUrl.Text = txtSourceUrl.Text;
                txtThunderUrl.Text = txtFlashgetUrl.Text = txtQQDLUrl.Text = string.Empty;
                return;
            }
            txtThunderUrl.Text = Transfers.EncodingThunderUrl(txtDecodeUrl.Text);
            txtFlashgetUrl.Text = Transfers.EncodingFlashgetUrl(txtDecodeUrl.Text);
            txtQQDLUrl.Text = Transfers.EncodingQQDLUrl(txtDecodeUrl.Text);
        }
    }
}
