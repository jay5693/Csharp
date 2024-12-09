namespace WindowsFormsApp3
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtInsertUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInsertId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInsertPwd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGetUserList = new System.Windows.Forms.Button();
            this.dtUserList = new System.Windows.Forms.DataGridView();
            this.NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PWD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtOldID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOldPWD = new System.Windows.Forms.TextBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.txtNewID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNewPWD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCheckPWD = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtUserList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtInsertUsername);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtInsertId);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnRegister);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtInsertPwd);
            this.groupBox2.Location = new System.Drawing.Point(531, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 136);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scalar 예시";
            // 
            // txtInsertUsername
            // 
            this.txtInsertUsername.Location = new System.Drawing.Point(86, 84);
            this.txtInsertUsername.Name = "txtInsertUsername";
            this.txtInsertUsername.Size = new System.Drawing.Size(132, 21);
            this.txtInsertUsername.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "이름:";
            // 
            // txtInsertId
            // 
            this.txtInsertId.Location = new System.Drawing.Point(86, 20);
            this.txtInsertId.Name = "txtInsertId";
            this.txtInsertId.Size = new System.Drawing.Size(132, 21);
            this.txtInsertId.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(316, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 56);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "회원탈퇴";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "아이디 :";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(234, 21);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 55);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "회원가입";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "암 호 :";
            // 
            // txtInsertPwd
            // 
            this.txtInsertPwd.Location = new System.Drawing.Point(86, 55);
            this.txtInsertPwd.Name = "txtInsertPwd";
            this.txtInsertPwd.Size = new System.Drawing.Size(132, 21);
            this.txtInsertPwd.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOdd);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnGetUserList);
            this.groupBox3.Controls.Add(this.dtUserList);
            this.groupBox3.Location = new System.Drawing.Point(0, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(501, 357);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ExecuteReader 예시";
            // 
            // btnOdd
            // 
            this.btnOdd.Location = new System.Drawing.Point(16, 328);
            this.btnOdd.Name = "btnOdd";
            this.btnOdd.Size = new System.Drawing.Size(213, 23);
            this.btnOdd.TabIndex = 16;
            this.btnOdd.Text = "홀수행";
            this.btnOdd.UseVisualStyleBackColor = true;
            this.btnOdd.Click += new System.EventHandler(this.btnOdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "첫번째사용자 가져오기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGetUserList
            // 
            this.btnGetUserList.Location = new System.Drawing.Point(16, 282);
            this.btnGetUserList.Name = "btnGetUserList";
            this.btnGetUserList.Size = new System.Drawing.Size(213, 23);
            this.btnGetUserList.TabIndex = 9;
            this.btnGetUserList.Text = "사용자 목록 가져오기";
            this.btnGetUserList.UseVisualStyleBackColor = true;
            this.btnGetUserList.Click += new System.EventHandler(this.btnGetUserList_Click);
            // 
            // dtUserList
            // 
            this.dtUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM,
            this.ID,
            this.PWD,
            this.USERNAME});
            this.dtUserList.Location = new System.Drawing.Point(16, 35);
            this.dtUserList.Name = "dtUserList";
            this.dtUserList.RowTemplate.Height = 23;
            this.dtUserList.Size = new System.Drawing.Size(468, 230);
            this.dtUserList.TabIndex = 8;
            // 
            // NUM
            // 
            this.NUM.DataPropertyName = "NUM";
            this.NUM.HeaderText = "번호";
            this.NUM.Name = "NUM";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "아이디";
            this.ID.Name = "ID";
            // 
            // PWD
            // 
            this.PWD.DataPropertyName = "PWD";
            this.PWD.HeaderText = "암호";
            this.PWD.Name = "PWD";
            // 
            // USERNAME
            // 
            this.USERNAME.HeaderText = "성명";
            this.USERNAME.Name = "USERNAME";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Location = new System.Drawing.Point(-1, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 99);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scalar 예시";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(86, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(132, 21);
            this.txtID.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(316, 21);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 56);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "취 소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디 :";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(234, 21);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 55);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "암 호 :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(86, 55);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(132, 21);
            this.txtPassword.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtCheckPWD);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtNewName);
            this.groupBox4.Controls.Add(this.txtNewID);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtNewPWD);
            this.groupBox4.Controls.Add(this.btn_check);
            this.groupBox4.Controls.Add(this.txtOldID);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btn_Update);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtOldPWD);
            this.groupBox4.Location = new System.Drawing.Point(531, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(502, 247);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Scalar 예시";
            // 
            // txtOldID
            // 
            this.txtOldID.Location = new System.Drawing.Point(86, 20);
            this.txtOldID.Name = "txtOldID";
            this.txtOldID.Size = new System.Drawing.Size(132, 21);
            this.txtOldID.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "아이디 :";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(298, 198);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(108, 21);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "회원 정보 변경";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "암 호 :";
            // 
            // txtOldPWD
            // 
            this.txtOldPWD.Location = new System.Drawing.Point(86, 55);
            this.txtOldPWD.Name = "txtOldPWD";
            this.txtOldPWD.Size = new System.Drawing.Size(132, 21);
            this.txtOldPWD.TabIndex = 3;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(298, 54);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(108, 21);
            this.btn_check.TabIndex = 5;
            this.btn_check.Text = "로그인";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // txtNewID
            // 
            this.txtNewID.Location = new System.Drawing.Point(113, 97);
            this.txtNewID.Name = "txtNewID";
            this.txtNewID.Size = new System.Drawing.Size(132, 21);
            this.txtNewID.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "새 아이디 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "새로운 암 호 :";
            // 
            // txtNewPWD
            // 
            this.txtNewPWD.Location = new System.Drawing.Point(113, 130);
            this.txtNewPWD.Name = "txtNewPWD";
            this.txtNewPWD.Size = new System.Drawing.Size(132, 21);
            this.txtNewPWD.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "새로운 이름 :";
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(113, 196);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(132, 21);
            this.txtNewName.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "암호 확인 :";
            // 
            // txtCheckPWD
            // 
            this.txtCheckPWD.Location = new System.Drawing.Point(113, 163);
            this.txtCheckPWD.Name = "txtCheckPWD";
            this.txtCheckPWD.Size = new System.Drawing.Size(132, 21);
            this.txtCheckPWD.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 507);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtUserList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtInsertUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInsertId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInsertPwd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGetUserList;
        private System.Windows.Forms.DataGridView dtUserList;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PWD;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERNAME;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCheckPWD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.TextBox txtNewID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNewPWD;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.TextBox txtOldID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOldPWD;
    }
}

