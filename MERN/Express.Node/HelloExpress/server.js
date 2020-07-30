const express = require("express");
const app = express();
const port = 8000;

// req is short for request
// res is short for response
app.get("/api", (req, res) => {
  res.send('hey we dont need this in a message object!!!');
});

const server = app.listen(8000, () =>
  console.log(`Server is locked and cocked on port ${server.address().port}!`)
);
