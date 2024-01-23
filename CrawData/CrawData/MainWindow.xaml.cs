using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Threading.Tasks;
using CrawData;
using System.Net.Http;
using System;
using System.Text.RegularExpressions;
using System.Net;
using System.Diagnostics;

namespace CrawData;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    ObservableCollection<MenuItem> TreeItems;
    string HomePage = "https://www.howkteam.com/";

    HttpClient httpClient;
    HttpClientHandler handler;
    CookieContainer cookie = new CookieContainer();
    public MainWindow()
    {
        InitializeComponent();
        //Su dung HttpClient de lay html cua trang web
        httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri("https://www.howkteam.vn/"); //Set Base Drictory cho HttpClient. Day la level 2 cua Crawl Data. Tiep theo la phan 3

        //Add Item to TreeView
        ObservableCollection<MenuItem> menuItems = new ObservableCollection<MenuItem>();
        //MenuItem items = new MenuItem() { name = "Google Data",URL = "Google", Items = new ObservableCollection<MenuItem>() 
        //    {
        //        new MenuItem(){ name = "Sub Item 1", URL = "URL 1" },
        //        new MenuItem(){ name = "Sub Item 2", URL = "URL 2" },
        //        new MenuItem(){ name = "Sub Item 3", URL = "URL 3" },
        //    }
        //};
        ////Add item vao menuItems
        //menuItems.Add(items);
        //Gan menuItems vao TreeView
        treeMain.ItemsSource = menuItems; //Tuy nhien van chua hien thi duoc tren TreeView, vi ta chua tao template de hien thi du lieu trong TreeView

        
        
    }
    //Tu duong dan dua vao se tra ra html cua trang web
    string CrawlDataFromURL(string url)
    {
        string html = "";
        //HttpClient httpClient = new HttpClient(); //Su dung HttpClient de lay html cua trang web. Khi khai basso httpClient nay o day thi se khong the su dung duoc httpClient o tren nua, vi httpClient o tren la bien toan cuc
        html = httpClient.GetStringAsync(url).Result; //Lay toan bo source code cua trang web => Day la buoc co ban de lay duoc du lieu cua trang web

        return html;
        //Tam dung doan code nay, chung ta se tiep tuc vao phan sau
    }
    #region methods
    void IniHttpClient()
    {
        handler = new HttpClientHandler
        {
            CookieContainer = cookie,
            ClientCertificateOptions = ClientCertificateOption.Automatic,
            AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
            AllowAutoRedirect = true,
            UseDefaultCredentials = false
        };

        httpClient = new HttpClient(handler);

        //httpClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/63.4.154 Chrome/57.4.2987.154 Safari/537.36");
        /*
         * Header:
         * - Origin
         * - Host
         * - Referer
         * - :scheme
         * - accept
         * - Accept-Encoding
         * - Accept-Language
         * - User-Argent
         */


        httpClient.BaseAddress = new Uri(HomePage);
    }
    #endregion
    void AddItemIntoTreeViewItem(ObservableCollection<MenuItem> root, MenuItem node)
    {
        treeMain.Dispatcher.Invoke(new Action(() => {
            root.Add(node);
        }));
    }
    void Crawl(string url)
    {
        string htmlLearn = CrawlDataFromURL(url);
       var CourseList = Regex.Matches(htmlLearn,@"<div class""otions-container(.?)</div>",RegexOptions.Singleline);
        foreach (var course in CourseList)
        {
           string CourseName = Regex.Match(course.ToString(), @"(?=<h4>).*?(?=</h4>)").Value.Replace("<h5>","");
            string linkCourse = Regex.Match(course.ToString(), @"'(.?)'").Value.Replace("'", "");

            MenuItem items = new MenuItem();
            items.name = CourseName;
            items.URL = url;
            AddItemIntoTreeViewItem(TreeItems, items);
        }
    }
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        Crawl("Learn"); //Hien thi html cua trang web howkteam.vn len txtBox (TextBox)
        
    }

    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
       
    }

    private void Button_Click_2(object sender, RoutedEventArgs e)
    {
        string url = HomePage + (sender as Button).Tag.ToString();
        //wbMain.Navigate(url);
        Process.Start(url);
    }
}
