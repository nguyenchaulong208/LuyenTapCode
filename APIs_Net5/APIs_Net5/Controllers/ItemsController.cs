using APIs_Net5.Entities;
using APIs_Net5.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace APIs_Net5.Controllers
{
    //Định nghĩa controller này là một API Controller
    [ApiController]
    //Định nghĩa đường dẫn của controller này
    [Route("items")]
    //Kế thừa từ Controller
    public class ItemsController : Controller
    {
        
          //private readonly InMemItemsRepository repository; //=> cách này không sử dụng được
         //vì vi phạm nguyên tắc SOLID (Interface segregation principle)
        //Vì truy cập trực tiếp vào repository sẽ làm cho controller này phụ thuộc vào repository
        private readonly IInMemItemsRepository repository;
        //Tạo constructor
        public ItemsController(IInMemItemsRepository repository)
        {
         this.repository = repository;
        }
        
        //Tạo phương thức Get để lấy tất cả các mục Item
        [HttpGet]
        //Gọi phương thức GetItems() từ InMemItemsRepository
           public IEnumerable<Item> GetItems()
           {
            
                var items = repository.GetItems();
                return items;
           }
/*****************************************************************/
    //Tao phương thức Get để lấy một mục Item theo Id
        //public Item GetItem(Guid id)
        //{
        //    //Gọi phương thức GetItem() từ InMemItemsRepository
        //    var item = repository.GetItem(id);
        //    return item;
        //    //Phương thức này trả về 1 giá trị null => lỗi 204
        //    //Tìm và bắt lỗi

        //}
        public ActionResult<Item> GetItem(Guid id)
        {
            //Gọi phương thức GetItem() từ InMemItemsRepository
            var item = repository.GetItem(id);
            if (item is null)
            {
                return NotFound();
            }
            return item;
            //Phương thức này trả về 1 giá trị null => lỗi 404 Error: response status is 404

        }


    }

/*****************************************************************/
}
