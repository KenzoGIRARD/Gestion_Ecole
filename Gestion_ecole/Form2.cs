using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_ecole.Model;

namespace Gestion_ecole
{
    public partial class Form2 : Form
    {
        bd_EcoleEntities db = new bd_EcoleEntities();

        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
           // dgEleves.DataSource = db.VEleves.ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
           // txtNom.Text = dgEleves.CurrentRow.Cells[1].Value.ToString();
          //  txtPrenom.Text = dgEleves.CurrentRow.Cells[2].Value.ToString();
          /*  txtEmail.Text = dgEleves.CurrentRow.Cells[3].Value.ToString();
            txtClasse.Text = dgElevs.CurrentRow.Cells[4].Value.ToString();
           txtTel.Text = dgEleves.CurrentRow.Cells[5].Value.ToString(); */
        }

      

    }
}
