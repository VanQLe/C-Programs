using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chp3_ex1_guysclass {
	class Guy {
		public int cash;
    public string name = "";
		public int giveCash(int amount) {
				if(cash <= amount && cash > 0){
					cash -= amount;
					return amount;
				}//end if
				else {
					MessageBox.Show("I don't have enough cash to give you" + amount + name + "says...");
					return 0;
				}
		}//end method

	}//end class
}//end namespace
