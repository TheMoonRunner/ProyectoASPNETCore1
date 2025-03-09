using AspNetCoreTodo.Models;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemAsync();
    }
}
