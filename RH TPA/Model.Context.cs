﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RH_TPA
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Patrick_Hotel_DatabaseEntities : DbContext
    {
        public Patrick_Hotel_DatabaseEntities()
            : base("name=Patrick_Hotel_DatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BrunchTicket> BrunchTicket { get; set; }
        public virtual DbSet<Dishes> Dishes { get; set; }
        public virtual DbSet<DishesRequest> DishesRequest { get; set; }
        public virtual DbSet<Food> Food { get; set; }
        public virtual DbSet<FundRequest> FundRequest { get; set; }
        public virtual DbSet<Guest> Guest { get; set; }
        public virtual DbSet<Ingredient> Ingredient { get; set; }
        public virtual DbSet<MinibarItems> MinibarItems { get; set; }
        public virtual DbSet<OrderHeader> OrderHeader { get; set; }
        public virtual DbSet<PaymentDetail> PaymentDetail { get; set; }
        public virtual DbSet<PurchaseRequest> PurchaseRequest { get; set; }
        public virtual DbSet<PurchaseRequestReason> PurchaseRequestReason { get; set; }
        public virtual DbSet<Reservation> Reservation { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<RecipeDish> RecipeDish { get; set; }
        public virtual DbSet<RecipeFood> RecipeFood { get; set; }
        public virtual DbSet<RaiseRequest> RaiseRequest { get; set; }
        public virtual DbSet<Evidence> Evidence { get; set; }
        public virtual DbSet<Candidate> Candidate { get; set; }
        public virtual DbSet<Resignation> Resignation { get; set; }
        public virtual DbSet<GuestReviewReport> GuestReviewReport { get; set; }
        public virtual DbSet<PurchaseReport> PurchaseReport { get; set; }
        public virtual DbSet<SalesReport> SalesReport { get; set; }
    }
}
