namespace LoginScreen
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
            lblAppName = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            btnLogin = new Button();
            lblErrorMsg = new Label();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 20F);
            lblAppName.Location = new Point(100, 9);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(85, 37);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 18F);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(29, 60);
            txtID.Name = "txtID";
            txtID.Size = new Size(213, 39);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.TextChanged += txtID_TextChanged;
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 18F);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(29, 112);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(213, 39);
            txtPW.TabIndex = 3;
            txtPW.Text = "패스워드";
            txtPW.TextChanged += txtPW_TextChanged;
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.GradientInactiveCaption;
            btnLogin.Font = new Font("맑은 고딕", 18F);
            btnLogin.ForeColor = SystemColors.InactiveCaptionText;
            btnLogin.Location = new Point(29, 226);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(213, 75);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(29, 176);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(226, 15);
            lblErrorMsg.TabIndex = 4;
            lblErrorMsg.Text = "아이디 또는 비밀번호가 잘못되었습니다.";
            lblErrorMsg.Visible = false;
            lblErrorMsg.Click += lblErrorMsg_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 341);
            Controls.Add(lblErrorMsg);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Login Screen";
            Load += Form1_Load;
            this.Enter += this.Form1_Enter;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtPW;
        private Button btnLogin;
        private TextBox txtID;
        private Label lblErrorMsg;
    }
}
