//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP.NET_Project_Mid.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Bookings = new HashSet<Booking>();
            this.Flats = new HashSet<Flat>();
        }
    
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public int Type { get; set; }
    
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Flat> Flats { get; set; }
    }
}
