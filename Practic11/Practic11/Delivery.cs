//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practic11
{
    using System;
    using System.Collections.Generic;
    
    public partial class Delivery
    {
        public int delivery_id { get; set; }
        public Nullable<int> order_id { get; set; }
        public string delivery_status { get; set; }
        public Nullable<System.DateTime> estimated_delivery_date { get; set; }
    
        public virtual Orders Orders { get; set; }
    }
}
