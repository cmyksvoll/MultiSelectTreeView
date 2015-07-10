using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace TreeViewDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            SelectedNodes = new ObservableCollection<TreeItemViewModel>();
            SelectedNodes.CollectionChanged += SelectedNodes_CollectionChanged;

            RootNodes = BuildTreeModel();

            InitializeComponent();
        }

        private static List<TreeItemViewModel> BuildTreeModel()
        {
            return new List<TreeItemViewModel>
            {
                new TreeItemViewModel("Node 1")
                {
                    IsExpanded = true,
                    Children = new List<TreeItemViewModel>
                    {
                        new TreeItemViewModel("Node 1.1"),
                        new TreeItemViewModel("Node 1.2")
                        {
                            Children = new List<TreeItemViewModel>
                            {
                                new TreeItemViewModel("Node 1.2.1"),
                                new TreeItemViewModel("Node 1.2.2"),
                                new TreeItemViewModel("Node 1.2.3"),
                                new TreeItemViewModel("Node 1.2.4"),
                                new TreeItemViewModel("Node 1.2.5"),
                                new TreeItemViewModel("Node 1.2.6")
                            }
                        }
                    }
                },
                new TreeItemViewModel("Node 2")
                {
                    Children = new List<TreeItemViewModel>
                    {
                        new TreeItemViewModel("Node 2.2.1"),
                        new TreeItemViewModel("Node 2.2.2"),
                        new TreeItemViewModel("Node 2.2.3"),
                        new TreeItemViewModel("Node 2.2.4")
                    }
                }
            };
        }

        public List<TreeItemViewModel> RootNodes { get; set; }

        public ObservableCollection<TreeItemViewModel> SelectedNodes { get; set; }

        void SelectedNodes_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            NumberOfSelectedNodes.Text = SelectedNodes.Count.ToString();
        }
    }
}
