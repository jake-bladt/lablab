"use strict";

console.log('Script loaded.');

let dictionary;
let lastWord;
let index = {};

let sortLetters = (word) => word.split("").sort().join("");

function scanWord(word, found) {
  let i = 1;
  while(i <= word.length) {
    const wordStart = word.substring(0, i);
    if(index[wordStart]) { i++ } else {
      console.log(`scan for ${word} stops at ${wordStart}`);
      i = word.length + 1; // create stop condition
    }
  }
}

function indexEntry(pos, word) {
  for(let i = 1; i <= word.length; i++) {
      let wordStart = word.substring(0, i);
      if(index[wordStart]) {
        index[wordStart].end = pos;
        // console.log(`Index of ${wordStart} ends at ${pos} on word ${dictionary[pos]}`);
      } else {
        index[wordStart] = { "start": pos, "end": pos };
        // console.log(`Index of ${wordStart} starts at ${pos} on word ${dictionary[pos]}`);
      }
  }
}


fetch(
  'https://gist.githubusercontent.com/dlants/d3b25b0f6c0bf8d023f65e86498bf9e6/raw/b310b5aff00f62f5073b3b8d366f5a639aa88ee3/3000-words.txt'
).then(
    (res) => res.text()
).then(
    (text) => {
      dictionary = (new String(text)).split('\n');
      for(let n = 0; n < dictionary.length; n++) {
        indexEntry(n, dictionary[n]);
      }
});

function onInput(input) {
  const o = []
  let candidate = sortLetters(input.value);
  scanWord(candidate, o);

  document.getElementById('output').innerHTML = JSON.stringify(o, null, 2)
}
