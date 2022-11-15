﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerDataGridSampleWithDataChart.Data.Models
{
    /// <summary>
    /// 売上明細モデル
    /// </summary>
    [Table("SalesDetails")]
    public class SalesDetail
    {
        [Key]
        public int Id { get; set; }

        public int SlipNumber { get; set; }

        public int RowNumber { get; set; }

        public string ItemCode { get; set; }

        public string ItemName { get; set; }

        public decimal Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Amount { get; set; }

        public decimal SalesTax { get; set; }

        [Timestamp]
        public byte[] TimeStamp { get; set; }
    }
}
