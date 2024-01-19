using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using MyPerpus.Models;
using MyPerpus.Repositories.BookRepo;
using MyPerpus.Repositories.UserRepo;

namespace MyPerpus.Views
{
    public partial class Formbuku : Form
    {
        private readonly IBookRepo _repo;
        private List<BookModel> _models = [];
        private BookModel? _selectedbook;
        public Formbuku()
        {
            InitializeComponent();
            _repo = Program.ServiceProvider?.GetService<IBookRepo>()!;
        }

        private async void Formbuku_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("SAJSAK");
            await LoadData();
            DataGridViewLinkColumn buttonEdit = new DataGridViewLinkColumn();
            {
                buttonEdit.Name = "editButton";
                buttonEdit.HeaderText = "Edit";
                buttonEdit.UseColumnTextForLinkValue = true;
                buttonEdit.Text = "Edit";
                buttonEdit.DataPropertyName = "lnkColumn";
                buttonEdit.LinkBehavior = LinkBehavior.SystemDefault;
                this.dataGridView1.Columns.Add(buttonEdit);
            }

            DataGridViewLinkColumn buttonDelete = new DataGridViewLinkColumn();
            {
                buttonDelete.Name = "deleteButton";
                buttonDelete.HeaderText = "Delete";
                buttonDelete.UseColumnTextForLinkValue = true;
                buttonDelete.Text = "Delete";
                buttonDelete.DataPropertyName = "lnkColumn";
                buttonDelete.LinkBehavior = LinkBehavior.SystemDefault;
                this.dataGridView1.Columns.Add(buttonDelete);
            }
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                textBoxKodeBuku.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["KodeBuku"].Value);
                textBoxJudul.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Judul"].Value);
                textBoxPenulis.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Penulis"].Value);
                textBoxPenerbit.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Penerbit"].Value);
                textBoxTahun.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Tahun"].Value);
                Debug.WriteLine("Edit");
            }
            else if (e.ColumnIndex == 6)
            {
                await DeleteData(Guid.Parse(Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["KodeBuku"].Value)));
            }
        }

        private async void iconButton3_Click(object sender, EventArgs e)
        {
            await UpdateData();
        }

        private async void iconButton2_Click(object sender, EventArgs e)
        {
            await AddData();
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private async Task AddData() 
        {
            try
            {
                var newBook = new BookModel
                {
                    ID = Guid.NewGuid(),
                    Penulis = textBoxPenulis.Text,
                    Judul = textBoxJudul.Text,
                    Penerbit = textBoxPenerbit.Text,
                    Tahun = int.Parse(textBoxTahun.Text)
                };
                await _repo.Add(newBook);
                await LoadData();
            }
            catch { throw; }
        }

        private async Task UpdateData()
        {
            try
            {
                var updateBook = new BookModel
                {
                    ID = Guid.Parse(textBoxKodeBuku.Text),
                    Penulis = textBoxPenulis.Text,
                    Judul = textBoxJudul.Text,
                    Penerbit = textBoxPenerbit.Text,
                    Tahun = int.Parse(textBoxTahun.Text)
                };
                await _repo.Update(updateBook);
                await LoadData();
            }
            catch { throw; }
        }

        private async Task DeleteData(Guid id)
        {
            await _repo.Delete(id);
            await LoadData();
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
