using APIs_Net5.Entities;

namespace APIs_Net5.Repositories
{
    public class InMemItemsRepository
    {
        //Create a list of Item
        //thiết lập một danh sách các Item (đối tượng) với từ khóa private readonly
        //với mục đích chỉ đọc và không thề thay đổi thuộc tính
        /*------------------------------------------------------------*/
        //The line of code you provided initializes a private field named items as a read-only List<Item> in C#
        private readonly List<Item> items = new()
        {
            /*
               * private: This keyword defines the access level of the field items. It restricts the access to this field to only the containing class or struct, and it cannot be accessed from outside the class directly.
               * readonly: This keyword indicates that the field items can only be assigned a value during its declaration or within the constructor of the containing class. Once initialized, its value cannot be changed.
               * List<Item>: This declares the type of the field as a generic List that holds objects of type Item.
               * items: This is the name of the private field.
               * = new();: This initializes the items field with a new instance of List<Item>. The new() syntax is a C# 9 feature called "target-typed new expressions," which allows you to omit the type when using new, and the compiler infers the type based on the context (in this case, List<Item>).
               * This line of code creates a private, read-only field items that holds a list of Item objects. Once the items field is initialized, it cannot be reassigned to a different list, but its contents (the Item objects within the list) can be modified.
             */
            //Create a list of Item
            //Đây là cách khai báo một danh sách Contructor ngắn gọn của các thuoctính của Item
            new Item { Id = Guid.NewGuid(), Name = "Potion", Price = 9, CreatedDate = DateTimeOffset.UtcNow },
            /*
                Id = Guid.NewGuid() khởi tạo ID ngau nhiên
                Name = "Potion" khởi tạo tên là Potion
                Price = 9 khởi tạo giá là 9
                CreatedDate = DateTimeOffset.UtcNow khởi tạo ngày giờ hiện tại
            */
            new Item { Id = Guid.NewGuid(), Name = "Iron Sword", Price = 20, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Bronze Shield", Price = 18, CreatedDate = DateTimeOffset.UtcNow }
        };
        /*------------------------------------------------------------*/
        /*
         * Làm thế nào để chúng ta có được 1 món đồ?
         * Làm thế nào chúng ta có 1 danh sách các món đồ?
         * Làm thế nào để chúng ta có 1 bản cập nhật các mục, xóa các mục?
         */
        
        //Tạo một phương thức để lấy tất cả các mục
        public IEnumerable<Item> GetItems()
        {
            //IEnumerable<T> là một giao diện được sử dụng để liệt kê các phần tử của một tập hợp.
            return items;
            //Trả về danh sách các Item
        }
        //Tạo một phương thức để lấy một mục
        public Item GetItem(Guid id)
        {
            return items.Where(item => item.Id == id).SingleOrDefault();
            /*
             * Cách viết trên là 1 biểu thức lambda:
                *SingleOrDefault() trả về phần tử duy nhất của một tập hợp hoặc giá trị mặc định nếu tập hợp không có phần tử nào.
                *Where() trả về các phần tử của một tập hợp thỏa mãn một điều kiện nhất định.
                *item => item.Id == id là một biểu thức lambda
                *item là một tham số đầu vào của biểu thức lambda
                *item.Id == id là một biểu thức điều kiện
            */
           
        }

    }
}
