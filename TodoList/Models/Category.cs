using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Models
{
    // Kategori tablosunun Id alanı int olsun
    public sealed class Category : Entity<int>
    {
        public string Name { get; set; }
    }
}
