using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Threading.Tasks;
using CrawData;



namespace CrawData;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        //Add Item to TreeView
        ObservableCollection<MenuItem> menuItems = new ObservableCollection<MenuItem>();
        MenuItem items = new MenuItem() { name = "Google Data",URL = "Google", Items = new ObservableCollection<MenuItem>() 
            {
                new MenuItem(){ name = "Sub Item 1", URL = "URL 1" },
                new MenuItem(){ name = "Sub Item 2", URL = "URL 2" },
                new MenuItem(){ name = "Sub Item 3", URL = "URL 3" },
            }
        };
        //Add item vao menuItems
        menuItems.Add(items);
        //Gan menuItems vao TreeView
        treeMain.ItemsSource = menuItems; //Tuy nhien van chua hien thi duoc tren TreeView, vi ta chua tao template de hien thi du lieu trong TreeView

        
        
    }
}
