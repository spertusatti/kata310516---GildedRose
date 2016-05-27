
var functionalities = {
    increaseQuality: function increaseQuality(increment) {
        var that = this,
            value = 0;

        if(increment == null || increment < 1) increment = 1;
        
        value = that.quality + increment;
        
        if (value > 50) value = 50;
        
        that.quality = value;
    },
    increaseQualityBackstage: function increaseQualityBackstage(){
        var that = this;
        functionalities.increaseQuality.call(that);
        
        if (that.sellIn < 10) functionalities.increaseQuality.call(that);  
        if (that.sellIn < 5) functionalities.increaseQuality.call(that);  
          
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

module.exports = functionalities;

