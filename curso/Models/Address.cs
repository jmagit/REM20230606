﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace curso.Models
{
    /// <summary>
    /// Street address information for customers.
    /// </summary>
    [Table("Address", Schema = "SalesLT")]
    [Index("Rowguid", Name = "AK_Address_rowguid", IsUnique = true)]
    [Index("AddressLine1", "AddressLine2", "City", "StateProvince", "PostalCode", "CountryRegion", Name = "IX_Address_AddressLine1_AddressLine2_City_StateProvince_PostalCode_CountryRegion")]
    [Index("StateProvince", Name = "IX_Address_StateProvince")]
    public partial class Address
    {
        public Address()
        {
            CustomerAddresses = new HashSet<CustomerAddress>();
            SalesOrderHeaderBillToAddresses = new HashSet<SalesOrderHeader>();
            SalesOrderHeaderShipToAddresses = new HashSet<SalesOrderHeader>();
        }

        /// <summary>
        /// Primary key for Address records.
        /// </summary>
        [Key]
        [Column("AddressID")]
        public int AddressId { get; set; }
        /// <summary>
        /// First street address line.
        /// </summary>
        [Required]
        [StringLength(60)]
        public string AddressLine1 { get; set; }
        /// <summary>
        /// Second street address line.
        /// </summary>
        [StringLength(60)]
        public string AddressLine2 { get; set; }
        /// <summary>
        /// Name of the city.
        /// </summary>
        [Required]
        [StringLength(30)]
        public string City { get; set; }
        /// <summary>
        /// Name of state or province.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string StateProvince { get; set; }
        [Required]
        [StringLength(50)]
        public string CountryRegion { get; set; }
        /// <summary>
        /// Postal code for the street address.
        /// </summary>
        [Required]
        [StringLength(15)]
        public string PostalCode { get; set; }
        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [InverseProperty("Address")]
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
        [InverseProperty("BillToAddress")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaderBillToAddresses { get; set; }
        [InverseProperty("ShipToAddress")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaderShipToAddresses { get; set; }
    }
}