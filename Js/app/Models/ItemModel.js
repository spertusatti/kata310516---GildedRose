function Item(item){
    var that = this;
    
    item =item || {};
    
    that.name = item.name || "";
    that.sellIn = item.sellIn || "";
    that.quality = item.quality || "";
    that.updateQuality = item.updateQuality;
          
    return that;
}
/*
Item.prototype.updateQuality = function updateQuality(){
    
};
*/
module.export = Item;