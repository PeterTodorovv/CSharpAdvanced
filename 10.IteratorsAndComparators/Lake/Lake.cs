using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lake
{
    class Lake: IEnumerable<int>
    {
        private int[] fullPath;

        private int startIndex;
        public Lake(int[] fullPath)
        {
            this.fullPath = fullPath;

            if (fullPath.Length % 2 == 0)
                startIndex = fullPath.Length - 1;
            else
                startIndex = fullPath.Length - 2;
        }

        

        public IEnumerator<int> GetEnumerator()
        {
            for(int i = 0; i < fullPath.Length; i += 2)
            {
                yield return fullPath[i];
            }

            for(int i = startIndex; i >= 0; i-= 2)
            {
                yield return fullPath[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
