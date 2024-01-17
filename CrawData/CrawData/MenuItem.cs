using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawData
{
    // Class MenuItem: Add Item to TreeView
    public class MenuItem
    {
        //Constructor
        //Phai dong goi lai thanh cac property thi moi add vao TreeView duoc
        //Vi TreeView se lay cac property nay lam cac node chu khong lay cac field
        //Cac Item nay se dai dien cho cac node trong TreeView
        public string name { get; set; }
       public string URL { get; set; }
        //Them thu vien System.Collections.ObjectModel tai vi su dung TreeView cua WPF.
        //Moi Node se co cac Node con, nen ta phai dung c de luu cac Node con
        # region ObservableCollection

        //ObservableCollection
        //Lớp Generic ObservableCollection<T> là một tập hợp tương tự như List<T> ..., tức là nó mô tả một tập hợp dữ liệu 
        //có thể thay đổi số lượng bằng các phương thức quen thuộc như Add(), Remove(), Clear() ...
        //Nhưng với ObservableCollection<T> thì nó cung cấp thêm sự kiện thông báo như số lượng phần tử thay đổi như thêm, bớt ...
        //(nghĩa là giám sát được biến động phần tử). Các sự kiện event này có tên là CollectionChanged, trong tham số mà sự kiện gửi đến,
        //e.Action có cho biết hành động thay đổi trên tập hợp là gì (ví dụ: thêm NotifyCollectionChangedAction.Add, bớt NotifyCollectionChangedAction.Remove),
        //clear tập hợp NotifyCollectionChangedAction.Reset ...

        //Ứng dụng của ObservableCollection trong WPF rất phổ biến khi binding với một controller như TreeView, ListView, DataGrid ...
        //Khi đó việc thay đổi số phần tử trong tập hợp, thì hiện thị trong các controller cũng tự thêm / bớt ... theo.
        //Khi bạn kết hợp dùng INotifyPropertyChanged để xây dựng phần tử trong tập hợp, thì thay đổi thuộc tính của phần tử cũng tự động cập nhật vào các controller
        #endregion

        public ObservableCollection<MenuItem> Items { get; set; }
        public MenuItem()
        {
            this.Items = new ObservableCollection<MenuItem>();
            
        }   
    }
}
