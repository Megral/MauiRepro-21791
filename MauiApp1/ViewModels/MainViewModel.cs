using MauiApp1.Models;
using System;
using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp1.ViewModels
{
    internal class MainViewModel: ObservableObject
    {
        List<List<ModelGroup>> ggParameters = new List<List<ModelGroup>>();

        public RelayCommand<int> AddTestCommand { get; }

        public MainViewModel()
        {
            AddTestCommand = new RelayCommand<int>(AddTest);
            ggParameters.Add(new List<ModelGroup>
            {
                
                new ModelGroup("group1", new List<Model>
                {
                    new Model(),
                    new Model(),
                    new Model(),
                }),
                new ModelGroup("group2", new List<Model>
                {
                    new Model(),
                    new Model(),
                    new Model(),
                }),
            });
            B.Add(new GroupButton("Class1", 0, new RelayCommand<int>(ChangeShowedClass)));

            ggParameters.Add(new List<ModelGroup>
            {
                new ModelGroup("group3", new List<Model>
                {
                    new Model(),
                    new Model(),
                    new Model(),
                }),
                new ModelGroup("group4", new List<Model>
                {
                    new Model(),
                    new Model(),
                    new Model(),
                }),
            });
            B.Add(new GroupButton("Class2", 1, new RelayCommand<int>(ChangeShowedClass)));

            foreach (ModelGroup group in ggParameters[0])
            {
                A.Add(group);
            }

            C.Add("111");
        }

        private ObservableCollection<ModelGroup> _A = new ObservableCollection<ModelGroup>();
        public ObservableCollection<ModelGroup> A
        {
            get => _A;
            set
            {
                _A = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<GroupButton> _B = new ObservableCollection<GroupButton>();
        public ObservableCollection<GroupButton> B
        {
            get => _B;
            set
            {
                _B = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<string> _C = new ObservableCollection<string>();
        public ObservableCollection<string> C
        {
            get => _C;
            set
            {
                _C = value;
                OnPropertyChanged();
            }
        }

        private int _TestInt = 0;
        public int TestInt
        {
            get => _TestInt;
            set
            {
                _TestInt = value;
                OnPropertyChanged();
            }
        }

        private void ChangeShowedClass(int index)
        {
            A.Clear();

            foreach (ModelGroup group in ggParameters[index])
            {
                A.Add(group);
            }
        }

        private void AddTest(int index)
        {
            if (index == 0) 
            {
                C.Add("1111");
            }
            else
            {
                C.Add("2222");
            }
        }
    }
}
