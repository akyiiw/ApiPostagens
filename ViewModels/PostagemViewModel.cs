using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPostagens.ViewModels
{
    internal partial class PostagemViewModel : ObservableObject
    {
        [ObservableProperty]
        public int userId;
        [ObservableProperty]
        public int id;
        [ObservableProperty]
        public string title;
        [ObservableProperty]
        public string body;
    }
}
