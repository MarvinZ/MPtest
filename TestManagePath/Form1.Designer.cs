namespace TestManagePath
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
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.btn_CallService = new System.Windows.Forms.Button();
            this.btnCustomWay = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtRequest
            // 
            this.txtRequest.Location = new System.Drawing.Point(12, 98);
            this.txtRequest.Multiline = true;
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Size = new System.Drawing.Size(481, 381);
            this.txtRequest.TabIndex = 0;
            this.txtRequest.Text = "<DGTicketRequest Version=\"1\" Identifier=\"b39ce249-febb-499e-9616-6b0c0854ed98\" Au" +
    "thKey=\"MY_AUTH_KEY\" ApiKey=\"MY_KEY\" IncrementalBatchStartDate=\"03/20/2018 12:50:" +
    "55 PM\"/>\r\n";
            // 
            // btn_CallService
            // 
            this.btn_CallService.Location = new System.Drawing.Point(12, 69);
            this.btn_CallService.Name = "btn_CallService";
            this.btn_CallService.Size = new System.Drawing.Size(103, 23);
            this.btn_CallService.TabIndex = 1;
            this.btn_CallService.Text = "Native";
            this.btn_CallService.UseVisualStyleBackColor = true;
            this.btn_CallService.Click += new System.EventHandler(this.btn_CallService_Click);
            // 
            // btnCustomWay
            // 
            this.btnCustomWay.Location = new System.Drawing.Point(189, 69);
            this.btnCustomWay.Name = "btnCustomWay";
            this.btnCustomWay.Size = new System.Drawing.Size(103, 23);
            this.btnCustomWay.TabIndex = 3;
            this.btnCustomWay.Text = "Custom";
            this.btnCustomWay.UseVisualStyleBackColor = true;
            this.btnCustomWay.Click += new System.EventHandler(this.btnCustomWay_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(517, 98);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(481, 381);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 528);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnCustomWay);
            this.Controls.Add(this.btn_CallService);
            this.Controls.Add(this.txtRequest);
            this.Name = "Form1";
            this.Text = "ManagePath WS tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.Button btn_CallService;
        private System.Windows.Forms.Button btnCustomWay;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

