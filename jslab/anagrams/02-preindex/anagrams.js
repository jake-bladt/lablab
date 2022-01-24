"use strict";

console.log('Script loaded.');

let dictionary;
let lastWord;
let index = {};

let sortLetters = (word) => word.split("").sort().join("");

function indexEntry(word) {
  var sorted = sortLetters(word);
  if(index[sorted]) {
    index[sorted].push(word);
  } else {
    index[sorted] = [word];
  }
  console.log(`index[${sorted}] = ${index[sorted].join(", ")}`);
}

fetch(
  'https://gist.githubusercontent.com/dlants/d3b25b0f6c0bf8d023f65e86498bf9e6/raw/b310b5aff00f62f5073b3b8d366f5a639aa88ee3/3000-words.txt'
).then(
    (res) => {
      console.log('Word list received.');
      return res.text();
    } 
).then(
    (text) => {
      console.log('Word list received.');
      dictionary = (new String(text)).split('\n');
      for(let n = 0; n < dictionary.length; n++) {
        indexEntry(dictionary[n]);
      }
});

function onInput(input) {
  let candidate = sortLetters(input.value);
  const o = indexEntry[candidate] || [];
  document.getElementById('output').innerHTML = JSON.stringify(o, null, 2)
}
