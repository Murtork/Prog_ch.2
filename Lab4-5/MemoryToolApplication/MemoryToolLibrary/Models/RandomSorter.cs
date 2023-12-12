using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace MemoryToolLibrary.Managers
{

    public class RandomSorter
    {
        public static List<BitmapImage> CreateRandomlySortedList(List<BitmapImage> images, int minCount)
        {
            var sortedList = new SortedList<int, BitmapImage>(minCount);
            var random = new Random();
            for (int i = 0; i < Math.Max(minCount, images.Count); ++i)
            {
                sortedList.Add(random.Next(), images[i % images.Count]);
            }
            var resultList = new List<BitmapImage>(minCount);
            var enumerator = sortedList.GetEnumerator();
            while (minCount-- > 0 && enumerator.MoveNext())
            {
                resultList.Add(enumerator.Current.Value);
            }
            return resultList;
        }
    }

}
