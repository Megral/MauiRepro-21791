using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class Model
    {
        public string Name { get; set; }

        public Model()
        {
            Name = "-";
        }
    }

    public class ModelGroup : List<Model>
    {
        public string GroupName { get; set; }

        public ModelGroup(string groupName, List<Model> models) : base(models)
        {
            GroupName = groupName;
        }
    }

    public class GroupButton : ObservableObject
    {
        public string ButtonName { get; set; }
        public int ButtonNum { get; set; }

        public RelayCommand<int> ButtonCommand { get; set; }

        public GroupButton(string button_name, int button_num, RelayCommand<int> button_command)
        {
            ButtonName = button_name;
            ButtonNum = button_num;
            ButtonCommand = button_command;
        }
    }
}
