var constants = require('../Utilities/constants.js'),
    Item = require('../Models/ItemModel.js'),
    rules = require('../Rules/rules.js');

var items = [
  new Item(constants.dexterityVestPlus5,  10,  20, rules.decreaseQuality, rules.decreaseSellIn, rules.incrementQuality),
  new Item(constants.agedBrie,             2,   0, rules.incrementQuality, rules.decreaseSellIn, rules.incrementQuality),
  new Item(constants.elixirOfTheMongoose,  5,   7, rules.decreaseQuality, rules.decreaseSellIn, rules.incrementQuality),
  new Item(constants.sulfuras,             0,  80, null, null, null),
  new Item(constants.backstagePasses,     15,  20, rules.increaseQualityBackstage, rules.decreaseSellIn, rules.resetQuality),
  new Item(constants.conjuredManaCake,    3,    6, rules.decreaseQuality, rules.decreaseSellIn, rules.incrementQuality),
];


module.exports = items;

