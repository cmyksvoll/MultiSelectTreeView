using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;

namespace TreeViewDemo
{
    public class TreeItemViewModel : INotifyPropertyChanged
    {
        public TreeItemViewModel(string displayName)
        {
            DisplayName = displayName;
        }

        private bool _isExpanded;
        private bool _isSelected;

        public string DisplayName { get; set; }

        public bool IsExpanded
        {
            get { return _isExpanded; }
            set
            {
                _isExpanded = value;
                OnPropertyChanged(() => IsExpanded);
            }
        }

        public virtual bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                OnPropertyChanged(() => IsSelected);
            }
        }

        public List<TreeItemViewModel> Children { get; set; }        

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged<T>(Expression<Func<T>> propertyExpression)
        {
            var body = propertyExpression.Body as MemberExpression;
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(body.Member.Name));
        }
    }
}