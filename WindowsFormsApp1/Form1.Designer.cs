namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtquequan = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.bntxoa = new System.Windows.Forms.Button();
            this.bntsua = new System.Windows.Forms.Button();
            this.bntnhap = new System.Windows.Forms.Button();
            this.bntseach = new System.Windows.Forms.Button();
            this.bntout = new System.Windows.Forms.Button();
            this.dssv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dssv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "mã sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "quê quán";
            // 
            // txtquequan
            // 
            this.txtquequan.Location = new System.Drawing.Point(486, 107);
            this.txtquequan.Name = "txtquequan";
            this.txtquequan.Size = new System.Drawing.Size(100, 22);
            this.txtquequan.TabIndex = 3;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(209, 107);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(172, 22);
            this.txthoten.TabIndex = 4;
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(43, 107);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(100, 22);
            this.txtmasv.TabIndex = 5;
            this.txtmasv.Leave += new System.EventHandler(this.txtmasv_Leave);
            // 
            // bntxoa
            // 
            this.bntxoa.Location = new System.Drawing.Point(666, 136);
            this.bntxoa.Name = "bntxoa";
            this.bntxoa.Size = new System.Drawing.Size(75, 23);
            this.bntxoa.TabIndex = 6;
            this.bntxoa.Text = "xoá";
            this.bntxoa.UseVisualStyleBackColor = true;
            this.bntxoa.Click += new System.EventHandler(this.bntxoa_Click);
            // 
            // bntsua
            // 
            this.bntsua.Location = new System.Drawing.Point(666, 107);
            this.bntsua.Name = "bntsua";
            this.bntsua.Size = new System.Drawing.Size(75, 23);
            this.bntsua.TabIndex = 7;
            this.bntsua.Text = "sửa";
            this.bntsua.UseVisualStyleBackColor = true;
            this.bntsua.Click += new System.EventHandler(this.bntsua_Click);
            // 
            // bntnhap
            // 
            this.bntnhap.Location = new System.Drawing.Point(666, 73);
            this.bntnhap.Name = "bntnhap";
            this.bntnhap.Size = new System.Drawing.Size(75, 23);
            this.bntnhap.TabIndex = 8;
            this.bntnhap.Text = "nhập";
            this.bntnhap.UseVisualStyleBackColor = true;
            this.bntnhap.Click += new System.EventHandler(this.bntnhap_Click);
            // 
            // bntseach
            // 
            this.bntseach.Location = new System.Drawing.Point(666, 165);
            this.bntseach.Name = "bntseach";
            this.bntseach.Size = new System.Drawing.Size(75, 23);
            this.bntseach.TabIndex = 9;
            this.bntseach.Text = "tìm kiếm";
            this.bntseach.UseVisualStyleBackColor = true;
            this.bntseach.Click += new System.EventHandler(this.bntseach_Click);
            // 
            // bntout
            // 
            this.bntout.Location = new System.Drawing.Point(666, 194);
            this.bntout.Name = "bntout";
            this.bntout.Size = new System.Drawing.Size(75, 23);
            this.bntout.TabIndex = 10;
            this.bntout.Text = "thoát";
            this.bntout.UseVisualStyleBackColor = true;
            // 
            // dssv
            // 
            this.dssv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dssv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dssv.Location = new System.Drawing.Point(56, 239);
            this.dssv.Name = "dssv";
            this.dssv.RowHeadersWidth = 51;
            this.dssv.RowTemplate.Height = 24;
            this.dssv.Size = new System.Drawing.Size(516, 150);
            this.dssv.TabIndex = 11;
            this.dssv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dssv_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dssv);
            this.Controls.Add(this.bntout);
            this.Controls.Add(this.bntseach);
            this.Controls.Add(this.bntnhap);
            this.Controls.Add(this.bntsua);
            this.Controls.Add(this.bntxoa);
            this.Controls.Add(this.txtmasv);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtquequan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dssv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtquequan;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.Button bntxoa;
        private System.Windows.Forms.Button bntsua;
        private System.Windows.Forms.Button bntnhap;
        private System.Windows.Forms.Button bntseach;
        private System.Windows.Forms.Button bntout;
        private System.Windows.Forms.DataGridView dssv;
    }
}

