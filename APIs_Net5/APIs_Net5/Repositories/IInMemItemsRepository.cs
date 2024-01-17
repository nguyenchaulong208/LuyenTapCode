using APIs_Net5.Entities;

namespace APIs_Net5.Repositories
{
    public interface IInMemItemsRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
        //Tạo phương thức CreateItem
    }
}
