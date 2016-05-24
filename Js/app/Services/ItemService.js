function ItemService(){
};

ItemService.prototype.updateQuality = function updateQuality(items){
    items.forEach(i => i.updateQuality());
};


module.exports = new ItemService();