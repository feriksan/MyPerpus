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
            if (e.ColumnIndex == 6)
            {
                textNIM.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["NIM"].Value);
                textNama.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Nama"].Value);
                textJurusan.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Jurusan"].Value);
                textHp.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["NoHP"].Value);
                textAlamat.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Alamat"].Value);
                Debug.WriteLine("Edit");
            }
            else if (e.ColumnIndex == 7)
            {
                await DeleteData(Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["NIM"].Value));
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("TEst");
        }

        private async void iconButton3_Click(object sender, EventArgs e)
        {
            await AddData();
        }

        private async void iconButton2_Click(object sender, EventArgs e)
        {
            await UpdateData();
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

        private async Task UpdateData()
        {
            try
            {
                var updateAnggota = new AnggotaModel
                {
                    ID = textNIM.Text,
                    Nama = textNama.Text,
                    Jurusan = textJurusan.Text,
                    NoHp = textHp.Text,
                    Alamat = textAlamat.Text
                };
                await _repo.Update(updateAnggota);
                await LoadData();
            }
            catch { throw; }
        }
        private async Task DeleteData(string id)
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
                        dataGridView1.Rows[i].Cells[0].Value = i + 1;
                        dataGridView1.Rows[i].Cells[1].Value = _models[i].ID;
                        dataGridView1.Rows[i].Cells[2].Value = _models[i].Nama;
                        dataGridView1.Rows[i].Cells[3].Value = _models[i].NoHp;
                        dataGridView1.Rows[i].Cells[4].Value = _models[i].Alamat;
                        dataGridView1.Rows[i].Cells[5].Value = _models[i].Jurusan;
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
