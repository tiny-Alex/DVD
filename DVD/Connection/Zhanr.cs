//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DVD.Connection
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zhanr
    {
        public Zhanr()
        {
            this.Film_Zhanr = new HashSet<Film_Zhanr>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Film_Zhanr> Film_Zhanr { get; set; }
    }
}
