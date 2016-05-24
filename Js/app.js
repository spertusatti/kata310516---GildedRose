var items = require('./app/Ini/loadGame.js'),
    itemService = require('./app/Services/itemService.js');
for (var index = 0; index < items.length; index++) {
  console.log(items[index].toString());
}


itemService.updateQuality(items);
console.log(" ------------");
console.log(" after update");
console.log(" ------------");

for (var index = 0; index < items.length; index++) {
  console.log(items[index].toString());
}