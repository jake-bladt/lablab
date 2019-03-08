function _compare(a, b) {
	a = a.toString().toLowerCase();
	b = b.toString().toLowerCase();

	if (a < b) return -1;
	if (a > b) return 1;
	return 0;
}

var x = "XYZ";
var a = "abC";
var vals = [x, a];

console.log(_compare(x, a));
console.log(x);
console.log(a);
console.log(vals);
