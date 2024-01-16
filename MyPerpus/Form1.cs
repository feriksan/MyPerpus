using System.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using MyPerpus.Models;
using MyPerpus.Repositories.UserRepo;

namespace MyPerpus
{
    public partial class Form1 : Form
    {
        private readonly IUserRepo _userRepo;
        private List<UserModel> _users = [];
        private UserModel? _selecteduser;

        public Form1()
        {
            InitializeComponent();
            _userRepo = Program.ServiceProvider?.GetService<IUserRepo>()!;
            textEmail.Text = "JSAJJ";
            iconButton1.Text = "OK";
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("SAJSAK");
            var newUser = new UserModel
            {
                ID = Guid.NewGuid(),
                Username = "CACA2",
                Email = "Caca3@gmail.com",
                Password = "JSAKSAJSAK",
                IsAdmin = false,
            };
            await _userRepo.Add(newUser);
            await LoadDataUsers();
        }

        private async Task LoadDataUsers()
        {
            try
            {
                _users = await _userRepo.GetAll();
                dataGridUser.Rows.Clear();
                if (_users.Count > 0)
                {
                    // Menambahkan baris sesuai jumlah data
                    dataGridUser.Rows.Add(_users.Count);
                    for (int i = 0; i < _users.Count; i++)
                    {
                        dataGridUser.Rows[i].Cells[0].Value = i + 1;
                        dataGridUser.Rows[i].Cells[1].Value = _users[i].Username;
                        dataGridUser.Rows[i].Cells[2].Value = _users[i].Email;
                        dataGridUser.Rows[i].Cells[3].Value = _users[i].IsAdmin;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            textEmail.Text = "JSASAKSK";
            Debug.WriteLine("SASA");
        }

    }
}
