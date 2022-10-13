using System;
using System.Windows.Forms;

namespace WindowsSignIn {
  public partial class Form1: Form {
    public Form1() {
      InitializeComponent();
    }
    
    private void SignInButton_Click(object sender, EventArgs e) {
      string userId = id.Text;
      string userPassword = password.Text;
      
      if (userId.Equals("MyId") && userPassword.Equals("MyPassword")) {
        MessageBox.Show("로그인에 성공했습니다.", "로그인");
      } else {
        MessageBox.Show("로그인에 실패했습니다.", "로그인");
      }
    }
  }
}
