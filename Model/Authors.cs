//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Boolmaster_Samodin.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Authors
    {
        public Authors()
        {
            this.BookAuthor = new HashSet<BookAuthor>();
        }
    
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public Nullable<System.DateTime> BrithDate { get; set; }
        public Nullable<System.DateTime> DeathDate { get; set; }
        public string Wikipedia { get; set; }
    
        public virtual ICollection<BookAuthor> BookAuthor { get; set; }
    }
}
