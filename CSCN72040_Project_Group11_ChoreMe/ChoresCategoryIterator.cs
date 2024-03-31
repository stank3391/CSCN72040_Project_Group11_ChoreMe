using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreMe
{
    internal class ChoresCategoryIterator : Iterator<Chore>
    {
        Dictionary<string, List<Chore>> choreCategories = new Dictionary<string, List<Chore>>();
        private List<string> categoryKeys = new List<string>();
        private int currentCategory = 0;
        private int currentChore = 0;

        public ChoresCategoryIterator(List<Chore> list)
        {
            foreach (Chore chore in list)
            {
                if (!choreCategories.ContainsKey(chore.Category))
                {
                    choreCategories.Add(chore.Category, new List<Chore>());
                    categoryKeys.Add(chore.Category);
                }
                choreCategories[chore.Category].Add(chore);
            }
        }
        public Chore Next()
        {
            if (currentChore > choreCategories[categoryKeys[currentCategory]].Count -1)
            {
                if (currentCategory > categoryKeys.Count -1)
                {
                    currentCategory++;
                    currentChore = 0;
                    return Next();
                }
                else
                {
                    return null;    //OUT OF BOUNDS. Should never reach this.
                }
            }
            else
            {
                return choreCategories[categoryKeys[currentCategory]][currentChore++];
            }
        }

        //public bool hasNext()
        //{
        //    if (currentChore > choreCategories[categoryKeys[currentCategory]].Count -1)
        //    {
        //        if (currentCategory > categoryKeys.Count - 1)
        //        {
        //            currentCategory++;
        //            currentChore = 0;
        //            return hasNext();
        //        }
        //        else
        //        {
        //            return false;    //OUT OF BOUNDS. 
        //        }
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}
        public bool hasNext()
        {
            if (currentCategory > categoryKeys.Count - 1)
            {
                return false; // No more categories left
            }

            if (currentChore > choreCategories[categoryKeys[currentCategory]].Count - 1)
            {
                currentCategory++;
                currentChore = 0;
                return hasNext(); // Check next category
            }
            else
            {
                return true; // Chores left in current category
            }
        }

    }
}
