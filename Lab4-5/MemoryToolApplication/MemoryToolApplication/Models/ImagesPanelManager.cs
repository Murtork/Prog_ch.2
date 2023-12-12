using System;
using System.Windows;
using System.Windows.Controls;

namespace MemoryToolApplication.Managers
{
    internal class ImagesPanelManager
    {
        public static void UpdateLayout(Grid panel)
        {
            int imagesCount = panel.Children.Count;
            if (imagesCount > 0)
            {                
                int width = (int)Math.Max(((FrameworkElement)panel.Children[0]).ActualWidth, WidgetsCreator.Size);
                int columns = (int)(panel.ActualWidth / width);
                int rows = imagesCount / columns;
                if (rows * columns < imagesCount)
                {
                    ++rows;
                }

                for (int i = panel.RowDefinitions.Count; i < rows; ++i)
                {
                    panel.RowDefinitions.Add(new RowDefinition
                    {
                        Height = GridLength.Auto
                    });
                }
                for (int i = panel.ColumnDefinitions.Count; i < columns; ++i)
                {
                    panel.ColumnDefinitions.Add(new ColumnDefinition
                    {
                        Width = new GridLength(1, GridUnitType.Star)
                    });
                }
                if (rows < panel.RowDefinitions.Count)
                {
                    panel.RowDefinitions.RemoveRange(rows, panel.RowDefinitions.Count - rows);
                }
                if (columns < panel.ColumnDefinitions.Count)
                {
                    panel.ColumnDefinitions.RemoveRange(columns, panel.ColumnDefinitions.Count - columns);
                }

                int index = 0;
                foreach (UIElement element in panel.Children)
                {
                    int row = index / columns;
                    int col = index % columns;
                    Grid.SetRow(element, row);
                    Grid.SetColumn(element, col);
                    index++;
                }
            }
            else
            {
                panel.RowDefinitions.Clear();
                panel.ColumnDefinitions.Clear();
            }

        }
    }
}
