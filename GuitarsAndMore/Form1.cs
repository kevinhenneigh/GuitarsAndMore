using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuitarsAndMore
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Guitar guitar = new Guitar()
            //{
            //    Brand = "Gibson",
            //    GuitarType = "Les Paul Studio Gold Top",
            //    Color = "Antique Zebra",
            //    Value = 700
            //};

            //GuitarContext guitarContext = new GuitarContext();
            //guitarContext.Guitars.Add(guitar);
            //guitarContext.SaveChanges();
            try
            {
                List<Guitar> allGuitars = GuitarDb.GetGuitars();
                PopulateGuitarList(allGuitars);

            }
            catch (SqlException)
            {
                MessageBox.Show("We are having database issues, try again later");
                MessageBox.Show("Guitars are unable to be loaded. App will close");
                Close();
            }
        }
        private void PopulateGuitarList(List<Guitar> guitars)
        {
            InventoryListBox.Items.Clear();
            foreach ( Guitar guitar in guitars)
            {
                InventoryListBox.Items.Add(guitar);                
            }
        }

        private void AddGuitarBtn_Click(object sender, EventArgs e)
        {
            Form addGuitarForm = new AddGuitarForm();
            addGuitarForm.ShowDialog();
        }

        private void UpdateGuitarBtn_Click(object sender, EventArgs e)
        {
            Form addGuitarForm = new AddGuitarForm();
            addGuitarForm.ShowDialog();
        }

        private void DeleteGuitarBtn_Click(object sender, EventArgs e)
        {
            Form deleteGuitarForm = new Form();
            deleteGuitarForm.ShowDialog();
        }

        private void InventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
