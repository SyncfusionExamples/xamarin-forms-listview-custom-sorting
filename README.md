# xamarin-forms-listview-custom-sorting
Xamarin Forms ListView provides support to custom sort the items using Comparer.

## Sample

```xaml
<sync:SfListView x:Name="listView"
                    ItemSize="70" 
                    FocusBorderThickness="0"
                    SelectionBackgroundColor="#ECECEC" IsScrollBarVisible="False"
                    ItemsSource="{Binding ContactsInfo}">
    
    <sync:SfListView.DataSource>
        <dataSource:DataSource>
            <dataSource:DataSource.SortDescriptors>
                <dataSource:SortDescriptor>
                    <dataSource:SortDescriptor.Comparer>
                        <local:CustomSortComparer/>
                    </dataSource:SortDescriptor.Comparer>
                </dataSource:SortDescriptor>
            </dataSource:DataSource.SortDescriptors>
        </dataSource:DataSource>
    </sync:SfListView.DataSource>
    
    <sync:SfListView.ItemTemplate>
        <DataTemplate>
            <ViewCell>
                <ViewCell.View>
                    <code>
                    . . .
                    . . .
                    <code>
                </ViewCell.View>
            </ViewCell>
        </DataTemplate>
    </sync:SfListView.ItemTemplate>
</sync:SfListView>

CustomSortComparer:
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
```
