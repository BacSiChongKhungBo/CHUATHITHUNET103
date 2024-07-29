namespace CHUATHITHUNET103
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTen = new TextBox();
            txtTuoi = new TextBox();
            txt_TimKiem = new TextBox();
            cmbCoSo = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            dtgView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 45);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 92);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Tuổi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 139);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "Cơ Sở";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 236);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Tìm Kiếm";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(168, 45);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(406, 27);
            txtTen.TabIndex = 4;
            // 
            // txtTuoi
            // 
            txtTuoi.Location = new Point(168, 89);
            txtTuoi.Name = "txtTuoi";
            txtTuoi.Size = new Size(406, 27);
            txtTuoi.TabIndex = 5;
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(168, 229);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(406, 27);
            txt_TimKiem.TabIndex = 6;
            // 
            // cmbCoSo
            // 
            cmbCoSo.FormattingEnabled = true;
            cmbCoSo.Location = new Point(168, 136);
            cmbCoSo.Name = "cmbCoSo";
            cmbCoSo.Size = new Size(151, 28);
            cmbCoSo.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(604, 45);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(167, 67);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(604, 116);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(167, 67);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(604, 189);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(167, 67);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dtgView
            // 
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(63, 259);
            dtgView.Name = "dtgView";
            dtgView.RowHeadersWidth = 51;
            dtgView.Size = new Size(708, 188);
            dtgView.TabIndex = 11;
            dtgView.CellClick += dtgView_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgView);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cmbCoSo);
            Controls.Add(txt_TimKiem);
            Controls.Add(txtTuoi);
            Controls.Add(txtTen);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTen;
        private TextBox txtTuoi;
        private TextBox txt_TimKiem;
        private ComboBox cmbCoSo;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dtgView;
    }
}
