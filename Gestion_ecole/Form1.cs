using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_ecole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=LAPTOP-9ULT8UN7\SQLEXPRESS;Database=bd_Ecole;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT role FROM Users WHERE email=@email AND mdp=@mdp AND role='Administrateur'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", txtIdentifiant.Text);
                    cmd.Parameters.AddWithValue("@mdp", txtMdp.Text); // N'oubliez pas d'utiliser un mécanisme de hachage sécurisé pour les mots de passe en production

                    var role = cmd.ExecuteScalar();

                    if (role != null)
                    {
                        MessageBox.Show("Connexion réussie en tant qu'Administrateur!");
                        // Redirigez vers la fenêtre ou la section de l'application réservée aux administrateurs
                        Form1 a = new Form1();
                        a.Close();
                        Form2 b = new Form2();
                        b.Show();
                       
                    }
                    else
                    {
                        MessageBox.Show("Accès refusé. Veuillez vérifier vos informations d'identification ou vos droits d'accès.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Une erreur est survenue: {ex.Message}");
                }
            }
        }
    }   
  }

