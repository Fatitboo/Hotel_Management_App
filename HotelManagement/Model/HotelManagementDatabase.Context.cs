﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelManagement.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HotelManagementEntities1 : DbContext
    {
        public HotelManagementEntities1()
            : base("name=HotelManagementEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Furniture> Furnitures { get; set; }
        public virtual DbSet<FurnitureReceipt> FurnitureReceipts { get; set; }
        public virtual DbSet<FurnitureStorage> FurnitureStorages { get; set; }
        public virtual DbSet<GoodsReceipt> GoodsReceipts { get; set; }
        public virtual DbSet<GoodsStorage> GoodsStorages { get; set; }
        public virtual DbSet<RentalContract> RentalContracts { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomCustomer> RoomCustomers { get; set; }
        public virtual DbSet<RoomFurnituresDetail> RoomFurnituresDetails { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceUsing> ServiceUsings { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Trouble> Troubles { get; set; }
        public virtual DbSet<TroubleByCustomer> TroubleByCustomers { get; set; }
    }
}
