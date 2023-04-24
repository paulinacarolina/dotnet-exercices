//Problema de leet code
//https://leetcode.com/problems/reverse-linked-list/description/

//Se trata de revertir una lista enlazada
//input: 1->-2->3
//output 3->2->1

//El enfoqué que use fue leer la lista de entrada y almacenar los numeros en un Stack (pila) 
//Después, extraer los números del Stack e irlos agregando en una segunda lista enlazada hasta vaciarla. 
//Recuerda que el Stack es un LastInFirstOut. Último en entrar, primero en salir de modo que obtenemos los numeros en el orden esperado sin necesidad de un loop.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        //let's try the following approach
        //read first the linked list
        //store the numbers using a stack
        //then pop the items from the stack and add them to a new linked list
        Stack<int> stack = new Stack<int>();
        var currentNode = head;
        while(true)
        {
            if(currentNode == null) break;
            else
            {
                stack.Push(currentNode.val);
                currentNode = currentNode.next;
            }
        }

        if(stack.Count == 0) return null;
        
        head = null;
        currentNode = null;

        while(stack.Count > 0)
        {
            if(head == null) head = new ListNode(stack.Pop(), null);
            else if(head.next == null) {
                currentNode = new ListNode(stack.Pop(), null);
                head.next = currentNode;
            }
            else
            {
                var next = new ListNode(stack.Pop(), null);
                currentNode.next = next;
                currentNode = next;
            }
        }
        return head;
    }
}
