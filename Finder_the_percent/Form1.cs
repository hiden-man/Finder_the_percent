using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finder_the_percent
{
    public partial class Form1 : Form
    {
        /*
         * Формула
         * (500 * 43% / 100 = 215)
         * 
         */
        ushort X, Y;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainFormLocation();
        }

        async void MainFormLocation()
        {
            await Task.Run(() =>
            {
                for (; true;)
                {
                    X = (ushort)Size.Width;
                    Y = (ushort)Size.Height;
                    // вираховування відсотку
                    button1.Location = new Point((X*5/100), (Y*5/100));
                }
            });
        }
    }
}
