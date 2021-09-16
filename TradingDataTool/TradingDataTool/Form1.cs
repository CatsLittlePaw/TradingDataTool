using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingDataTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StockCodes_Focus(object sender, EventArgs e)
        {
            if(StockCodes.Text == "範例: 0001,0002,0003")
            {
                StockCodes.Text = "";
                StockCodes.ForeColor = Color.Black;
            }
        }

        private void StockCodes_Blur(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(StockCodes.Text.Trim()))
            {
                StockCodes.Text = "範例: 0001,0002,0003";
                StockCodes.ForeColor = Color.Gray;
            }
        }
    }
}
