var constants = require('../Utilities/constants.js'),
    Item = require('../Models/ItemModel.js');

var items = [
  new Item({name = constants.dexterityVestPlus5,  sellIn = 10, quality = 20}),
  new Item({name = constants.agedBrie,            sellIn =  2, quality =  0}),
  new Item({name = constants.elixirOfTheMongoose, sellIn =  5, quality =  7}),
  new Item({name = constants.sulfuras,            sellIn =  0, quality = 80}),
  new Item({name = constants.backstagePasses,     sellIn = 15, quality = 20}),
  new Item({name = constants.conjuredManaCake,    sellIn =  3, quality =  6}),
];


module.export = items;

