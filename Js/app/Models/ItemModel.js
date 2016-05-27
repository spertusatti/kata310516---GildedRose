function Item(name, sellIn, quality, initialModification, decreaseSellIn, qualityModificationWhenExpire){
    var that = this;
    
    that.name = name;
    that.sellIn = sellIn;
    that.quality = quality;
    that.initialModification = initialModification || function (){};
    that.decreaseSellIn = decreaseSellIn || function(){};  
    that.qualityModificationWhenExpire = qualityModificationWhenExpire || function (){};
          
    return that;
};

Item.prototype.updateQuality = function updateQuality(){
    var that = this;
    // Initial modification of the quality value
    that.initialModification.call(that);
  
    // decrease sellIn 
    that.decreaseSellIn.call(that);
  
     // if item expire, modify the quality
    if(that.sellIn < 0){
        that.qualityModificationWhenExpire.call(that);    
    }    
};

Item.prototype.toString =function toString() {
    var that = this,
        value = that.name + " expires on " + that.sellIn + " and quality " + that.quality;
        
    return value;
};

module.exports = Item;