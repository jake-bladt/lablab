"use strict";

let sortLetters = (word) => word.split("").sort().join("");

function setNextAlpha(word) {

    let revOrderPos = -1;
    let pos, firstLetter, secondLetter;
  
    // Starting from the end of the word, find two letters that are in alphabetical order.
    for(pos = word.length - 1; pos > 0; pos--) {
      firstLetter = word[pos - 1];
      secondLetter = word[pos];
      // console.log(`Letters are [${firstLetter}, ${secondLetter}]`);
      if(firstLetter < secondLetter) {
        revOrderPos = pos - 1;
        break;
      } 
    }
  
    // The whole word is in reverse alphabetical order.
    if(revOrderPos === -1) return false;
  
    // Special case: first letter needs swap
    if(revOrderPos === 0) {
      let startsWith = word.substring(0, 1);
      console.log(startsWith);
      return false;
    }
  
    let before = word.substring(0, revOrderPos);
    let after = word.substring(revOrderPos + 2);
    
    return `${before}${secondLetter}${firstLetter}${after}`;
  
    // Special case: duplicate letters?
  }


let word = process.argv[2];

while(word = setNextAlpha(word)) {
  console.log(word);
}
