function doNot(fn) {
    return {
        unless: function(condition) {
            if(condition) fn();
        }
    }
}

doNot(() => console.log('Hello World!')).unless(!false);
