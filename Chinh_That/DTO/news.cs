//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chinh_That.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class news
    {
        public int id { get; set; }
        public Nullable<int> category_id { get; set; }
        public string title { get; set; }
        public byte[] image_url { get; set; }
        public string content { get; set; }
        public System.DateTime create_date { get; set; }
    
        public virtual game_category game_category { get; set; }
    }
}