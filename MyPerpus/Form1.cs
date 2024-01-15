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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click
    }
}
