using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Tree<T>
    {
        public T Value { get; set; }

        public Tree<T> Parent { get; set; }

        public List<Tree<T>> Children { get; set; }

        public Tree(T value, params Tree<T>[] children)
        {
            this.Value = value;
            this.Children = new List<Tree<T>>();

            foreach (var item in children)
            {
                item.Parent = this;
                Children.Add(item);
            }
        }
    }
}
