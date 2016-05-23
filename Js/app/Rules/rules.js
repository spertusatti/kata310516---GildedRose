
var functionalities = {
    increaseQuality: function increaseQuality() {
        var that = this,
            value= that.quality + 1;
        
        if (value > 50) value = 50;
        
        that.quality = value;
    },
    decreaseQuality: function decreaseQuality(){
        var that = this,
            value = that.quality - 1;
                
        if(value < 0) value = 0;
        
        that.quality = value;
    },
    decreaseSellIn: function decreaseSellIn() {
        var that = this;
        
        that.sellIn--;            
    },
    resetQuality: function resetQuality() {
        var that = this;
        
        that.quality = 0;
    }
};

module.export = functionalities;

