using System.Collections.Generic;

namespace WebApplication4.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
