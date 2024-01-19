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
        }

        private async void iconButton3_Click(object sender, EventArgs e)
        {
            await AddData();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

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
                    Penulis = textBox3.Text,
                    Judul = textBox1.Text,
                    Penerbit = textBox2.Text,
                    Tahun = 2000
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
                        dataGridView1.Rows[i].Cells[2].Value = _models[i].Judul;
                        dataGridView1.Rows[i].Cells[3].Value = _models[i].Penerbit;
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
