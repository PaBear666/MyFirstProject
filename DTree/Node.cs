using System;
using System.Collections.Generic;
using System.Text;

namespace DTree
{
    public class Node // Класс «Узел односвязного списка»
    {
        public char Info { get; set; }
        public Node Link { get; set; }

        public Node(char info)
        {
            Info = info;
        }
        public Node(char info, Node link) : this(info)
        {
            Link = link;
        }
    }
}
