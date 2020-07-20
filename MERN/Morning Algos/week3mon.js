/* 
    Recreate Object.entries method
    Given an object,
    return an array of arrays of the object's key value pairs, where each key value pair is a 2 item array
    Do not include key value pairs from the given objects prototype (these are included by default when looping over an object's keys)
*/

const { testDriver } = require("../../helpers");

const obj1 = { firstName: "Foo", lastName: "Bar", age: 13 };
obj1.__proto__.keyOnProto = "val from proto";
const expected1 = [
    ["firstName", "Foo"],
    ["lastName", "Bar"],
    ["age", 13],
];

const testCases = [{ arguments: [obj1], expected: expected1 }];
testDriver([entries], testCases);

function entries(obj) { }

/* ******************************************************************************** */

/* 
    Given a table name string and an object whose key value pairs represent column names and values for the columns
    return a SQL insert statement string
    Tip: string interpolation (using back ticks, the key to the left of num 1 key) make it easy to add variables into a string or to add quotations without needing to escape them.
    Bonus: after solving it, write a 2nd solution focusing on functional programming using built in methods
*/

const { testDriver } = require("../../helpers");

const table = "users";
const insertData1 = { first_name: "John", last_name: "Doe" };
const expected1 =
    "INSERT INTO users (first_name, last_name) VALUES ('John', 'Doe');";

// Bonus:
const insertData2 = {
    first_name: "John",
    last_name: "Doe",
    age: 30,
    is_admin: false,
};
const expected2 =
    "INSERT INTO users (first_name, last_name, age, is_admin) VALUES ('John', 'Doe', 30, false);";
// Explanation: no quotes areount the int or the bool, technically in SQL the bool would become a 0 or 1, but don't worry about that here.

const testCases = [
    { arguments: [table, insertData1], expected: expected1 },
    { arguments: [table, insertData2], expected: expected2 },
];
testDriver([insert, insertFunctional], testCases);

function insert(tableName, columnValuePairs) { }

function insertFunctional(tableName, columnValuePairs) { }

/* ******************************************************************************** */