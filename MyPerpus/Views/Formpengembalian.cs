using System.Diagnostics;
using System.Globalization;
using Microsoft.Extensions.DependencyInjection;
using MyPerpus.Models;
using MyPerpus.Repositories.BookRepo;
using MyPerpus.Repositories.PengembalianRepo;

namespace MyPerpus.Views
{
    public partial class Formpengembalian : Form
    {
        private readonly IPengembalianRepo _repo;
        private List<PengembalianModel> _model = [];
        private PengembalianModel? _selected;
        public Formpengembalian()
        {
            InitializeComponent();
            _repo = Program.ServiceProvider?.GetService<IPengembalianRepo>()!;
        }

        private async void Formpengembalian_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async void iconButton1_Click(object sender, EventArgs e)
        {
            await AddData();
        }

        private async Task AddData()
        {
            try
            {
                string format = "MM/dd/yyyy hh:mm:ss";
                IFormatProvider provider = new CultureInfo("fr-FR");
                var newBook = new PengembalianModel
                {
                    ID = Guid.NewGuid(),
                    KodeBuku = textBoxKodeBuku.Text,
                    NIM = int.Parse(textBoxNim.Text),
                    JatuhTempo = DateTime.ParseExact(dateTimePickerJatuhTempo.Text, format, provider),
                    TanggalPinjam = DateTime.ParseExact(dateTimePickerTanggalPinjam.Text, format, provider),
                    TanggalKembali = DateTime.ParseExact(dateTimePickerTanggalKembali.Text, format, provider),
                    LamaPinjam = int.Parse(textBoxLamaPinjam.Text),
                    Denda = int.Parse(textBoxDenda.Text),
                    TotalDenda = int.Parse(textBoxTotalDenda.Text),
                };
                await _repo.Add(newBook);
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
                        dataGridView1.Rows[i].Cells[0].Value = _model[i].ID;
                        dataGridView1.Rows[i].Cells[1].Value = _model[i].KodeBuku;
                        dataGridView1.Rows[i].Cells[2].Value = _model[i].NIM;
                        dataGridView1.Rows[i].Cells[3].Value = _model[i].JatuhTempo;
                        dataGridView1.Rows[i].Cells[4].Value = _model[i].TanggalPinjam;
                        dataGridView1.Rows[i].Cells[5].Value = _model[i].LamaPinjam;
                        dataGridView1.Rows[i].Cells[6].Value = _model[i].TanggalKembali;
                        dataGridView1.Rows[i].Cells[7].Value = _model[i].TotalDenda;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
