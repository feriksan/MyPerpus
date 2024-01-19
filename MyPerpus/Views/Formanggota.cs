using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using MyPerpus.Models;
using MyPerpus.Repositories.AnggotaRepo;
using MyPerpus.Repositories.BookRepo;
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
        private readonly IAnggotaRepo _repo;
        private List<AnggotaModel> _models = [];
        private AnggotaModel? _selected;
        public Formanggota()
        {
            InitializeComponent();
            _repo = Program.ServiceProvider?.GetService<IAnggotaRepo>()!;
        }

        private async void Formangota_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("JSAKSK");
            await LoadData();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("TEst");
        }

        private async void iconButton3_Click(object sender, EventArgs e)
        {
            await AddData();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("TEst");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("TEst");
        }
        private async Task AddData()
        {
            try
            {
                var newData = new AnggotaModel
                {
                    ID = textNIM.Text,
                    Nama = textNama.Text,
                    Jurusan = textJurusan.Text,
                    NoHp = textHp.Text,
                    Alamat = textAlamat.Text
                };
                await _repo.Add(newData);
                await LoadData();
            }
            catch { throw; }
        }

        private async Task LoadData()
        {
            try
            {
                _models = await _repo.GetAll();
                dataGridView1.Rows.Clear();
                if (_models.Count > 0)
                {
                    // Menambahkan baris sesuai jumlah data
                    dataGridView1.Rows.Add(_models.Count);
                    for (int i = 0; i < _models.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = i + 1;
                        dataGridView1.Rows[i].Cells[1].Value = _models[i].ID;
                        dataGridView1.Rows[i].Cells[2].Value = _models[i].Nama;
                        dataGridView1.Rows[i].Cells[3].Value = _models[i].Jurusan;
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
