Binary Trees

Trees are very common data structure in computer science.
A tree is a non linear data structure that is used to store data in a hierarchical manner.

Binary trees are often chosen over more fundamental structures, such as arrays and linked lists,
because you can search a binary tree quickly(as opposed to a linked list) and you can quickly
insert data and delete data from a binary tree(as opposed to an array).

# Tree

A tree is a set of nodes connected by edges.
For instance, say there is an organizational chart.
Each box is node and the lines connecting the boxes are the edges. 
Nodes obviously represent the entities that make up an organization, and the edges represent 
the relationship between the entities. 

The top node of a tree is called the root node.
If a node is connected to other nodes below it, the top node is called the parent, 
and the nodes below it are called the parent's children. 
A node without any child node is called a leaf.

Special types of trees, called binary trees, restrict the number of children to no more than two.
Binary trees have certain computational properties that make them very effecient for many operations.

The series of edges you follow to get from one node to another is called a path.
Visiting all the nodes in a tree in some particular order is known as a tree transversal.

A tree can be broken down into levels. A node at any level is considered the root of a subtree.
We can define the depth of a tree as the number of layers in the tree.

Finally, each node in a tree has a value. This value is sometimes referred to as the key value.


# Binary Trees

By limiting the number of children to 2, we can write efficient programs for inserting data,
deleting data, and searching for data in a binary tree.

The child nodes of a parent node are referred to as the left node and the right node. 
Identifying the child nodes is important when we consider a more specific type of binary tree - the binary search tree.

Data with lesser values are stored in left nodes and values with greater values are stored in right nodes.


---------------------------
Binary search trees are a special type of data structure called a tree.
A tree is a collection of nodes(objects that consist of fields for data and links to other nodes) that are connected to other nodes.

Algorithms for finding the minimum and maximum values in a binary search tree are very easy to write.
We can also simply define algorithms for traversing binary search trees in different orders(inorder, preorder, postorder).
These definitions make use of recursion, keeping the number of lines of code to a minimum while making their analysis a bit harder.

Binary search trees are most useful when the data stored in the structure are obtained in a random order.
If the data in the tree are obtained in sorted or close-to-sorted order, the tree will be unbalanced and the search algorithms will not work as well.

