'use strict'

const parse = (str) => {
  let res = str;

  for (let i = 0; i < str.length / 2; i++) {
    res = res.replace(/[(]{1}[)]{1}/g,'');
    res = res.replace(/[{]{1}[}]{1}/g,'');
    res = res.replace(/[\[]{1}[\]]{1}/g,'');
  }

  if (res.length > 0) return false; else return true;
}

console.log(parse('([)]'));
console.log(parse('[({})](])'));
console.log(parse('([{}])'));
