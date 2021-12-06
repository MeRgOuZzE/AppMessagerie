using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMessagerie
{
    public partial class ClienTchat : Form
    {
        public ClienTchat()
        {
            InitializeComponent();
        }

    
        private Color RandomColor()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            KnownColor[] values = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            return Color.FromKnownColor(values[random.Next(values.Length)]);
        }


    }
}
