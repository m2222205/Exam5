using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Dal.Entities;

namespace ToDoList.Repository.ToDoItemRepository
{
    public interface IToDoItemRepository
    {
        Task<long> InsertToDoItemAsync(ToDoItem toDoItem);
        Task DeleteToDoItemByIdAsync(long id);
        Task UpdateToDoItemAsync(ToDoItem toDoItem);
        Task<ICollection<ToDoItem>> SelectAllToDoItemsAsync(int skip, int take);
        Task<ToDoItem> SelectToDoItemByIdAsync(long id);
        Task<ICollection<ToDoItem>> SelectByDueDateAsync(DateTime dueDate);
        Task<ICollection<ToDoItem>> SelectCompletedAsync(int skip, int take);
        Task<ICollection<ToDoItem>> SelectIncompleteAsync(int skip, int take);
    }
}

