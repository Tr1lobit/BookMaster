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
    
    public partial class BookSubject
    {
        public int BookSubjectId { get; set; }
        public int Bookld { get; set; }
        public int Subjectld { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Subject Subject { get; set; }
    }
}