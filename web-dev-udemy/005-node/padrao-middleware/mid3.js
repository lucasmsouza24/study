var express = require('express');
var app = express();

app.get('/', function (req, res) {
  res.send('vai tomar no cu!');
});

app.listen(3000);