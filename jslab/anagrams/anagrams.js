let dictionary;
let lastWord;
let index = {};

let sortLetters = (word) => word.split("").sort().join("");

function indexEntry(pos, word) {
  for(i = 1; i <= word.length; i++) {
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
      for(n = 0; n < dictionary.length; n++) {
        indexEntry(n, dictionary[n]);
      }
});

function onInput(input) {
  const sortedLetters =  sortLetters(input.value);
  const ndx = index[sortedLetters];

  if(ndx) {
      console.log(`Words starting with ${sortedLetters}:`);
      for(i = ndx.start; i <= ndx.end; i++) {
          console.log(dictionary[i]);
      }
  }

  const o = []

//  for (let word2 of (dictionary || [])) {
    // sort each word for comparison
//    const sortedWord = word.split("").sort().join("")
//    const sortedWord2 = word2.split("").sort().join("")
//    if (sortedWord == sortedWord2) {
//      o.push(word2)
//    }
// }

  document.getElementById('output').innerHTML = JSON.stringify(o, null, 2)
}
