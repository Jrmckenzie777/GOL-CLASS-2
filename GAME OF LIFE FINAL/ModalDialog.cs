using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME_OF_LIFE_FINAL
{
    public partial class ModalDialog : Form
    {
        public ModalDialog()
        {
            InitializeComponent();
        }

        //public int GetNumber()
        //{
        //    return (int)numericUpDownNumber.Value;
        //}

        //public void SetNumber(int number)
        //{
        //    numericUpDownNumber.Value = number;
        //}

        

        public int Number
        {
            get
            {
                return (int)numericUpDownNumber.Value;
            }

            set
            {
                numericUpDownNumber.Value = value;
            }
        }
    }
}
