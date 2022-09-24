using System;
using System.Windows.Forms;

namespace FindNumber {
  public partial class Form1: Form {
    // 맞출 숫자와 기회를 결정하는 변수 초기화
    private int findNumber = 0;
    private int chance = 0;

    public Form1() {
      InitializeComponent();
    }

    // 게임 시작 시 임의의 숫자를 생성하고 기회를 10번으로 초기화
    private void ButtonStart_Click(object sender, EventArgs e) {
      var rand = new Random();
      findNumber = rand.Next(1, 21);
      chance = 10;
      display.Text = "맞힐 숫자를 입력하세요.";
    }
  }
}