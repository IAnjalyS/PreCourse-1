    using System.Collections.Generic;
//Resubmitting as first pull request was not considered
public class GFG { 
       
    /* A binary tree node has key, pointer to  
    left child and a pointer to right child */
    static class Node { 
        int key; 
        Node left, right; 
          
        // constructor 
        Node(int key){ 
            this.key = key; 
            left = null; 
            right = null; 
        } 
    } 
    static Node root; 
    static Node temp = root; 
      
    /* Inorder traversal of a binary tree*/
    static void inorder(Node temp) 
    { 
        if (temp == null) 
            return; 
       
        inorder(temp.left); 
        Console.WriteLine(temp.key+" "); 
        inorder(temp.right); 
    } 
       
    /*function to insert element in binary tree */
    static void insert(Node temp, int key) 
    { 

        // Do level order traversal until we find 
        // an empty place and add the node.  
        if (temp == null) {
            root = new Node(key);
            return;
        }
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(temp);
 
        // Do level order traversal until we find
        // an empty place and add the node.
        while (q.Count != 0) {
            temp = q.Peek();
            q.Dequeue();
 
            if (temp.left == null) {
                temp.left = new Node(key);
                break;
            }
            else
                q.Enqueue(temp.left);
 
            if (temp.right == null) {
                temp.right = new Node(key);
                break;
            }
            else
                q.Enqueue(temp.right);
        }
    } 
       
    // Driver code 
    public static void main(String[] args) 
    { 
        root = new Node(10); 
        root.left = new Node(11); 
        root.left.left = new Node(7); 
        root.right = new Node(9); 
        root.right.left = new Node(15); 
        root.right.right = new Node(8); 
       
         Console.WriteLine( "Inorder traversal before insertion:"); 
        inorder(root); 
       
        int key = 12; 
        insert(root, key); 
       
         Console.WriteLine("\nInorder traversal after insertion:"); 
        inorder(root); 
    } 
}