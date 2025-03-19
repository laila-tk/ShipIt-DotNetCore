﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using ShipIt.Models.DataModels;

namespace ShipIt.Models.ApiModels
{
    public class InboundOrderResponse
    {
        public Employee OperationsManager { get; set; }
        public int WarehouseId { get; set; }
        public IEnumerable<OrderSegment> OrderSegments { get; set; }
    }

    public class OrderSegment
    {
        public List<InboundOrderLine> OrderLines { get; set; }
        public Company Company { get; set; }
    }

    public class StockProduct :DataModel
    {
        [DatabaseColumnName("p_id")]
        public int ProductId { get; set; }

        [DatabaseColumnName("gtin_cd")]
        public string Gtin { get; set; }

        [DatabaseColumnName("gtin_nm")]
        public string Name { get; set; }

        [DatabaseColumnName("l_th")]
        public int LowerThreshold { get; set; }

        [DatabaseColumnName("min_qt")]
        public int MinimumOrderQuantity { get; set; }

        [DatabaseColumnName("hld")]
        public int Held { get; set; }

        [DatabaseColumnName("gcp_cd")]
        public string Gcp { get; set; }

        [DatabaseColumnName("gln_nm")]
        public string CompanyName { get; set; }

        [DatabaseColumnName("gln_addr_02")]
        public string Addr2 { get; set; }

        [DatabaseColumnName("gln_addr_03")]
        public string Addr3 { get; set; }

        [DatabaseColumnName("gln_addr_04")]
        public string Addr4 { get; set; }

        [DatabaseColumnName("gln_addr_postalcode")]
        public string PostalCode { get; set; }

        [DatabaseColumnName("gln_addr_city")]
        public string City { get; set; }

        [DatabaseColumnName("contact_tel")]
        public string Tel { get; set; }

        [DatabaseColumnName("contact_mail")]
        public string Mail { get; set; }

        public StockProduct(IDataReader dataReader): base(dataReader) { }


    }

}