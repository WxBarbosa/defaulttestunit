using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultTestUnit.Domain.Entities
{
    public class Invoice : DefaultEntity
    {
        public string Code { get; set; }
        public double Total { get; set; }

        private DateTime Created
        {
            get => this.Created;
            set => this.Created = DateTime.Now;
        }

        private DateTime Updated
        {
            get => this.Updated;
            set => this.Updated = DateTime.Now;
        }
    }
}
