using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomSorting
{
    public class CustomSortComparer : IComparer<object>
    {
        public int Compare(object x, object y)
        {
            if (x.GetType() == typeof(ListViewContactsInfo))
            {
                var xitem = (x as ListViewContactsInfo).ContactName;
                var yitem = (y as ListViewContactsInfo).ContactName;

                if (xitem.Length > yitem.Length)
                {
                    return 1;
                }
                else if (xitem.Length < yitem.Length)
                {
                    return -1;
                }
                else
                {
                    if (string.Compare(xitem, yitem) == -1)
                        return -1;
                    else if (string.Compare(xitem, yitem) == 1)
                        return 1;
                }
            }

            return 0;
        }
    }
}
