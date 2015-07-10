# MultiSelectTreeView
Inherits from standard WPF TreeView and adds functionality for selecting multiple TreeViewItems.

This control is based on the following blog post:
http://chrigas.blogspot.de/2014/08/wpf-treeview-with-multiple-selection.html

Thanks to Christoph Gattnar for providing the basics!

Differences in this control in regard to the blog post:
* MultiSelectTreeView inherits WPF TreeView instead of attaching behavior
* Support from keyboard selection in addition to mouse selection
* Support for SHIFT + CTRL selection

For usage example, see the TreeViewDemo project.
