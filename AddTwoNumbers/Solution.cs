﻿public class ListNode {
    public int val;

    public ListNode next;

    public ListNode(int val = 0, ListNode next = null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int buffer = 0) {
        if (l1 == null && l2 == null && buffer == 0) {
            return null;
        }

        var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + buffer;
        buffer = sum / 10;
        
        return new ListNode(sum % 10, AddTwoNumbers(l1?.next, l2?.next, buffer));
    }
}