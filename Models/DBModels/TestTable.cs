using System;
using System.Collections.Generic;

namespace DotnetCoreHandByHand.Models.DBModels
{
    public partial class TestTable
    {
        public Guid ID { get; set; }
        public string ColumnName1 { get; set; }
        public string ColumnName2 { get; set; }
    }
}