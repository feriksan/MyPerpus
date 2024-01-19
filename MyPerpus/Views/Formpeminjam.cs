using Microsoft.Extensions.DependencyInjection;
using MyPerpus.Models;
using MyPerpus.Repositories.BookRepo;
using MyPerpus.Repositories.PeminjamanRepo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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
            _repo = Program.ServiceProvider?.GetService<IPeminjamanRepo>()!;
        }

        private async void Formpeminjaman_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async void iconButton1_Click(object sender, EventArgs e)
        {
            await AddData();
        }
        private void KodeBukuClick(object sender, EventArgs e)
        {
            var formPopup = new PopUpBook(this);
            formPopup.Show(this);
        }
        public string KodeBukuChange
        {
            get { return textBoxKodeBuku.Text; }
            set { textBoxKodeBuku.Text = value; }
        }
        private async Task AddData()
        {
            try
            {
                string format = "MM/dd/yyyy hh:mm:ss";
                IFormatProvider provider = new CultureInfo("fr-FR");
                var newPeminjam = new PeminjamanModel
                {
                    ID = Guid.NewGuid(),
                    KodeBuku = textBoxKodeBuku.Text,
                    NIM = int.Parse(textBoxNim.Text),
                    TanggalPinjam = DateTime.ParseExact(dateTimePickerTanggalPinjam.Text, format, provider),
                    LamaPinjam = int.Parse(textBoxLamaPinjam.Text),
                };
                await _repo.Add(newPeminjam);
                await LoadData();
            }
            catch { throw; }
        }

        private async Task LoadData()
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
                        dataGridView1.Rows[i].Cells[0].Value = i + 1;
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
