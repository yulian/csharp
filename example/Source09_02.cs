using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace WindowsFormsApp {
  public partial class Form1: Form {
    SerialPort port = new SerialPort("COM3", 9600);
    
    public Form1() {
      InitializeComponent();
    }
    
    private void ButtonOn_Click(object sender, EventArgs e) {
      port.Open();
      port.Write("1");
      port.Close();
    }
    
    private void ButtonOff_Click(object sender, EventArgs e) {
      port.Open();
      port.Write("0");
      port.Close();
    }
  }
}
