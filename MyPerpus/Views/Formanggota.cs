using Microsoft.VisualBasic.ApplicationServices;
using MyPerpus.Models;
using MyPerpus.Repositories.AnggotaRepo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPerpus.Views
{
    public partial class Formanggota : Form
    {
        private readonly IAnggotaRepo _userRepo;
        private List<AnggotaModel> _users = [];
        private AnggotaModel? _selecteduser;
        public Formanggota()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("TEst");
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("TEst");
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("TEst");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("TEst");
        }

        private async Task LoadDataUsers()
        {
            try
            {
                _users = await _userRepo.GetAll();
                dataGridView1.Rows.Clear();
                if (_users.Count > 0)
                {
                    // Menambahkan baris sesuai jumlah data
                    dataGridView1.Rows.Add(_users.Count);
                    for (int i = 0; i < _users.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = i + 1;
                        dataGridView1.Rows[i].Cells[1].Value = _users[i].ID;
                        dataGridView1.Rows[i].Cells[2].Value = _users[i].Nama;
                        dataGridView1.Rows[i].Cells[3].Value = _users[i].Jurusan;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
