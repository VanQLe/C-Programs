using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chp3_ex1_guysclass {
   public partial class Form1 : Form {
     Guy joe;
     Guy bob;
     int bank;
      public Form1() {
        InitializeComponent();
        joe = new Guy();
        joe.name = "joe";
        joe.cash = 100;
        bob = new Guy();
        bob.name = "Bob";
        bob.cash = 100;
        bank = 100;
        updateForm();
      }//end constructor

      public void updateForm() {
        joeLable1.Text = joe.name + " has $" + joe.cash;
        bobLable1.Text = joe.name + " has $" + joe.cash;
        bankLable1.Text = joe.name + " has $" + joe.cash; 
      }

      private void button1_Click(object sender, EventArgs e) {

      }
   }
}
