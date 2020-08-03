/* 
Given an honorific (name title) and array of full name strings,
in "LastName, FirstName" format

Return a new array of strings in this format: "Honorific FirstName LastName"
Bonus: re-write it with built in functional programming methods
*/

const { testDriver } = require("../../helpers");

const honorific1 = "Mr.";
const names1 = [];
const expected1 = [];

const honorific2 = "Sir";
const names2 = ["Sanchez, Rick", "Smith, Jerry"];
const expected2 = ["Sir Rich Sanchez", "Sir Jerry Smith"];

const honorific3 = "Mrs.";
const names3 = ["HorseDoctor, Beth"];
const expected3 = ["Mrs. Beth HorseDoctor"];

const testCases = [
    { arguments: [honorific1, names1], expected: expected1 },
    { arguments: [honorific2, names2], expected: expected2 },
    { arguments: [honorific3, names3], expected: expected3 },
];
testDriver([addHonorific, addHonorificFunctional], testCases);

function addHonorific(honorific, fullNames) { }

function addHonorificFunctional(honorific, fullNames) { }


/* 
Given two strings, version1, and version2, both representing version numbers
If version1 > version2 return 1; if version1 < version2 return -1; otherwise return 0.
Helpful methods:
    - .split(characterToSplitOn)
    - returns an array of items: "a-b-c".split("-") returns ["a", "b", "c"]
    - .parseInt
    - given a string, converts it to and returns int or NaN (Not a Number) if conversion fails
Bonus, solve without .split
*/

const { testDriver } = require("../../helpers");

const test1V1 = "0.1";
const test1V2 = "1.1";
const expected1 = -1;

const test2V1 = "1.0.1";
const test2V2 = "1";
const expected2 = 1;

const test3V1 = "7.5.2.4";
const test3V2 = "7.5.3";
const expected3 = -1;

const test4V1 = "7.5.2.4";
const test4V2 = "7.5.2";
const expected4 = 1;

const test5V1 = "1.01";
const test5V2 = "1.001";
const expected5 = 0;
// Explanation: Ignoring leading zeroes, both “01” and “001" represent the same number “1”

const test6V1 = "1.0.1";
const test6V2 = "1";
const expected6 = 1;

const testCases = [
    { arguments: [test1V1, test1V2], expected: expected1 },
    { arguments: [test2V1, test2V2], expected: expected2 },
    { arguments: [test3V1, test3V2], expected: expected3 },
    { arguments: [test4V1, test4V2], expected: expected4 },
    { arguments: [test5V1, test5V2], expected: expected5 },
    { arguments: [test6V1, test6V2], expected: expected6 },
];
testDriver([compareVersions], testCases);

function compareVersions(v1, v2) { }