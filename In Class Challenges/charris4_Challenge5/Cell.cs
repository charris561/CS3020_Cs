using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace charris4_Challenge5
{
    public partial class Cell : UserControl
    {
        Button button = new Button();
        int sizeOfCell = 32;
        public Cell()
        {
            InitializeComponent();
            this.Size = new Size(sizeOfCell,sizeOfCell);
            Button.FlatStyle = FlatStyle.Flat;
            Button.Size = new Size(sizeOfCell, sizeOfCell);
            Button.Location = new Point(0,0);
            Button.BackColor = Color.LightGray;
            this.Controls.Add(Button);
        }

        public int SizeOfCell { get => sizeOfCell;}
        public Button Button { get => button; }
    }
}
