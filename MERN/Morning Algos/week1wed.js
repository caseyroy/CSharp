/* 
Stable
Visualization: https://www.hackerearth.com/practice/algorithms/sorting/merge-sort/visualize/
Time Complexity
    - Best case: O(n log(n)) linearithmic
    - Average case: O(n log(n)) linearithmic
    - Worst case: O(n log(n)) linearithmic
Space: O(n) linear
steps:
    1. create a merge function to merge two already sorted arrays into a single sorted array
        - you do NOT need to work in place, ok to use a new array
    2. create mergeSort function to sort the provided array
        - split the array in half and recursively merge the halves using the previously created merge function
        - splitting of arrays stops when array can no longer be split
        - an array of 1 item is by definition sorted, so two arrays of 1 item can therefore be merged into a sorted array
*/

const mergeArrX = [3, 5, 7];
const mergeArrY = [1, 2, 9];

const arrRandom = [9, 2, 5, 6, 4, 3, 7, 10, 1, 8];

const mergeThis = (arrx, arry) => {
    const new_array = [];
    let counterX = 0;
    let counterY = 0;
    while (counterX + counterY < arrx.length + arry.length){
        if (arrx[counterX] < arry[counterY]){
        new_array.push(arrx[counterX]);
        counterX++;
        }
        else {
        new_array.push(arry[counterY]);
        counterY++;
        }
    }
    return new_array;
}

const mergeSort = (array) => {
    if (array.length <= 1){
        return array;
    }
    const middle = Math.floor(array.length/2);
    const arrx = array.slice(0, middle);
    const arry = array.slice(middle);
    return mergeThis(mergeSort(arrx), mergeSort(arry))
}