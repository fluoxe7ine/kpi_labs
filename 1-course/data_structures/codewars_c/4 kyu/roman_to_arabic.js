const dict = {I: 1, V: 5, X: 10, L: 50, C: 100, D: 500, M: 1000};

const solution = (roman) => {
  let res = 0;

  const objectValue = (el) => {
    for (let prop in dict) {
        if (prop == el) return dict[prop];
      }
  }

  roman = roman.split('');
  for (let i = 0; i < roman.length; i++) {
    if (objectValue(roman[i]) < objectValue(roman[i+1])) {
      res += objectValue(roman[i+1]) - objectValue(roman[i]);
      i++;
    } else res += objectValue(roman[i]);
  }
  return res;
}

console.log(solution('XXI'));
