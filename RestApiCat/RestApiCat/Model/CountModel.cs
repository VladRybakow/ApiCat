using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiCat.Model
{
    public class CountModel
    {
        public int count { get; set; }
        public List<EntryModel> entries { get; set; }
    }
}
