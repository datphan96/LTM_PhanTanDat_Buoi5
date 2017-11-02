namespace PhanTanDat_b5_b1_Client
{
    partial class Client
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_cnt = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_file = new System.Windows.Forms.Button();
            this.btn_snd = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server IP :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(460, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_cnt
            // 
            this.btn_cnt.Location = new System.Drawing.Point(549, 2);
            this.btn_cnt.Name = "btn_cnt";
            this.btn_cnt.Size = new System.Drawing.Size(100, 23);
            this.btn_cnt.TabIndex = 2;
            this.btn_cnt.Text = "Connect";
            this.btn_cnt.UseVisualStyleBackColor = true;
            this.btn_cnt.Click += new System.EventHandler(this.btn_cnt_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(515, 238);
            this.listBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Message :";
            // 
            // btn_file
            // 
            this.btn_file.Location = new System.Drawing.Point(549, 54);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(100, 23);
            this.btn_file.TabIndex = 6;
            this.btn_file.Text = "Files";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // btn_snd
            // 
            this.btn_snd.Location = new System.Drawing.Point(549, 326);
            this.btn_snd.Name = "btn_snd";
            this.btn_snd.Size = new System.Drawing.Size(100, 95);
            this.btn_snd.TabIndex = 7;
            this.btn_snd.Text = "Send";
            this.btn_snd.UseVisualStyleBackColor = true;
            this.btn_snd.Click += new System.EventHandler(this.btn_snd_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 326);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(515, 95);
            this.textBox2.TabIndex = 9;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_snd);
            this.Controls.Add(this.btn_file);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_cnt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Text = "Chat Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_cnt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.Button btn_snd;
        private System.Windows.Forms.TextBox textBox2;
    }
}

