using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTDL_project
{
    internal class Node
    {
        internal Control data;
        internal Node next;

        // Constructor to create a new node.Next is by default initialized as null
        public Node(Control d)
        {
            data = d;
            next = null;
        }
    }
}
