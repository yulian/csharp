using System;
using System.Windows.Forms;

namespace FindNumber {
  public partial class Form1: Form {
    private int findNumber = 0;
    private int chance = 0;

    public Form1() {
      InitializeComponent();
    }

    private void ButtonStart_Click(object sender, EventArgs e) {
      var rand = new Random();
      findNumber = rand.Next(1, 21);
      chance = 10;
      display.Text = "맞힐 숫자를 입력하세요.";
    }

    private void ButtonInput_Click(object sender, EventArgs e) {
      // 텍스트박스의 문자열을 정수로 변경
      int inputNumber = Int32.Parse(textBox.Text);

      // 사용자 입력과 맞힐 숫자를 비교 후 처리하기
      if (inputNumber == findNumber) {
        display.Text = "승리했습니다!!!";
      } else {
        chance--;
        display.Text = "기회는 " + chance + "번 남았습니다.";
      }

      // 기회가 남았는지 비교 후 처리하기
      if (chance <= 0) {
        display.Text = "실패했습니다!!!";
      }
    }
  }
}