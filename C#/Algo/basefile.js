// This is the class for our Singly Linked Node
class SLNode {
    // The constructor is built to take 1 parameter; the value of the node we want
    // to create
    constructor(val) {
        // The node's actual value being set to the value passed in through the constructor
        this.value = val;
        // And the pointer that refers to the node next in the sequence after
        // this node. Note it starts as null, because when you first create a node,
        // it is not connected to anything.
        this.next = null;
    }
}

// This is the class for our Singly Linked List
class SLList {
    constructor() {
        // The head marks the beginning of the linked list.
        this.head = null;

        // Note that it's null. This is because when you first create a list, it's empty!
    }

    // Write a method that returns a boolean based on whether or not the list
    // is empty. HINT! Check out 
    isEmpty() {
        //you can write it as an if check too
        // if (this.head === null) {
        //     return true;
        // }
        // else {
        //     return false;
        // }
        return this.head === null;
    }

    // Write a method that will add to the back of a singly linked list.

    // Essentially, have a runner start at the head, traverse along to the end, 
    // then create a new node at the end, and reassign the last node's .next pointer
    // to the new node.
    addToBack(value) {
        if (myList.isEmpty()) {
            this.head = new SLNode(value);
        }
        else {
            let runner = this.head;
            while (runner != null) {
                runner = runner.next;
            }
            runner.next = new SLNode(value)
        }
        return this;
    }

    // Write a method for our singly linked list class that will take a value, and
    // add a new node to the front of the current singly linked list.
    addToFront(value) {
        if (myList.isEmpty()) {
            this.head = new SLNode(value);
        }
        else {
            let temp = this.head;
            let myNode = new SLNode(value);
            this.head = myNode;
            myNode.next = temp;
        }
        return this;
    }

    // Write a method that will remove the head node from the 
    // Singly Linked List.
    removeHead() {
        if (!this.head) {
            return;
        }
        this.head = this.head.next;
        return this.head;
    }


    // Write a method that will calculate and return the average
    // of all the node's values in a singly linked list

    average() {
        if (this.isEmpty()) {
            console.log("this list is empty");
            return this;
        }
        else {
            var sum = this.head.value;
            var count = 1;
            var runner = this.head;
            while (runner.next != null) {
                runner = runner.next;
                sum += runner.value;
                count++;
            }
            console.log(count, "count", sum, "sum");
            console.log("Avg: " + sum / count);
            return this;
        }
    }
    // Write a method that determines whether or not the linked list contains
    // a node with a given value, and return a boolean based on that
    contains(value) {
        let runner = this.head;
        while (runner != null) {
            if (runner.value == value) {
                return true;
            }
            else {
                runner = runner.next;
            }
        }
        return false;
    }

    // Write a method that will remove the last node from the linked list.
    // HINT: Figuring out a way to find the SECOND TO LAST node will be immensely
    // helpful!
    // Return the node. Or the list. Idk, I'm not your dad.
    //must refactor later
    removeVal(value) {
        if (this.isEmpty()) {
            console.log("This list is empty");
            return this;
        }
        if (this.contains(value)) {
            let temp = this.head;
            let walker = this.head;
            let runner = this.head.next;
            if (walker.value == value) {
                this.removeHead();
            }
            while (runner.next != null) {
                if (runner.value == value && runner.next == null) {
                    this.removeFromBack();
                } else if (runner.value == value && runner.next !== null) {
                    let temp = runner;
                    runner = runner.next;
                    temp.next = null;
                } else {
                    //   temp.next = null;
                    return this;
                }
            }
        }

        return this;
    }
}



// Write a method that will find a node with a given value 
// and remove it from the linked list.

// Things to think about: What are your edge cases?

// HINT: Removing means point the previous node's .next to the
// current node's .next
removeVal(value) {

}

printList() {
    if (this.isEmpty()) {
        console.log("This list is empty");
        return this;
    }
    // We need to initialize an empty string
    let toPrint = "";
    // And start a runner at the head of the list.
    let runner = this.head;

    // We want to perform something every time runner isn't null
    while (runner != null) {
        // Add the new value and an arrow (oh so fancy, I know!)
        // to the string we want to print
        toPrint += `${runner.value} -> `;
        // And move runner to the next node. This is gonna be your 
        // bread and butter when it comes to linked lists
        runner = runner.next;
    }
    // What good is our print list method if it doesn't console log?!
    console.log(toPrint);

    // And just so we can chain methods (idk why you'd want to chain from print list,
    // but why not), just return this.

    return this;
}

}

// Here's a gimme: This will print the contents of a singly linked list.
