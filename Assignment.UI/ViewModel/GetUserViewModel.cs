using Assignment.Model;
using Assignment.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Assignment.UI.ViewModel
{
    public class GetUserViewModel : INotifyPropertyChanged
    {
        private List<User> users;
        readonly UserService service = new UserService();

        public GetUserViewModel()
        {

        }


        public RelayCommand SearhUser
        {
            get
            {
                return new RelayCommand(async userId =>
                {
                    if (int.TryParse(userId.ToString(), out var id))
                    {
                        Users = await service.GetUsers(id) as List<User>;

                    }
                    else
                    {
                        MessageBox.Show($"Invalid user id {userId} entered.");
                        Users = new List<User>();
                    }
                });
            }
        }

        public List<User> Users
        {
            get => users;
            set
            {
                users = value;
                RaisePropertyChanged();
            }
        }

        public List<Lookup> Departments { get; set; } = new List<Lookup> {
                new Lookup(1, "Computer Science"),
                new Lookup(2, "Engineering"),
                new Lookup(3, "Physics"),
                new Lookup(4, "Agriculture")
            };

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
