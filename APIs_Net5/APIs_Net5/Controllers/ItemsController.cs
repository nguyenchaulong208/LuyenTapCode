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
        
            private readonly InMemItemsRepository repository;
        //Tạo constructor
            public ItemsController()
            {
                repository = new InMemItemsRepository();

            }
        //Tạo phương thức Get để lấy tất cả các mục Item
        [HttpGet]
           public IEnumerable<Item> GetItems()
           {
            //Gọi phương thức GetItems() từ InMemItemsRepository
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
