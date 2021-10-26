
namespace WindowsFormsApp4
{
    partial class TestForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_tr = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_pathTest = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unicode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roman_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roman_ex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_UnicodeView = new System.Windows.Forms.Button();
            this.btn_trView = new System.Windows.Forms.Button();
            this.btn_test = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_tr
            // 
            this.btn_tr.Font = new System.Drawing.Font("굴림", 20F);
            this.btn_tr.Location = new System.Drawing.Point(12, 11);
            this.btn_tr.Name = "btn_tr";
            this.btn_tr.Size = new System.Drawing.Size(131, 82);
            this.btn_tr.TabIndex = 0;
            this.btn_tr.Text = "조회";
            this.btn_tr.UseVisualStyleBackColor = true;
            this.btn_tr.Click += new System.EventHandler(this.btn_tr_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer,
            this.Roman});
            this.dataGridView1.Location = new System.Drawing.Point(12, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1394, 332);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Customer";
            this.Customer.MinimumWidth = 8;
            this.Customer.Name = "Customer";
            this.Customer.Width = 200;
            // 
            // Roman
            // 
            this.Roman.HeaderText = "Roman";
            this.Roman.MinimumWidth = 8;
            this.Roman.Name = "Roman";
            this.Roman.Width = 200;
            // 
            // btn_pathTest
            // 
            this.btn_pathTest.Font = new System.Drawing.Font("굴림", 15F);
            this.btn_pathTest.Location = new System.Drawing.Point(1311, 14);
            this.btn_pathTest.Name = "btn_pathTest";
            this.btn_pathTest.Size = new System.Drawing.Size(95, 82);
            this.btn_pathTest.TabIndex = 2;
            this.btn_pathTest.Text = "PathTest";
            this.btn_pathTest.UseVisualStyleBackColor = true;
            this.btn_pathTest.Click += new System.EventHandler(this.btn_pathTest_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Korean,
            this.Unicode,
            this.Roman_,
            this.Roman_ex,
            this.Last_Name});
            this.dataGridView2.Location = new System.Drawing.Point(12, 219);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.Size = new System.Drawing.Size(1394, 331);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.Visible = false;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 8;
            this.Number.Name = "Number";
            this.Number.Width = 150;
            // 
            // Korean
            // 
            this.Korean.HeaderText = "Korean";
            this.Korean.MinimumWidth = 8;
            this.Korean.Name = "Korean";
            this.Korean.Width = 150;
            // 
            // Unicode
            // 
            this.Unicode.HeaderText = "Unicode";
            this.Unicode.MinimumWidth = 8;
            this.Unicode.Name = "Unicode";
            this.Unicode.Width = 150;
            // 
            // Roman_
            // 
            this.Roman_.HeaderText = "Roman";
            this.Roman_.MinimumWidth = 8;
            this.Roman_.Name = "Roman_";
            this.Roman_.Width = 150;
            // 
            // Roman_ex
            // 
            this.Roman_ex.HeaderText = "Roman_ex";
            this.Roman_ex.MinimumWidth = 8;
            this.Roman_ex.Name = "Roman_ex";
            this.Roman_ex.Width = 150;
            // 
            // Last_Name
            // 
            this.Last_Name.HeaderText = "Last_Name";
            this.Last_Name.MinimumWidth = 8;
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Width = 150;
            // 
            // btn_UnicodeView
            // 
            this.btn_UnicodeView.Font = new System.Drawing.Font("굴림", 18F);
            this.btn_UnicodeView.Location = new System.Drawing.Point(163, 11);
            this.btn_UnicodeView.Name = "btn_UnicodeView";
            this.btn_UnicodeView.Size = new System.Drawing.Size(322, 82);
            this.btn_UnicodeView.TabIndex = 4;
            this.btn_UnicodeView.Text = "Unicode_Table *";
            this.btn_UnicodeView.UseVisualStyleBackColor = true;
            this.btn_UnicodeView.Click += new System.EventHandler(this.btn_UnicodeView_Click);
            // 
            // btn_trView
            // 
            this.btn_trView.Font = new System.Drawing.Font("굴림", 18F);
            this.btn_trView.Location = new System.Drawing.Point(506, 12);
            this.btn_trView.Name = "btn_trView";
            this.btn_trView.Size = new System.Drawing.Size(322, 82);
            this.btn_trView.TabIndex = 5;
            this.btn_trView.Text = "Kor->Eng";
            this.btn_trView.UseVisualStyleBackColor = true;
            this.btn_trView.Click += new System.EventHandler(this.btn_trView_Click);
            // 
            // btn_test
            // 
            this.btn_test.Font = new System.Drawing.Font("굴림", 15F);
            this.btn_test.Location = new System.Drawing.Point(1210, 14);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(95, 82);
            this.btn_test.TabIndex = 6;
            this.btn_test.Text = "SelcTest";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 75);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.btn_trView);
            this.Controls.Add(this.btn_UnicodeView);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_pathTest);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_tr);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_tr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roman;
        private System.Windows.Forms.Button btn_pathTest;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korean;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unicode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roman_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roman_ex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name;
        private System.Windows.Forms.Button btn_UnicodeView;
        private System.Windows.Forms.Button btn_trView;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Button button1;
    }
}

