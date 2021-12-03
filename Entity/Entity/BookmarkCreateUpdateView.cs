using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class BookmarkCreateUpdateView
    {
        public Bookmark Bookmark { get; set; }
        public virtual List<Category> CategoryList { get; set; }
    }
}
