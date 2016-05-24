
var functionalities = {
    increaseQuality: function increaseQuality(increment) {
        var that = this,
            value=0;
            console.log(" ->>>> " + increment);
        if(increment == null || increment < 1) increment = 1;
            console.log(" ->>>> " + increment);
            console.log(" ->>>> " + value);
            console.log(" ->>>> -" + that.quality);
        
        value = that.quality + increment;
            console.log(" ->>>> " + value);
        
        if (value > 50) value = 50;
            console.log(" ->>>> " + value);
        
        that.quality = value;
    },
    increaseQualityBackstage: function increaseQualityBackstage(){
        var that= this;
        
        functionalities.increaseQuality();
        
        if (that.sellIn < 10) functionalities.increaseQuality();  
        if (that.sellIn < 5) functionalities.increaseQuality();  
          
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

