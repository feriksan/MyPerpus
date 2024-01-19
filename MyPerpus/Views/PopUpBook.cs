using System.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using MyPerpus.Models;
using MyPerpus.Repositories.BookRepo;

namespace MyPerpus.Views
{
    public partial class PopUpBook : Form
    {
        private readonly IBookRepo _repo;
        private List<BookModel> _models = [];
        private BookModel? _selectedbook;
        private Formpeminjam mainForm = null;
        public PopUpBook(Form callingForm)
        {
            mainForm = callingForm as Formpeminjam;
            InitializeComponent();
            _repo = Program.ServiceProvider?.GetService<IBookRepo>()!;
        }

        private async void PopUpBuku_Load(object sender, EventArgs e)
        {
            await LoadData();
            DataGridViewLinkColumn buttonEdit = new DataGridViewLinkColumn();
            {
                buttonEdit.Name = "selectButton";
                buttonEdit.HeaderText = "Pilih";
                buttonEdit.UseColumnTextForLinkValue = true;
                buttonEdit.Text = "Pilih";
                buttonEdit.DataPropertyName = "lnkColumn";
                buttonEdit.LinkBehavior = LinkBehavior.SystemDefault;
                this.dataGridView1.Columns.Add(buttonEdit);
            }
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                this.mainForm.KodeBukuChange = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["KodeBuku"].Value);
                Formpeminjam formpeminjam = new Formpeminjam();
                Debug.WriteLine(Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Judul"].Value));
            }
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
                        dataGridView1.Rows[i].Cells[0].Value = _models[i].ID;
                        dataGridView1.Rows[i].Cells[1].Value = _models[i].Judul;
                        dataGridView1.Rows[i].Cells[2].Value = _models[i].Penulis;
                        dataGridView1.Rows[i].Cells[3].Value = _models[i].Penerbit;
                        dataGridView1.Rows[i].Cells[4].Value = _models[i].Tahun;
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
