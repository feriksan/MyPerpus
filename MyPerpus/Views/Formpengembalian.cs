using MyPerpus.Models;
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
    }
}
