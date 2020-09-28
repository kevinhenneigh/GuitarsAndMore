using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuitarsAndMore
{
    public partial class AddGuitarForm : Form
    {
        public AddGuitarForm()
        {
            InitializeComponent();
        }

        private void AddGuitarBtn_Click(object sender, EventArgs e)
        {
            // Create Guitar object to add
            Guitar guitar = new Guitar
            {
                Brand = BrandTxtBox.Text,
                GuitarType = GuitarTypeTxtBox.Text,
                Color = ColorTxtBox.Text,
                Value = double.Parse(ValueTxtBox.Text)
            };
            DialogResult dialog = MessageBox.Show("Is everything correct?", 
                                                    "Guitar",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Hand,
                                                    MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.Yes)
            {
                GuitarDb.Add(guitar);
                MessageBox.Show("Guitar Added!");
            }    
        }
    }
}
