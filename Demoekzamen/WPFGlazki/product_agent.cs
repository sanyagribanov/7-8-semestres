//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfGlazkiSave
{
    using System;
    using System.Collections.Generic;
    
    public partial class product_agent
    {
        public int Id { get; set; }
        public int name_production { get; set; }
        public string type_production { get; set; }
        public int articul { get; set; }
        public byte num_of_personal { get; set; }
        public byte num_of_manufactory { get; set; }
        public decimal min_price_for_agent { get; set; }
        public int agentsId { get; set; }
    
        public virtual agents agents { get; set; }
    }
}
