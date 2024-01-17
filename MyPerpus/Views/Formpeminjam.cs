using MyPerpus.Models;
using MyPerpus.Repositories.PeminjamanRepo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPerpus.Views
{
    public partial class Formpeminjam : Form
    {
        private readonly IPeminjamanRepo _repo;
        private List<PeminjamanModel> _model = [];
        private PeminjamanModel? _selected;
        public Formpeminjam()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private async Task LoadDataUsers()
        {
            try
            {
                _model = await _repo.GetAll();
                dataGridView1.Rows.Clear();
                if (_model.Count > 0)
                {
                    // Menambahkan baris sesuai jumlah data
                    dataGridView1.Rows.Add(_model.Count);
                    for (int i = 0; i < _model.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = _model[i].ID;
                        dataGridView1.Rows[i].Cells[1].Value = _model[i].KodeBuku;
                        dataGridView1.Rows[i].Cells[2].Value = _model[i].NIM;
                        dataGridView1.Rows[i].Cells[3].Value = _model[i].TanggalPinjam;
                        dataGridView1.Rows[i].Cells[4].Value = _model[i].LamaPinjam;
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
