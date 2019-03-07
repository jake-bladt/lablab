function _compareCaseInsensitive(a, b) {
                    var alc = a.toString().toLowerCase();
                    var blc = b.toString().toLowerCase();
                    if (alc < blc) return -1;
                    if (alc > blc) return 1;
                    return 0;
                }

console.log(_compareCaseInsensitive("SAML", "saml");
console.log(_compareCaseInsensitive("Jake", "bake");
console.log(_compareCaseInsensitive("Jake", "wake");
