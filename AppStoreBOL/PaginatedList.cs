using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreBOL
{
    public class PaginatedList<T> :List<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }

        public PaginatedList(List<T> source, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            var count = source.Count;
            TotalPages = (int)Math.Ceiling(count /(double) pageSize);
            var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            this.AddRange(items);
        }
        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
            
        }
        public bool HasNextPage
        {
            get { return (PageIndex < TotalPages); }
        }
    }
}
