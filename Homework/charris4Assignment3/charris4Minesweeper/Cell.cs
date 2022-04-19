using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace charris4Minesweeper
{
    public partial class Cell : UserControl
    {
        Button button = new Button();
        int sizeOfCell = 32;
        public Cell()
        {
            InitializeComponent();
            this.Size = new Size(SizeOfCell, SizeOfCell);
            Button.FlatStyle = FlatStyle.Flat;
            Button.Size = new Size(SizeOfCell, sizeOfCell);
            Button.Location = new Point(0, 0);
            Button.BackColor = Color.LightGray;
            this.Controls.Add(Button);
        }

        public int SizeOfCell { get => sizeOfCell; }
        public Button Button { get => button; }
    }
}
