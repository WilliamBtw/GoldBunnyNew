//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GoldBunny.basedata
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int IDOrder { get; set; }
        public int ClientID { get; set; }
        public int PetID { get; set; }
        public int ServiceID { get; set; }
        public int StaffID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> IDRoom { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Pet Pet { get; set; }
        public virtual Service Service { get; set; }
        public virtual Staff Staff { get; set; }
    }
}