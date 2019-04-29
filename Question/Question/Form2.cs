using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        float critChanse = .3f;
        
        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            float randomValue = r.Next(0, 1);
            if(critChanse < randomValue)
            {
                Console.WriteLine("You have been awarded with " + critChanse + "points");
            }
        }
    }
}
