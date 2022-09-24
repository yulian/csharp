using System;
using System.Windows.Forms;

namespace Calculator {
  public partial class Form1: Form {
    // 열거형 정의
    enum Operators {
      None,
      Add,
      Subtract,
      Multiply,
      Divide,
      Result
    }
    
    // 연산의 종류를 결정하는 열거형 변수 초기화
    Operators currentOperator = Operators.None;
    
    // 연산 버튼의 클릭 여부를 결정하는 변수 초기화
    Boolean operatorChangeFlag = false;
    
    // 두 피연산자 변수 초기화
    int firstOperand = 0;
    int secondOperand = 0;

    public Form1() {
      InitializeComponent();
    }
    
    // 사칙 연산을 수행하는 로직
    private void ButtonResult_Click(object sender, EventArgs e) {
      secondOperand = Int32.Parse(display.Text);
      if (currentOperator == Operators.Add) {
        firstOperand += secondOperand;
        display.Text = firstOperand.ToString();
      } else if (currentOperator == Operators.Subtract) {
        firstOperand -= secondOperand;
        display.Text = firstOperand.ToString();
      } else if (currentOperator == Operators.Multiply) {
        firstOperand *= secondOperand;
        display.Text = firstOperand.ToString();
      } else if (currentOperator == Operators.Divide) {
        if (secondOperand == 0) {
          display.Text = "0으로 나눌 수 없습니다";
        } else {
          firstOperand /= secondOperand;
          display.Text = firstOperand.ToString();
        }
      }
    }
    
    // 덧셈 버튼 클릭
    private void ButtonAdd_Click(object sender, EventArgs e) {
      firstOperand = Int32.Parse(display.Text);
      currentOperator = Operators.Add;
      operatorChangeFlag = true;
    }
    
    // 뺄셈 버튼 클릭
    private void ButtonSubtract_Click(object sender, EventArgs e) {
      firstOperand = Int32.Parse(display.Text);
      currentOperator = Operators.Subtract;
      operatorChangeFlag = true;
    }
    
    // 곱셈 버튼 클릭
    private void ButtonMultiply_Click(object sender, EventArgs e) {
      firstOperand = Int32.Parse(display.Text);
      currentOperator = Operators.Multiply;
      operatorChangeFlag = true;
    }
    
    // 나눗셈 버튼 클릭
    private void ButtonDivide_Click(object sender, EventArgs e) {
      firstOperand = Int32.Parse(display.Text);
      currentOperator = Operators.Divide;
      operatorChangeFlag = true;
    }
    
    // AC 버튼 클릭
    private void ButtonAllClear_Click(object sender, EventArgs e) {
      firstOperand = 0;
      secondOperand = 0;
      currentOperator = Operators.None;
      display.Text = "0";
    }
    
    // 숫자 0버튼 클릭
    private void ButtonZero_Click(object sender, EventArgs e) {
      if (operatorChangeFlag == true) {
        display.Text = "";
        operatorChangeFlag = false;
      }
      string strNumber = display.Text += "0";
      int intNumber = Int32.Parse(strNumber);
      display.Text = intNumber.ToString();
    }
    
    // 숫자 1버튼 클릭
    private void ButtonOne_Click(object sender, EventArgs e) {
      if (operatorChangeFlag == true) {
        display.Text = "";
        operatorChangeFlag = false;
      }
      string strNumber = display.Text += "1";
      int intNumber = Int32.Parse(strNumber);
      display.Text = intNumber.ToString();
    }
    
    // 숫자 2버튼 클릭
    private void ButtonTwo_Click(object sender, EventArgs e) {
      if (operatorChangeFlag == true) {
        display.Text = "";
        operatorChangeFlag = false;
      }
      string strNumber = display.Text += "2";
      int intNumber = Int32.Parse(strNumber);
      display.Text = intNumber.ToString();
    }
    
    // 숫자 3버튼 클릭
    private void ButtonThree_Click(object sender, EventArgs e) {
      if (operatorChangeFlag == true) {
        display.Text = "";
        operatorChangeFlag = false;
      }
      string strNumber = display.Text += "3";
      int intNumber = Int32.Parse(strNumber);
      display.Text = intNumber.ToString();
    }
    
    // 숫자 4버튼 클릭
    private void ButtonFour_Click(object sender, EventArgs e) {
      if (operatorChangeFlag == true) {
        display.Text = "";
        operatorChangeFlag = false;
      }
      string strNumber = display.Text += "4";
      int intNumber = Int32.Parse(strNumber);
      display.Text = intNumber.ToString();
    }
    
    // 숫자 5버튼 클릭
    private void ButtonFive_Click(object sender, EventArgs e) {
      if (operatorChangeFlag == true) {
        display.Text = "";
        operatorChangeFlag = false;
      }
      string strNumber = display.Text += "5";
      int intNumber = Int32.Parse(strNumber);
      display.Text = intNumber.ToString();
    }
    
    // 숫자 6버튼 클릭
    private void ButtonSix_Click(object sender, EventArgs e) {
      if (operatorChangeFlag == true) {
        display.Text = "";
        operatorChangeFlag = false;
      }
      string strNumber = display.Text += "6";
      int intNumber = Int32.Parse(strNumber);
      display.Text = intNumber.ToString();
    }
    
    // 숫자 7버튼 클릭
    private void ButtonSeven_Click(object sender, EventArgs e) {
      if (operatorChangeFlag == true) {
        display.Text = "";
        operatorChangeFlag = false;
      }
      string strNumber = display.Text += "7";
      int intNumber = Int32.Parse(strNumber);
      display.Text = intNumber.ToString();
    }
    
    // 숫자 8버튼 클릭
    private void ButtonEight_Click(object sender, EventArgs e) {
      if (operatorChangeFlag == true) {
        display.Text = "";
        operatorChangeFlag = false;
      }
      string strNumber = display.Text += "8";
      int intNumber = Int32.Parse(strNumber);
      display.Text = intNumber.ToString();
    }
    
    // 숫자 9버튼 클릭
    private void ButtonNine_Click(object sender, EventArgs e) {
      if (operatorChangeFlag == true) {
        display.Text = "";
        operatorChangeFlag = false;
      }
      string strNumber = display.Text += "9";
      int intNumber = Int32.Parse(strNumber);
      display.Text = intNumber.ToString();
    }
  }
}