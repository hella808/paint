namespace Win1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Close_button(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_button(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                //code if true
                MessageBox.Show("Your need to write UserName or Password");
                return;
            }
            if (txtUserName.Text == "123" && txtPassword.Text == "321")
            {
                //code if true
                this.Hide();
                FormMain _formmain = new FormMain();
                _formmain.ShowDialog();

            }
            else
            {
                // code if false
                MessageBox.Show("You UserName or Password not right");
            }

        }

        private void InitializeComponent()
        {
            closebtn = new Button();
            loginbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // closebtn
            // 
            closebtn.Location = new Point(585, 590);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(77, 30);
            closebtn.TabIndex = 0;
            closebtn.Text = "Close";
            closebtn.UseVisualStyleBackColor = true;
            // 
            // loginbtn
            // 
            loginbtn.Location = new Point(536, 419);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(215, 58);
            loginbtn.TabIndex = 1;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(523, 264);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(503, 310);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(566, 261);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(155, 23);
            txtUserName.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(566, 307);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(155, 23);
            txtPassword.TabIndex = 5;
            // 
            // Form1
            // 
            ClientSize = new Size(1439, 715);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginbtn);
            Controls.Add(closebtn);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }
        private Button closebtn;
        private Button loginbtn;
        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtPassword;

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}