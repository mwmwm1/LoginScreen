namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            //포커스가 들어오면 예시 문구 삭제
            if (txtID.Text == "아이디")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            //포커스가 나가면 예시 문구 생성
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtID.Text = "아이디";
                txtID.ForeColor = Color.Silver;
            }
        }

        private void txtPW_Enter(object sender, EventArgs e)
        {
            //포커스가 들어오면 예시 문구 삭제 및 마스킹 적용
            if (txtPW.Text == "패스워드")
            {
                txtPW.Text = "";
                txtPW.ForeColor = Color.Black;
                txtPW.PasswordChar = '●'; //마스킹 적용
            }
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            //포커스가 나가면 예시 문구 생성 및 마스킹 해제
            if (string.IsNullOrWhiteSpace(txtPW.Text))
            {
                txtPW.Text = "패스워드";
                txtPW.ForeColor = Color.Silver;
                txtPW.PasswordChar = '\0'; //마스킹 해제
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //
            string inputID = (txtID.Text == "아이디") ? "" : txtID.Text;
            string inputPW = (txtPW.Text == "패스워드") ? "" : txtPW.Text;

            //임시 비밀번호
            string correctID = "loginscreen";
            string correctPW = "1234";

            //로그인 성공 및 실패시 메시지 박스 출력
            if (inputID == correctID && inputPW == correctPW)
            {
                MessageBox.Show("로그인 되었습니다.");
            }
            else
            {
                MessageBox.Show("로그인 실패");
            }
        }
    }
}
