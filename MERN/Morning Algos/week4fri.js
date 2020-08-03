/* 
  Given two strings,
  return true if the first string can be built from the letters in the 2nd string
  Ignore case
  .indexOf will only tell you if the letter is found one time
*/

const { testDriver } = require("../..helpers");

const strA1 = "Hello World";
const strB1 = "lloeh wordl";
const expected1 = true;

const strA2 = "Hey";
const strB2 = "hello";
const expected2 = false;
// Explanation: second string is missing a "y"

const strA3 = "hello";
const strB3 = "helo";
const expected3 = false;
// Explanation: second string doesn't have enough "l" letters

const strA4 = "hello";
const strB4 = "lllheo";
const expected4 = true;

const testCases = [
    { arguments: [strA1, strB1], expected: expected1 },
    { arguments: [strA2, strB2], expected: expected2 },
    { arguments: [strA3, strB3], expected: expected3 },
    { arguments: [strA4, strB4], expected: expected4 },
];
testDriver([canBuildS1FromS2], testCases);

function canBuildS1FromS2(s1, s2) { }

/* 
  Given a string, find the length of the longest substring without repeating characters.
*/

const { testDriver } = require("../..helpers");

const str1 = "abcabcbb";
const expected1 = 3;
// Explanation: The answer is "abc", with the length of 3.

const str2 = "bbbbb";
const expected2 = 1;
// Explanation: The answer is "b", with the length of 1.

const str3 = "pwwkew";
const expected3 = 3;
/* Explanation: The answer is "wke", with the length of 3. 
  Note that the answer must be a substring, "pwke" is a subsequence and not a substring. */

const str4 = "dvadf";
const expected4 = 4;
// Explanation: "vadf"

const testCases = [
    { arguments: [str1], expected: expected1 },
    { arguments: [str2], expected: expected2 },
    { arguments: [str3], expected: expected3 },
    { arguments: [str4], expected: expected4 },
];
testDriver([lenOfLongestSubStr], testCases);

function lenOfLongestSubStr(str) { }




const { testDriver } = require("../..helpers");

const hour1 = 5;
const min1 = 00;
const expected1 = "five o' clock";

const hour2 = 5;
const min2 = 01;
const expected2 = "one minute past five";

const hour3 = 5;
const min3 = 10;
const expected3 = "ten minutes past five";

const hour4 = 5;
const min4 = 15;
const expected4 = "quarter past five";

const hour5 = 5;
const min5 = 30;
const expected5 = "half past five";

const hour6 = 5;
const min6 = 40;
const expected6 = "twenty minutes to six";

const hour7 = 5;
const min7 = 45;
const expected7 = "quarter to six";

const hour8 = 5;
const min8 = 47;
const expected8 = "thirteen minutes to six";

const hour9 = 5;
const min9 = 28;
const expected9 = "twenty eight minutes past five";

const hour10 = 12;
const min10 = 45;
const expected10 = "quarter to one";

const hour11 = 12;
const min11 = 00;
const expected11 = "twelve o' clock";

const testCases = [
    { arguments: [hour1, min1], expected: expected1 },
    { arguments: [hour2, min2], expected: expected2 },
    { arguments: [hour3, min3], expected: expected3 },
    { arguments: [hour4, min4], expected: expected4 },
    { arguments: [hour5, min5], expected: expected5 },
    { arguments: [hour6, min6], expected: expected6 },
    { arguments: [hour7, min7], expected: expected7 },
    { arguments: [hour8, min8], expected: expected8 },
    { arguments: [hour9, min9], expected: expected9 },
    { arguments: [hour10, min10], expected: expected10 },
    { arguments: [hour11, min11], expected: expected11 },
];
testDriver([timeInWords], testCases);

function timeInWords(hour, min) { }